using System;
using System.Collections.Generic;
using System.Linq;
using Encryptions;
using static SmartCard.TlvParser;

namespace SmartCard
{
    public class SmartCardInfo
    {
        private readonly SmartCardManager _manager;

        public SmartCardInfo(SmartCardManager manager)
        {
            _manager = manager;
        }

        //public Dictionary<string, string> GetCardInfo()
        //{
        //    var apdu = ApduHelper.GetChallenge();
        //    var response = _manager.Transmit(apdu);

        //    var info = new Dictionary<string, string>();
        //    if (response != null && response.Length >= 2 && response[response.Length-2] == 0x90 && response[response.Length-1] == 0x00)
        //    {
        //        info["Challenge"] = BitConverter.ToString(response.Take(response.Length - 2).ToArray());
        //    }
        //    else
        //    {
        //        info["Error"] = "Failed to get challenge.";
        //    }

        //    return info;
        //}

        /// <summary>
        /// อ่านข้อมูล card info แบบรวมในรูปแบบ TLV (ส่ง APDU command ที่ card กำหนด)
        /// </summary>
        public static List<TLV> GetCardInfoTLV(string readerName)
        {
            // ตัวอย่าง APDU สมมติ: อ่านข้อมูล card info ที่ tag ต่าง ๆ รวมใน TLV structure
            // ต้องเปลี่ยน APDU นี้ให้ตรงกับ card จริง เช่น INS=0xCA (GET DATA), P1, P2 ตาม tag หรือตาม protocol

            byte[] apduCommand = new byte[] { 0x00, 0xCA, 0x01, 0x00, 0x00 }; // ตัวอย่าง APDU GET DATA

            var response = ApduHelper.TransmitApduCommand(readerName, apduCommand);

            if (response == null || response.Length < 2) return null;

            // ตัด SW1 SW2 ออก
            byte[] data = new byte[response.Length - 2];
            Array.Copy(response, 0, data, 0, data.Length);

            var tlvs = ParseTlv(data);
            return tlvs;
        }

        public static (List<CardInfo> cardInfos, string aid, string atr) ReadCardInfo(string readerName, string key, byte[] kcv)
        {
            byte[] atr = GetATR(readerName);
            string hexatr = BitConverter.ToString(atr).Replace("-", " ");


            byte[] apdu  = Utils.HexStringToBytes("00 A4 04 00 09 A0 00 00 01 67 41 30 00 FF"); 
            byte[] apdu2 = Utils.HexStringToBytes("00 A4 04 00 08 A0 00 00 01 51 00 00 00");
            byte[] apdu3 = Utils.HexStringToBytes("80 50 00 00 08 00 00 00 00 00 00 00 00");
            

            byte[] response = ApduHelper.TransmitApduCommand(readerName, apdu);
            byte[] dataOnly = response.Take(response.Length - 2).ToArray();
            string hex = BitConverter.ToString(response).Replace("-", " ");

            byte[] response2 = ApduHelper.TransmitApduCommand(readerName, apdu2);
            string hex2 = BitConverter.ToString(response2).Replace("-", " ");

            byte[] response3 = ApduHelper.TransmitApduCommand(readerName, apdu3);
            string hex3 = BitConverter.ToString(response3).Replace("-", " ");

            string host_challenge = "0000000000000000";
            string data_auth = Authenticate.Exthernal_Authenticate(hex3, key, "", host_challenge, Authenticate.Mode_Derivation.CPG211);

            byte[] responseAuth = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes(data_auth));
            //string hex4 = BitConverter.ToString(responseAuth).Replace("-", " ");

            byte[] response_AID = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 80 00 02 4F 00"));
            string aid = BitConverter.ToString(response_AID).Replace("-", " ");

            byte[] response_Applications = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 40 00 02 4F 00"));
            //string application = BitConverter.ToString(response_Applications).Replace("-", " ");

            byte[] response_CardInfo = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 10 00 02 4F 00"));
            string cardInfo = BitConverter.ToString(response_CardInfo).Replace("-", " ");

            byte[] response7 = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 10 01 02 4F 00"));
            //string hex8 = BitConverter.ToString(response7).Replace("-", " ");


            var cardInfos = ParseCardInfo(cardInfo);


            return (cardInfos, aid, hexatr);
        }
        public static byte[] GetATR(string readerName)
        {
            var smartCard = new SmartCardManager();

            IntPtr hContext = smartCard.EstablishContext();
            uint protocol;
            IntPtr hCard = SmartCardManager.PowerOnCard(hContext, readerName, out IntPtr cardHandle);
            if (hCard == IntPtr.Zero)
                return null;

            var atr = SmartCardManager.GetCardATR(hCard);
            return atr;

        }

    }

}
