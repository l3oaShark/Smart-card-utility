using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Public_key_certification_processing
{
    public class PublicKeyProcessor
    {
        static string AsciiToHex(string ascii)
        {
            StringBuilder hex = new StringBuilder();
            foreach (char c in ascii)
            {
                hex.AppendFormat("{0:X2}", (int)c);
            }
            return hex.ToString();
        }

        public static Properties_publickey LoadFromEncryptedTextFile(string filePath, bool isEncrypted, RSAParameters? rsaPublicKey = null)
        {
             //filePath = @"D:\Area_Working\c#\smart_card_utility\doc\Sample_ToSVC\GSB VISA BIN 4344315 Debit\TBCC\1 IPK\GSB_434463_TBCC_P71_266505_1976_09_2032_TEST.pki";
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            string text;

            if (isEncrypted)
            {
                if (rsaPublicKey == null)
                    throw new ArgumentNullException(nameof(rsaPublicKey), "Public key is required for decryption.");
                
                string asciiText = File.ReadAllText(filePath, Encoding.UTF8);
                string hexText = AsciiToHex(asciiText);

                string modulusHex = @"a60d84db4565ae93679681bf19477bad0a4094cb5eb4cc6630860856c2a8d89f4ce2148bfd0d41d2
3e8b74f98a28eaaed182bd3e732b3cff5e0260b52d7475bf60fd39bf08ae0f0c23dd43fb2a29338b
8533dcb2f975e9c00951c7e240bbfffbb60f52476e2a5f6816162451a7141a8a6a1f7719f2829edd
2e8098f09ce253c0a297cd2a9caf891e758edb02708bfdf89cf356d24816bc2cf260b1487fa789d9
d4a5c6e347e03b5abfb059600792392801879f29037fa421ecf448855190a6e3f9d37fc766d9c71b
d0680ef0dbc1dac3f768ac74a955d33a2b9f8819af0232890ed9a57e02c68377f38c9ed2a8344999
65c4035e86c51b";

                string exponentHex = "03";
                string decryptedMessageHex = @"7E075639CF0A0F3184D784B3E766898ED2479C5519CF9B81A330590826A80C48669B9561C9628FCD13CB598407C8A2AC9E3964DFC0F53A02488704CAA334D68075D51CEE5668362936AAEC5A2EF321F4B509314D5EA60F3C26336BD3F8B388733D94489F4FBD7157DE116C9A0B5E08A99A95A22DEC2F49B63D124A830452B80DCCC2FFFADD32CBA9204CAEF1ACCE7729209C15592C31FC8CE4A19DEDC69C161B55A12F14BC5224C93089C2A6D1756AE85BACCC8245424EB3068F85C2C675CF0A9574AF594DEA118D5A113BA374A2F3D0F59D85E515D77F1EBAE9508FFE3CFE42D75E73F014A32FF0859CB4AD2926840E758579A0B9D60D";



                byte[] encryptedData = File.ReadAllBytes(filePath);
                text = VerifySignatureRSA(modulusHex, exponentHex, decryptedMessageHex);
                //text = DecryptData(encryptedData, rsaPublicKey.Value);
            }
            else
            {
                text = File.ReadAllText(filePath, Encoding.UTF8);
            }

            var dict = ParseTextToDictionary(text);
            return MapToPropertiesPublicKey(dict);
        }

        public static string VerifySignatureRSA(string modulusHex, string exponentHex, string signatureHex)
        {

            modulusHex = modulusHex.Replace("\n", "").Replace("\r", "").Replace(" ", "");

            BigInteger n = BigInteger.Parse("00" + modulusHex, System.Globalization.NumberStyles.HexNumber);
            BigInteger e = BigInteger.Parse(exponentHex, System.Globalization.NumberStyles.HexNumber);
            BigInteger signature = BigInteger.Parse(signatureHex, System.Globalization.NumberStyles.HexNumber);

            BigInteger decryptedHash = BigInteger.ModPow(signature, e, n);

            string decryptedHashHex = decryptedHash.ToString("X");
            decryptedHashHex = decryptedHashHex.PadLeft(signatureHex.Length, '0');

            return decryptedHashHex.ToUpper();
        }


        private static Dictionary<string, string> ParseTextToDictionary(string text)
        {
            var dict = new Dictionary<string, string>();
            var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ':' }, 2);
                if (parts.Length == 2)
                {
                    dict[parts[0].Trim()] = parts[1].Trim();
                }
            }
            return dict;
        }
        private static Properties_publickey MapToPropertiesPublicKey(Dictionary<string, string> dict)
        {
            var prop = new Properties_publickey();

            var props = typeof(Properties_publickey).GetProperties();
            foreach (var p in props)
            {
                if (!p.CanWrite) continue;
                if (dict.TryGetValue(p.Name, out string value))
                {
                    p.SetValue(prop, value);
                }
            }

            return prop;
        }

    }
    public class Properties_publickey
    {
        //Unsigned Pulic Key Input Extension
        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Recording Head")]
        [Description("The given name of the person.")]
        public string Unsigned_Recording_Head { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issue Public Key Length")]
        [Description("The family name of the person.")]
        public string Issue_Public_Key_Length { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issue Public Key Modulus.")]
        [Description("Issue Public Key Modulus.")]
        public string Issue_Public_Key_Modulus { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issue Public Key Exponent Length.")]
        [Description("Issue Public Key Exponent Length.")]
        public string Issue_Public_Key_Exponent_Length { get; set; }
        //public bool Unsigned_Pulic_Key_Input_Extension { get; set; } = true; 

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issue Public Key Exponent.")]
        [Description("Issue Public Key Exponent.")]
        public string Issue_Public_Key_Exponent { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issue Public Key Algorithum Indicator.")]
        [Description("Issue Public Key Algorithum Indicator.")]
        public string Issue_Public_Key_Algorithum_Indicator { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Certificate Serial Number.")]
        [Description("Certificate Serial Number.")]
        public string Unsigned_Certificate_Serial_Number { get; set; }


        //Self-signed Public Key Data
        [Category("Self-signed Public Key Data")]
        [DisplayName("Readcording Head.")]
        [Description("Readcording Head.")]
        public string Self_signed_Recording_head { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Service Identifier.")]
        [Description("Service Identifier.")]
        public string Service_Identifier { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Certificate Format.")]
        [Description("Certificate Format.")]
        public string Certificate_Format { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("BIN.")]
        [Description("BIN.")]
        public string BIN { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Certificate Expiration Date.")]
        [Description("Certificate Expiration Date.")]
        public string Certificate_Expiration_Date { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Certificate Serial Number.")]
        [Description("Certificate Serial Number.")]
        public string Self_signed_Certificate_Serial_Number { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Hash Algorithim Indicator.")]
        [Description("Hash Algorithim Indicator.")]
        public string Hash_Algorithim_Indicator { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Algorithm Indicator.")]
        [Description("Issuer Public Key Algorithm Indicator.")]
        public string Issuer_Public_Key_Algorithm_Indicator { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Length.")]
        [Description("Issuer Public Key Length.")]
        public string Issuer_Public_Key_Length { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Exponent Length.")]
        [Description("Issuer Public Key Exponent Length.")]
        public string Issuer_Public_Key_Exponent_Length { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Leftmost Digis of the Issuer Public Key.")]
        [Description("Leftmost Digis of the Issuer Public Key.")]
        public string Leftmost_Digis_of_the_Issuer_Public_Key { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Exponent.")]
        [Description("Issuer Public Key Exponent.")]
        public string Issuer_Public_Key_Exponent { get; set; }

        [Browsable(false)] // ซ่อน Property นี้จาก PropertyGrid
        public string HiddenProperty { get; set; }
    }
}
