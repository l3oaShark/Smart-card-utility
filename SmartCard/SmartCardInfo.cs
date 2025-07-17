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

        public static (List<CardInfo> cardInfos,List<CPLC>cplc,List<Applications>apps ,string aid, string atr) ReadCardInfo(string readerName, string key, byte[] kcv)
        {
            byte[] atr = GetATR(readerName);
            string hexatr = BitConverter.ToString(atr).Replace("-", " ");


            //byte[] apdu  = Utils.HexStringToBytes("00 A4 04 00 09 A0 00 00 01 67 41 30 00 FF"); 
            //byte[] apdu2 = Utils.HexStringToBytes("00 A4 04 00 08 A0 00 00 01 51 00 00 00");
            //byte[] apdu3 = Utils.HexStringToBytes("80 50 00 00 08 00 00 00 00 00 00 00 00");

            //byte[] response = ApduHelper.TransmitApduCommand(readerName, apdu);
            //byte[] dataOnly = response.Take(response.Length - 2).ToArray();
            //string hex = BitConverter.ToString(response).Replace("-", " ");

            //byte[] response2 = ApduHelper.TransmitApduCommand(readerName, apdu2);
            //string hex2 = BitConverter.ToString(response2).Replace("-", " ");

            //byte[] response3 = ApduHelper.TransmitApduCommand(readerName, apdu3);
            //string hex3 = BitConverter.ToString(response3).Replace("-", " ");

            //string host_challenge = "0000000000000000";
            //string data_auth = Authenticate.Exthernal_Authenticate(hex3, key, "", host_challenge, Authenticate.Mode_Derivation.CPG211);

            //byte[] responseAuth = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes(data_auth));
            ////string hex4 = BitConverter.ToString(responseAuth).Replace("-", " ");
            ///
            //byte[] response_ISD = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 80 00 02 4F 00"));
            //string isd = BitConverter.ToString(response_ISD).Replace("-", "");

            string isd = Authenticate.Auto_Authenticate(readerName, key);

                                                                                                              
            byte[] response_Applications = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 40 00 02 4F 00"));
            string application = BitConverter.ToString(response_Applications).Replace("-", " ");
            var apps = ParseApplications(application);


            byte[] response_CardInfo = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 10 00 02 4F 00"));
            string cardInfo = BitConverter.ToString(response_CardInfo).Replace("-", " ");

            byte[] response7 = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 10 01 02 4F 00"));
            //string hex8 = BitConverter.ToString(response7).Replace("-", " ");

            var cardInfos = ParseCardInfo(cardInfo);



            //string hex_aid = BitConverter.ToString(apdu_aid).Replace("-", " ");
            //byte[] apdu_aid = Utils.HexStringToBytes("00 A4 04 00 08 A0 00 00 00 03 00 00 00");

            //byte[] responseid = ApduHelper.TransmitApduCommand(readerName, apdu_aid);
            //string hex_resaid = BitConverter.ToString(responseid).Replace("-", " ");

            byte[] apdu_cplc = Utils.HexStringToBytes("80 CA 9F 7F 00");
            string hex_acplc = BitConverter.ToString(apdu_cplc).Replace("-", " ");


            byte[] response_cplc = ApduHelper.TransmitApduCommand(readerName, apdu_cplc);

            if (response_cplc.Length == 2 && response_cplc[0] == 0x6C)
            {
                byte correctLength = response_cplc[1]; // SW2 = correct Le
                byte[] apdu_cplc_correct = Utils.HexStringToBytes("80CA9F7F" + correctLength.ToString("X2"));
                response_cplc = ApduHelper.TransmitApduCommand(readerName, apdu_cplc_correct);
            }
            string hex_cplc = BitConverter.ToString(response_cplc).Replace("-", " ");
            var cplc_info = ParseCPLC(hex_cplc);


            return (cardInfos, cplc_info, apps, isd, hexatr);
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
