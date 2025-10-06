using Encryptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using static SmartCard.Authenticate;
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

        /// <summary>
        /// อ่านข้อมูล card info แบบรวมในรูปแบบ TLV (ส่ง APDU command ที่ card กำหนด)
        /// </summary>

        public static (List<CardInfo> cardInfos, List<CPLC> cplc, List<Applications> apps, string aid, string atr) ReadCardInfo(string readerName, string key, byte[] kcv)
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

            string statusAuth = Authenticate.Auto_Authenticate(readerName, key).Replace(" ","");
            if (statusAuth != "9000")
            {
                throw new Exception("Authentication failed");
            }
            byte[] response_ISD = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 80 00 02 4F 00"));
            string isd = BitConverter.ToString(response_ISD).Replace("-", "");
            isd = isd.Substring(2, Convert.ToInt32(isd.Substring(0, 2)) * 2);


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

        public static List<string> UpdateCMKey_TripleKeySCP02(string readerName, Mode_ActionKey mode, string isd, string oldCMK, string newKEnc, string newKMac, string newKDEK)
        {
            string action = mode == Mode_ActionKey.CreateKey ? "00" : "01";
            List<string> result = new List<string>();

            byte[] atr = SmartCardInfo.GetATR(readerName);
            result.Add("ATR: " + BitConverter.ToString(atr).Replace("-", " "));
            result.Add("Card Manager: " + isd);

            // 1. SELECT ISD
            string ISD = BitConverter.ToString( ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("00 A4 04 00 08 " + isd))).Replace("-", "").Replace(" ", "");

            // 2. Host Challenge (สุ่ม 8 byte)
            string hostChallenge = GenerateHostChallenge();
            var response = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 50 00 00 08 " + hostChallenge));
            string res = BitConverter.ToString(response).Replace("-", "").Replace(" ", "");
            if (response.Length < 30 ||
                response[response.Length - 2] != 0x90 ||
                response[response.Length - 1] != 0x00)
            {
                result.Add("❌ INITIALIZE UPDATE failed");
                return result;
            }
            result.Add($"INITIALIZE : {res}");

            //res = "00001239036635201623030200299F562F8233689EB55D9386B34FFC";// for testing
            //----- Defind variable
            string Last2BAID = res.Substring(0, 2*2); // C0:2 = Last 2 byte AID 
            string CSN = res.Substring((5-1)*2, 4*2);         // C5:4 = CSN 
            string ICBatchIdentifier = res.Substring((9-1)*2, 2*2); // C9:2 = IC Batch Identifier 
            string Counter = res.Substring((13-1)*2, 2*2); // C13:2 = Counter  
            string CardChallenge = res.Substring((15-1)*2, 6*2); // C15:6 = Card Challenge 
            string CardCrypogramExp = res.Substring((21-1)*2, 8*2); // C21:8 = Card Cryptogram 

            string KEnc = DesHelper.Encrypt(oldCMK, CSN + ICBatchIdentifier + "F001" + CSN + ICBatchIdentifier + "0F01", Utils.CryptoMode.ECB, null);
            string KMac = DesHelper.Encrypt(oldCMK, CSN + ICBatchIdentifier + "F002" + CSN + ICBatchIdentifier + "0F02", Utils.CryptoMode.ECB, null);
            string KDek = DesHelper.Encrypt(oldCMK, CSN + ICBatchIdentifier + "F003" + CSN + ICBatchIdentifier + "0F03", Utils.CryptoMode.ECB, null);

            string SkuEnc = DesHelper.Encrypt(KEnc, "0182" + Counter + "000000000000000000000000", Utils.CryptoMode.CBC, "0000000000000000"); //16 bytes
            string SkuMac = DesHelper.Encrypt(KMac, "0101" + Counter + "000000000000000000000000", Utils.CryptoMode.CBC, "0000000000000000"); //16 bytes
            string SkuDek = DesHelper.Encrypt(KDek, "0181" + Counter + "000000000000000000000000", Utils.CryptoMode.CBC, "0000000000000000"); //16 bytes

            //----- Host cryptogram calculation 
            string HostCrypogramTemp =DesHelper.Encrypt(SkuEnc, Counter + CardChallenge + hostChallenge + "8000000000000000", Utils.CryptoMode.CBC, "0000000000000000");
            string HostCrypogram = HostCrypogramTemp.Substring((17-1)*2, 8*2); // C17:8 = HostCrypogram

            //----- CMAC calculation
            string output1 = DesHelper.Encrypt(SkuMac.Substring(0, 8 * 2), "8482000010" + HostCrypogram + "800000", Utils.CryptoMode.CBC, "0000000000000000");
            string input2 = DesHelper.Decrypt(SkuMac.Substring((9-1) * 2, 8 * 2), output1.Substring((9-1)*2, 8 * 2), Utils.CryptoMode.CBC, "0000000000000000");
            string CMAC = DesHelper.Encrypt(SkuMac.Substring(0, 8 * 2), input2, Utils.CryptoMode.CBC, "0000000000000000");

            string ExtAuthDat = HostCrypogram + CMAC;


            //----- Card cryptogram calculation
            string CardCrypogramCal = DesHelper.Encrypt(SkuEnc, hostChallenge + Counter + CardChallenge + "8000000000000000", Utils.CryptoMode.CBC, "0000000000000000");

            //**** Card cryptogram comparison ****//
            string CardCrypogramCalR8 = CardCrypogramCal.Substring(CardCrypogramCal.Length - (8*2), 8*2);
            if (!CardCrypogramCalR8.SequenceEqual(CardCrypogramExp))
            {
                result.Add($"❌ CardCryptogram mismatch!\nCalculated (R8): {(CardCrypogramCalR8).Replace("-", "")}\nExpected  (Exp): {(CardCrypogramExp).Replace("-", "")}");
                return result;
            }
            //var CardCrypogramCmp = SmartCardManager.CalculateCardCryptogram(Utils.HexStringToBytes(hostChallenge), Utils.HexStringToBytes( CardChallenge), Utils.HexStringToBytes(Counter), Utils.HexStringToBytes(SkuMac));

            //----- Ext-auth
            byte[] responseAuth = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("84 82 00 00 10" + ExtAuthDat));
            string authHex = BitConverter.ToString(responseAuth).Replace("-", " ").Replace(" ", "");
            if (responseAuth.Length < 2 ||
                responseAuth[responseAuth.Length - 2] != 0x90 ||
                responseAuth[responseAuth.Length - 1] != 0x00)
            {
                result.Add("❌ EXTERNAL AUTHENTICATE failed");
                return result;
            }
            result.Add($"EXTERNAL AUTHENTICATE : {authHex}");
            //----- Session key creation
            string KEnc2 = DesHelper.Encrypt(newKEnc, CSN + ICBatchIdentifier + "F001" + CSN + ICBatchIdentifier + "0F01", Utils.CryptoMode.ECB, null); // 16 bytes
            string KMac2 = DesHelper.Encrypt(newKMac, CSN + ICBatchIdentifier + "F002" + CSN + ICBatchIdentifier + "0F02", Utils.CryptoMode.ECB, null); // 16 bytes
            string KDek2 = DesHelper.Encrypt(newKDEK, CSN + ICBatchIdentifier + "F003" + CSN + ICBatchIdentifier + "0F03", Utils.CryptoMode.ECB, null); // 16 bytes

            string KEnc2KCV = DesHelper.Encrypt(KEnc2, "0000000000000000", Utils.CryptoMode.ECB, null); //16 bytes
            string KMac2KCV = DesHelper.Encrypt(KMac2, "0000000000000000", Utils.CryptoMode.ECB, null); //16 bytes
            string KDek2KCV = DesHelper.Encrypt(KDek2, "0000000000000000", Utils.CryptoMode.ECB, null); //16 bytes

            string CDKEnc = DesHelper.Encrypt(SkuDek, KEnc2, Utils.CryptoMode.ECB, null); // 16 bytes
            string CDKMac = DesHelper.Encrypt(SkuDek, KMac2, Utils.CryptoMode.ECB, null); // 16 bytes
            string CDKDek = DesHelper.Encrypt(SkuDek, KDek2, Utils.CryptoMode.ECB, null); // 16 bytes

            string PutKeySetDat = "8010" + CDKEnc + "03" + KEnc2KCV.Substring(0, 3 * 2) + "8010" + CDKMac + "03" + KMac2KCV.Substring(0, 3 * 2) + "8010" + CDKDek + "03" + KDek2KCV.Substring(0, 3 * 2); //16 bytes


            //----- Put-key set
            byte[] putkey = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes($"80 D8 {action} 81 43 01" + PutKeySetDat)); // 66 bytes
            string putkeyHex = BitConverter.ToString(putkey).Replace("-", "").Replace(" ", "");

            if (putkey.Length < 2 ||
                putkey[putkey.Length - 2] != 0x90 ||
                putkey[putkey.Length - 1] != 0x00)
            {
                result.Add($"❌ PUT KEY failed: SW = {putkeyHex}");
                return result;
            }
            result.Add(mode == Mode_ActionKey.CreateKey ? "Crate key" : "Update key"+ $" : {putkeyHex}");

            return result;
        }
        
        public static string GenerateHostChallenge()
        {
            byte[] rand = new byte[8];
            using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(rand);
            return BitConverter.ToString(rand).Replace("-", "");
        }
    }


}


