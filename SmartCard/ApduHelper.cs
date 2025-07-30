using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static SmartCard.SmartCardManager;

namespace SmartCard
{

    public static class ApduHelper
    {

        private const uint SCARD_SCOPE_USER = 0;
        private const uint SCARD_SHARE_SHARED = 2;
        private const uint SCARD_PROTOCOL_T0 = 1;
        private const uint SCARD_PROTOCOL_T1 = 2;
        private const int SCARD_LEAVE_CARD = 0;

        //public static byte[] GetATR(SmartCardManager manager) => Readers.GetCardATR(manager);
        [DllImport("winscard.dll")]
        private static extern int SCardStatus(IntPtr hCard, StringBuilder szReaderName, ref int pcchReaderLen, out uint pdwState, out uint pdwProtocol, byte[] pbAtr, ref int pcbAtrLen);
        
        [DllImport("winscard.dll")]
        private static extern int SCardEstablishContext(uint dwScope, IntPtr pvReserved1, IntPtr pvReserved2, out IntPtr phContext);

        [DllImport("winscard.dll")]
        private static extern int SCardReleaseContext(IntPtr phContext);

        [DllImport("winscard.dll")]
        private static extern int SCardDisconnect(IntPtr hCard, int dwDisposition);


        public static byte[] GetCardATR(IntPtr hCard)
        {
            int atrLen = 33;
            byte[] atr = new byte[atrLen];
            int readerLen = 256;
            StringBuilder readerNameBuilder = new StringBuilder(readerLen);
            uint state, protocol;

            int result = SCardStatus(hCard, readerNameBuilder, ref readerLen, out state, out protocol, atr, ref atrLen);
            if (result != 0)
                return null;

            Array.Resize(ref atr, atrLen);
            return atr;
        }

        public static byte[] SelectAID(byte[] aid) =>
            new byte[] { 0x00, 0xA4, 0x04, 0x00, (byte)aid.Length }.Concat(aid).ToArray();

        public static byte[] GetChallenge(int length = 8) =>
            new byte[] { 0x00, 0x84, 0x00, 0x00, (byte)length };


        public static byte[] TransmitApduCommand(string readerName, byte[] apduCommand)
        {
            IntPtr hContext;
            if (SCardEstablishContext(SCARD_SCOPE_USER, IntPtr.Zero, IntPtr.Zero, out hContext) != 0)
                return null;

            uint activeProtocol;
            IntPtr hCard;
            int result = SCardConnect(hContext, readerName, SCARD_SHARE_SHARED, SCARD_PROTOCOL_T0 | SCARD_PROTOCOL_T1, out hCard, out activeProtocol);
            if (result != 0)
            {
                SCardReleaseContext(hContext);
                return null;
            }

            SCARD_IO_REQUEST ioRequest = new SCARD_IO_REQUEST
            {
                dwProtocol = activeProtocol,
                cbPciLength = (uint)Marshal.SizeOf(typeof(SCARD_IO_REQUEST))
            };

            IntPtr pioSendPci = Marshal.AllocHGlobal(Marshal.SizeOf(ioRequest));
            Marshal.StructureToPtr(ioRequest, pioSendPci, false);

            List<byte> fullResponse = new List<byte>();
            byte[] commandToSend = apduCommand;

            while (true)
            {
                byte[] recvBuffer = new byte[258];
                int recvLength = recvBuffer.Length;

                result = SCardTransmit(hCard, pioSendPci, commandToSend, commandToSend.Length, IntPtr.Zero, recvBuffer, ref recvLength);
                if (result != 0)
                {
                    Marshal.FreeHGlobal(pioSendPci);
                    SCardDisconnect(hCard, SCARD_LEAVE_CARD);
                    SCardReleaseContext(hContext);
                    return null;
                }

                Array.Resize(ref recvBuffer, recvLength);

                if (recvLength >= 2)
                {
                    byte sw1 = recvBuffer[recvLength - 2];
                    byte sw2 = recvBuffer[recvLength - 1];

                    if (sw1 == 0x61)
                    {
                        fullResponse.AddRange(recvBuffer.Take(recvLength - 2));

                        byte le = (sw2 == 0x00) ? (byte)0xFF : sw2; // 0x00 = ต้องขอ 256 byte
                        commandToSend = new byte[] { 0x00, 0xC0, 0x00, 0x00, le };
                        continue;
                    }

                    fullResponse.AddRange(recvBuffer);
                    break;
                }
                else
                {
                    fullResponse.AddRange(recvBuffer);
                    break;
                }
            }

            Marshal.FreeHGlobal(pioSendPci);
            SCardDisconnect(hCard, SCARD_LEAVE_CARD);
            SCardReleaseContext(hContext);

            return fullResponse.ToArray();
        }

        public static byte[] BuildApdu(byte cla, byte ins, byte p1, byte p2, byte[] data = null, byte? le = null)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                ms.WriteByte(cla);
                ms.WriteByte(ins);
                ms.WriteByte(p1);
                ms.WriteByte(p2);

                if (data != null && data.Length > 0)
                {
                    ms.WriteByte((byte)data.Length);  // Lc
                    ms.Write(data, 0, data.Length);   // Data
                }

                if (le.HasValue)
                {
                    ms.WriteByte(le.Value);           // Le
                }

                return ms.ToArray();
            }
        }

    }

}
