using Encryptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Encryptions.Utils;

namespace SmartCard
{
    public class Authenticate
    {
        public enum Mode_Derivation
        {
            None,
            CPG211
        }

        public static string Exthernal_Authenticate(string dataHex, string kmc, string iv, string host_challenge, Mode_Derivation mode)
        {
            dataHex = dataHex.Replace(" ", "").Replace("-", "");
            if (dataHex.Length < (4 + 2 + 2 + 6 + 8) * 2)
            {
                throw new ArgumentException("Data length is too short.");
            }

            string csn = dataHex.Substring(4 * 2, 4 * 2);                      // 4 bytes = 8 hex chars
            string ic_batch_identifier = dataHex.Substring(16, 2 * 2); // 2 bytes = 4 hex chars
            string counter = dataHex.Substring(24, 2 * 2);              // 2 bytes = 4 hex chars
            string card_challenge = dataHex.Substring(28, 6 * 2);       // 6 bytes = 12 hex chars
            string card_cryptogram = dataHex.Substring(40, 8 * 2);     // 8 bytes = 16 hex chars

            string KDCEnc = kmc;
            string KDCMac = kmc;
            string KDCKek = kmc;

            string KSCEnc;
            string KSCMac;
            string KSCKek;

            string ENC_DATA;
            if (mode == Mode_Derivation.None)
            {

            }
            else if (mode == Mode_Derivation.CPG211)
            {
                KDCEnc = DesHelper.Encrypt(kmc, csn + ic_batch_identifier + "F001" + csn + ic_batch_identifier + "0F01", CryptoMode.ECB, iv);
                KDCMac = DesHelper.Encrypt(kmc, csn + ic_batch_identifier + "F002" + csn + ic_batch_identifier + "0F02", CryptoMode.ECB, iv);
                KDCKek = DesHelper.Encrypt(kmc, csn + ic_batch_identifier + "F003" + csn + ic_batch_identifier + "0F03", CryptoMode.ECB, iv);
            }
            KSCEnc = DesHelper.Encrypt(KDCEnc, "0182" + counter + "000000000000000000000000", CryptoMode.CBC, "0000000000000000"); 
            KSCMac = DesHelper.Encrypt(KDCMac, "0101" + counter + "000000000000000000000000", CryptoMode.CBC, "0000000000000000"); 
            KSCKek = DesHelper.Encrypt(KDCKek, "0181" + counter + "000000000000000000000000", CryptoMode.CBC, "0000000000000000"); 

            ENC_DATA = DesHelper.Encrypt(KSCEnc, counter + card_challenge + host_challenge + "8000000000000000", CryptoMode.CBC, "0000000000000000");
            string host_cryptogram = ENC_DATA.Substring(ENC_DATA.Length-(8*2),8*2);

            string enc_data_out = DesHelper.Encrypt(KSCMac.Substring(0, 8 * 2), "8482000010" + host_cryptogram + "800000", CryptoMode.CBC, "0000000000000000");

            string enc_data_in = DesHelper.Decrypt(KSCMac.Substring(KSCMac.Length - (8 * 2), 8 * 2), enc_data_out.Substring(enc_data_out.Length - (8 * 2), 8 * 2), CryptoMode.CBC, "0000000000000000");
            string CMAC = DesHelper.Encrypt(KSCMac.Substring(0, 8 * 2), enc_data_in, CryptoMode.CBC, "0000000000000000");

            string exthernal_data = host_cryptogram + CMAC;

            return ("8482000010" + exthernal_data);
        }

        public static string Auto_Authenticate(string readerName, string key)
        {
            byte[] apdu = Utils.HexStringToBytes("00 A4 04 00 09 A0 00 00 01 67 41 30 00 FF");
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

            byte[] response_ISD = ApduHelper.TransmitApduCommand(readerName, Utils.HexStringToBytes("80 F2 80 00 02 4F 00"));
            string sid = BitConverter.ToString(response_ISD).Replace("-", "");
            sid = sid.Substring(2, Convert.ToInt32(sid.Substring(0, 2)) * 2);


            return sid;
        }

    }
}
