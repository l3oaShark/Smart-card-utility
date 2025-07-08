using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCard
{
    //public class SmartCardManager : IDisposable
    public class SmartCardManager
    {
        private const uint SCARD_SCOPE_USER = 0;
        private const uint SCARD_SHARE_SHARED = 2;
        private const uint SCARD_PROTOCOL_T0 = 1;
        private const uint SCARD_PROTOCOL_T1 = 2;
        private const int SCARD_LEAVE_CARD = 0;
        private const int SCARD_UNPOWER_CARD = 2;

        private IntPtr _context;
        private IntPtr _card;
        private uint _protocol;


        [DllImport("winscard.dll")]
        private static extern int SCardEstablishContext(uint dwScope, IntPtr pvReserved1, IntPtr pvReserved2, out IntPtr phContext);

        [DllImport("winscard.dll")]
        private static extern int SCardListReaders(IntPtr hContext, byte[] mszGroups, byte[] mszReaders, ref int pcchReaders);

        [DllImport("winscard.dll")]
        private static extern int SCardReleaseContext(IntPtr phContext);

        [DllImport("winscard.dll")]
        public static extern int SCardConnect(IntPtr hContext, string szReader, uint dwShareMode, uint dwPreferredProtocols, out IntPtr phCard, out uint pdwActiveProtocol);

        [DllImport("winscard.dll")]
        private static extern int SCardDisconnect(IntPtr hCard, int dwDisposition);

        [DllImport("winscard.dll")]
        private static extern int SCardStatus(IntPtr hCard, StringBuilder szReaderName, ref int pcchReaderLen, out uint pdwState, out uint pdwProtocol, byte[] pbAtr, ref int pcbAtrLen);

        [DllImport("winscard.dll")]
        public static extern int SCardTransmit(IntPtr hCard, IntPtr pioSendPci, byte[] pbSendBuffer, int cbSendLength, IntPtr pioRecvPci, byte[] pbRecvBuffer, ref int pcbRecvLength);

        [DllImport("SmartCardNative.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ExecuteApduCommand(
        byte[] apdu,
        int length,
        byte[] response,
        ref int responseLength);


        [DllImport("winscard.dll", EntryPoint = "g_rgSCardT0Pci", SetLastError = false)]
        public static extern IntPtr GetPciT0();

        [DllImport("winscard.dll", EntryPoint = "g_rgSCardT1Pci", SetLastError = false)]
        public static extern IntPtr GetPciT1();


        [StructLayout(LayoutKind.Sequential)]
        public struct SCARD_IO_REQUEST
        {
            public uint dwProtocol;
            public uint cbPciLength;
        }

        public static readonly SCARD_IO_REQUEST T0_PCI = new SCARD_IO_REQUEST { dwProtocol = 1, cbPciLength = (uint)Marshal.SizeOf(typeof(SCARD_IO_REQUEST)) };
        public static readonly SCARD_IO_REQUEST T1_PCI = new SCARD_IO_REQUEST { dwProtocol = 2, cbPciLength = (uint)Marshal.SizeOf(typeof(SCARD_IO_REQUEST)) };

        public IntPtr EstablishContext()
        {
            IntPtr hContext;
            SCardEstablishContext(SCARD_SCOPE_USER, IntPtr.Zero, IntPtr.Zero, out hContext);
            return hContext;
        }
        public static IntPtr PowerOnCard(IntPtr hContext, string readerName, out IntPtr hCard)
        {
            uint activeProtocol;
            int result = SCardConnect(hContext, readerName, SCARD_SHARE_SHARED, SCARD_PROTOCOL_T0 | SCARD_PROTOCOL_T1, out hCard, out activeProtocol);
            return (result == 0) ? hCard : IntPtr.Zero;
        }

        public static void PowerOffCard(IntPtr hCard)
        {
            int result = SCardDisconnect(hCard, SCARD_UNPOWER_CARD);
            if (result != 0)
            {
                MessageBox.Show("Power Off ล้มเหลว");
            }
        }
        public static List<string> GetSmartCardReaders()
        {
            List<string> readersList = new List<string>();
            IntPtr hContext;
            if (SCardEstablishContext(SCARD_SCOPE_USER, IntPtr.Zero, IntPtr.Zero, out hContext) != 0)
                return readersList;

            int size = 0;
            SCardListReaders(hContext, null, null, ref size);
            byte[] buffer = new byte[size];
            SCardListReaders(hContext, null, buffer, ref size);

            string readerListString = Encoding.ASCII.GetString(buffer);
            string[] readers = readerListString.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
            readersList.AddRange(readers);

            SCardReleaseContext(hContext);
            return readersList;
        }

        public static byte[] GetCardSerialNumber(string readerName)
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

            SCARD_IO_REQUEST sendPci = (activeProtocol == SCARD_PROTOCOL_T0) ? T0_PCI : T1_PCI;

            byte[] apdu = new byte[] { 0xFF, 0xCA, 0x00, 0x00, 0x00 }; // APDU command to get serial number ISO14443 (Mifare)

            byte[] recvBuffer = new byte[256];
            int recvLength = recvBuffer.Length;


            GCHandle handle = GCHandle.Alloc(sendPci, GCHandleType.Pinned);
            result = SCardTransmit(hCard, handle.AddrOfPinnedObject(), apdu, apdu.Length, IntPtr.Zero, recvBuffer, ref recvLength);
            handle.Free();

            if (result != 0)
            {
                SCardDisconnect(hCard, SCARD_LEAVE_CARD);
                SCardReleaseContext(hContext);
                return null;
            }

            SCardDisconnect(hCard, SCARD_LEAVE_CARD);
            SCardReleaseContext(hContext);

            if (recvLength >= 2 && recvBuffer[recvLength - 2] == 0x90 && recvBuffer[recvLength - 1] == 0x00)
            {
                byte[] sn = new byte[recvLength - 2];
                Array.Copy(recvBuffer, sn, recvLength - 2);
                return sn;
            }

            return null;
        }

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




        //public SmartCardManager()
        //{
        //    var result = Readers.SCardEstablishContext(0, IntPtr.Zero, IntPtr.Zero, out _context);
        //    if (result != 0) throw new Exception("Failed to establish context.");
        //}

        //public void Connect(string readerName)
        //{
        //    Readers.SCardConnect(_context, readerName, 2, 3, out _card, out _protocol);
        //}

        //public byte[] Transmit(byte[] apdu)
        //{
        //    return Readers.TransmitApdu(_card, _protocol, apdu);
        //}

        //public void Dispose()
        //{
        //    if (_card != IntPtr.Zero) Readers.SCardDisconnect(_card, 0);
        //    if (_context != IntPtr.Zero) Readers.SCardReleaseContext(_context);
        //}
    }

}
