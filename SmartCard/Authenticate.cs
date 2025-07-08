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

        public static bool AuthenticateCard(string readerName, byte[] key, byte[] kcv)
        {
            // ตัวอย่าง APDU Authenticate (ต้องเปลี่ยนตาม protocol ของ card)
            // สมมติใช้ INS=0x82, P1=0x00, P2=0x00, Lc=key.Length + kcv.Length, data=key + kcv
            List<byte> apdu = new List<byte>();
            apdu.Add(0x00); // CLA
            apdu.Add(0x82); // INS Authenticate (ตัวอย่าง)
            apdu.Add(0x00); // P1
            apdu.Add(0x00); // P2
            apdu.Add((byte)(key.Length + kcv.Length)); // Lc
            apdu.AddRange(key);
            apdu.AddRange(kcv);
            apdu.Add(0x00); // Le

            var response = ApduHelper.TransmitApduCommand(readerName, apdu.ToArray());

            if (response == null || response.Length < 2) return false;

            // Check SW1 SW2 == 0x90 0x00 for success
            int len = response.Length;
            return (response[len - 2] == 0x90 && response[len - 1] == 0x00);
        }

    }
}
