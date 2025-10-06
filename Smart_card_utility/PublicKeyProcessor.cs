using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;

namespace Public_key_certification_processing
{
    public class PublicKeyProcessor
    {
        public static Properties_Files LoadFromTextFileSmartCPSv1Pki(string cpsV1filePki)
        {
            if (!File.Exists(cpsV1filePki))
                throw new FileNotFoundException("File not found.", cpsV1filePki);

            string text = File.ReadAllText(cpsV1filePki, Encoding.UTF8);

            var dict = ParseTextCPSv1ToDictionary(text);

            var displayNameToRawKey = new Dictionary<string, string>
            {
                { "Encrypted Key Modulus", "RSA_MODULUS_plain" },
                { "Encrypted Key Exponent", "RSA_PUBLICEXP_plain" },
                { "RSA_PRIVATEEXP_enc", "RSA_PRIVATEEXP_enc" },
                { "RSA_P_enc", "RSA_P_enc" },
                { "RSA_Q_enc", "RSA_Q_enc" },
                { "RSA_DP_enc", "RSA_DP_enc" },
                { "RSA_DQ_enc", "RSA_DQ_enc" },
                { "RSA_Q_INV_enc", "RSA_Q_INV_enc" },
                { "Encrypted Key Check Value", "KeyCheckValue" },
                { "ChainingMode", "ChainingMode" },
                { "PadMode", "PadMode" },
                { "Issue Public Key Length", "KeyLength" },
                { "KeyCheckValue_KEK", "KeyCheckValue_KEK" },

            };

            var inputForMapping = displayNameToRawKey
                .Where(kvp => dict.ContainsKey(kvp.Value))
                .ToDictionary(kvp => kvp.Key, kvp => dict[kvp.Value]);

            string ipkLength = string.Empty;

            inputForMapping.TryGetValue("Issue Public Key Length", out ipkLength);

            if (!string.IsNullOrEmpty(ipkLength)  && int.TryParse(ipkLength, out int ipkLengthInt))
            {
                inputForMapping["Issue Public Key Length"] = (ipkLengthInt).ToString();
            }

            return MapCPSv1PKIFilesToProperties(inputForMapping);
        }

        public static Properties_Files MapCPSv1PKIFilesToProperties(Dictionary<string, string> dict)
        {
            var prop = new Properties_Files();

            var props = typeof(Properties_Files).GetProperties();
            foreach (var p in props)
            {
                if (!p.CanWrite) continue;

                var displayNameAttr = p.GetCustomAttributes(typeof(DisplayNameAttribute), false)
                                       .FirstOrDefault() as DisplayNameAttribute;

                if (displayNameAttr == null) continue;

                string displayName = displayNameAttr.DisplayName;

                if (dict.TryGetValue(displayName, out string value))
                {
                    p.SetValue(prop, value);
                }
            }

            return prop;
        }

        public static Properties_Files LoadFromTextFileNBSPki(string filePki)
        {

            if (!File.Exists(filePki))
                throw new FileNotFoundException("File not found.", filePki);

            string text = File.ReadAllText(filePki, Encoding.UTF8);

            var dict = ParseTextNBSToDictionary(text);

            return MapNBSPKIFilesToProperties(dict);
        }


        public static Properties_Files LoadFromTextFileINP(string fileINP)
        {
            if (!File.Exists(fileINP))
                throw new FileNotFoundException("File not found.", fileINP);
            byte[] fileBytes = File.ReadAllBytes(fileINP);
            string l = fileBytes.Length.ToString();

            StringBuilder text2 = new StringBuilder(fileBytes.Length * 2);
            foreach (byte b in fileBytes)
            {
                text2.AppendFormat("{0:X2}", b);  // X2 = uppercase, x2 = lowercase
            }

            string header = text2.ToString().Substring(0, 2);
            
            if (header == "22")
            {
              var prop =  visa.Header22(text2.ToString());

              return prop;
            }
            else if (header == "23")
            {
                var prop = visa.Header23(text2.ToString());

                return prop;
            }
            else if (header == "24")
            {
                var prop = visa.Header24(text2.ToString());

                return prop;
            }
            else if (header == "6A")
            {
                var prop = visa.Header6A(text2.ToString());

                return prop;
            }
            else if (header == "20")
            {
                var prop = visa.Header20(text2.ToString());

                return prop;
            }
            else if (header == "21")
            {
                var prop = visa.Header21(text2.ToString());

                return prop;
            }
            else
            {
                //var prop = visa.MapINPFilesToProperties(text2.ToString());
                //return prop;
                throw new Exception("haeder not macth or file type is not collect.");
            }   
            
        }

        private static Dictionary<string, string> ParseTextNBSToDictionary(string text)
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

            string keysize = string.Empty;
            string ipkLength = string.Empty;

            dict.TryGetValue("Issue Public Key Length", out ipkLength);
            dict.TryGetValue("Encrypted Key Size", out keysize);

            if (string.IsNullOrEmpty(ipkLength) && !string.IsNullOrEmpty(keysize) && int.TryParse(keysize, out int keysizeInt))
            {
                dict["Issue Public Key Length"] = keysizeInt.ToString();
            }
            else if (!string.IsNullOrEmpty(ipkLength) && string.IsNullOrEmpty(keysize) && int.TryParse(ipkLength, out int ipkLengthInt))
            {
                dict["Encrypted Key Size"] = (ipkLengthInt).ToString();
            }

            return dict;
        }
        private static Dictionary<string, string> ParseTextCPSv1ToDictionary(string text)
        {
            var dict = new Dictionary<string, string>();
            var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { '=' }, 2);
                if (parts.Length == 2)
                {
                    dict[parts[0].Trim()] = parts[1].Trim();
                }
            }
            return dict;
        }
        private static Properties_Files MapNBSPKIFilesToProperties(Dictionary<string, string> dict)
        {
            var prop = new Properties_Files();

            var props = typeof(Properties_Files).GetProperties();
            foreach (var p in props)
            {
                if (!p.CanWrite) continue;

                var displayNameAttr = p.GetCustomAttributes(typeof(DisplayNameAttribute), false)
                                       .FirstOrDefault() as DisplayNameAttribute;

                if (displayNameAttr == null) continue;

                string displayName = displayNameAttr.DisplayName;

                if (dict.TryGetValue(displayName, out string value))
                {
                    p.SetValue(prop, value);
                }
            }

            return prop;
        }


        public static CompareResult CompareObjects(object obj1, object obj2)
        {
            var result = new CompareResult();

            var props1 = obj1.GetType().GetProperties();
            var props2 = obj2.GetType().GetProperties();

            foreach (var prop1 in props1)
            {
                var displayNameAttr = prop1.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                           .FirstOrDefault() as DescriptionAttribute;
                if (displayNameAttr == null) continue;

                string displayName = displayNameAttr.Description;
                string value1 = prop1.GetValue(obj1)?.ToString() ?? "";

                // หา property ที่มี DisplayName ตรงกันใน obj2
                var matchingProp = props2.FirstOrDefault(p =>
                {
                    var dn = p.GetCustomAttributes(typeof(DescriptionAttribute), false)
                              .FirstOrDefault() as DescriptionAttribute;
                    return dn != null && dn.Description == displayName;
                });

                if (matchingProp != null)
                {
                    string value2 = matchingProp.GetValue(obj2)?.ToString() ?? "";

                    if (value1 == value2)
                        result.Matched.Add((displayName, value1));
                    else
                        result.Unmatched.Add((displayName, value1, value2));
                }
            }

            return result;
        }

        public List<NBSCompareResults> NBSComparePkiInp(Properties_Files pki, Properties_Files inp)
        {
            var results = new List<NBSCompareResults>();

            void AddResult(string key, string pkiValue, string inpValue)
            {
                string status;

                if (!string.IsNullOrEmpty(pkiValue) && !string.IsNullOrEmpty(inpValue))
                    status = pkiValue == inpValue ? "Matched" : "Unmatched";
                else if (!string.IsNullOrEmpty(pkiValue))
                    status = "Only pki";
                else if (!string.IsNullOrEmpty(inpValue))
                    status = "Only inp";
                else
                    status = "-";

                results.Add(new NBSCompareResults
                {
                    Properties = key,
                    File_IPK = pkiValue,
                    File_INP = inpValue,
                    Status = status
                });
            }

            AddResult("Unsigned_Recording_Head", pki?.Unsigned_Recording_Head, inp?.Unsigned_Recording_Head);
            AddResult("Key_Value", pki?.Key_Value, inp?.Key_Value);
        
            AddResult("Issue_Public_Key_Length", pki?.Issue_Public_Key_Length, inp?.Issue_Public_Key_Length);
            AddResult("Issuer_Public_Key_Modulus", pki?.Issuer_Public_Key_Modulus, inp?.Issuer_Public_Key_Modulus);
            AddResult("Issuer_Public_Key_Exponent_Length", pki?.Issuer_Public_Key_Exponent_Length, inp?.Issuer_Public_Key_Exponent_Length);
            AddResult("Issuer_Public_Key_Exponent", pki?.Issuer_Public_Key_Exponent, inp?.Issuer_Public_Key_Exponent);
            AddResult("Issuer_Public_Key_check", pki?.Issuer_Public_Key_check, inp?.Issuer_Public_Key_check);
            AddResult("Issuer_Public_Key_Algorithum_Identifier", pki?.Issuer_Public_Key_Algorithum_Identifier, inp?.Issuer_Public_Key_Algorithum_Identifier);
            AddResult("Issuer_Public_Key_Algorithum_Indicator", pki?.Issuer_Public_Key_Algorithum_Indicator, inp?.Issuer_Public_Key_Algorithum_Indicator);
            AddResult("Transport_Key", pki?.Transport_Key, inp?.Transport_Key);

            AddResult("Key_Name", pki?.Key_Name, inp?.Key_Name);
            AddResult("Key_Usage", pki?.Key_Usage, inp?.Key_Usage);
            AddResult("Key_Description", pki?.Key_Description, inp?.Key_Description);
            AddResult("Key_Format_Name", pki?.Key_Format_Name, inp?.Key_Format_Name);
            AddResult("Key_Format_ID", pki?.Key_Format_ID, inp?.Key_Format_ID);
            AddResult("Key_Size", pki?.Key_Size, inp?.Key_Size);
            AddResult("Key_Serial_Number", pki?.Key_Serial_Number, inp?.Key_Serial_Number);
            AddResult("Key_Tracking_Number", pki?.Key_Tracking_Number, inp?.Key_Tracking_Number);
            AddResult("Self_signed_Recording_head", pki?.Self_signed_Recording_head, inp?.Self_signed_Recording_head);
            AddResult("Service_Identifier", pki?.Service_Identifier, inp?.Service_Identifier);
            AddResult("Encryption_Key_Name", pki?.Encryption_Key_Name, inp?.Encryption_Key_Name);
            AddResult("Encryption_Key_Version", pki?.Encryption_Key_Version, inp?.Encryption_Key_Version);
            AddResult("Key_Size", pki?.Encryption_Key_Usage, inp?.Encryption_Key_Usage);
            AddResult("Encryption_Key_Description", pki?.Encryption_Key_Description, inp?.Encryption_Key_Description);
            AddResult("Encryption_Key_Type", pki?.Encryption_Key_Type, inp?.Encryption_Key_Type);
            AddResult("Certificate_Format", pki?.Certificate_Format, inp?.Certificate_Format);
            AddResult("BIN", pki?.BIN, inp?.BIN);
            AddResult("Certificate_Expiration_Date", pki?.Certificate_Expiration_Date, inp?.Certificate_Expiration_Date);
            AddResult("Key_SiSelf_signed_Certificate_Serial_Numberze", pki?.Self_signed_Certificate_Serial_Number, inp?.Self_signed_Certificate_Serial_Number);
            AddResult("Hash_Algorithim_Indicator", pki?.Hash_Algorithim_Indicator, inp?.Hash_Algorithim_Indicator);
            AddResult("Issuer_Public_Key_Algorithm_Indicator", pki?.Issuer_Public_Key_Algorithm_Indicator, inp?.Issuer_Public_Key_Algorithm_Indicator);
            AddResult("Self_Issuer_Public_Key_Length", pki?.Self_Issuer_Public_Key_Length, inp?.Self_Issuer_Public_Key_Length);
            AddResult("Self_Issuer_Public_Key_Exponent_Length", pki?.Self_Issuer_Public_Key_Exponent_Length, inp?.Self_Issuer_Public_Key_Exponent_Length);
            AddResult("Leftmost_Digis_of_the_Issuer_Public_Key", pki?.Leftmost_Digis_of_the_Issuer_Public_Key, inp?.Leftmost_Digis_of_the_Issuer_Public_Key);
            AddResult("Self_Issuer_Public_Key_Exponent", pki?.Self_Issuer_Public_Key_Exponent, inp?.Self_Issuer_Public_Key_Exponent);
            return results;
        }

        public List<NBSCompareResults> CPSv1ComparePkiInp(Properties_Files pki, Properties_Files inp)
        {
            var results = new List<NBSCompareResults>();

            void AddResult(string key, string pkiValue, string inpValue)
            {
                string status;

                if (!string.IsNullOrEmpty(pkiValue) && !string.IsNullOrEmpty(inpValue))
                    status = pkiValue == inpValue ? "Matched" : "Unmatched";
                else if (!string.IsNullOrEmpty(pkiValue))
                    status = "Only pki";
                else if (!string.IsNullOrEmpty(inpValue))
                    status = "Only inp";
                else
                    status = "-";

                results.Add(new NBSCompareResults
                {
                    Properties = key,
                    File_IPK = pkiValue,
                    File_INP = inpValue,
                    Status = status
                });
            }

            AddResult("Unsigned_Recording_Head", pki?.Unsigned_Recording_Head, inp?.Unsigned_Recording_Head);
            AddResult("Key_Value", pki?.Key_Value, inp?.Key_Value);
            AddResult("Issue_Public_Key_Length", pki?.Issue_Public_Key_Length, inp?.Issue_Public_Key_Length);
            AddResult("Issuer_Public_Key_Modulus", pki?.Issuer_Public_Key_Modulus, inp?.Issuer_Public_Key_Modulus);
            AddResult("Issuer_Public_Key_Exponent_Length", pki?.Issuer_Public_Key_Exponent_Length, inp?.Issuer_Public_Key_Exponent_Length);
            AddResult("Issuer_Public_Key_Exponent", pki?.Issuer_Public_Key_Exponent, inp?.Issuer_Public_Key_Exponent);
            AddResult("Issuer_Public_Key_check", pki?.Issuer_Public_Key_check, inp?.Issuer_Public_Key_check);
            AddResult("Issuer_Public_Key_Algorithum_Identifier", pki?.Issuer_Public_Key_Algorithum_Identifier, inp?.Issuer_Public_Key_Algorithum_Identifier);
            AddResult("Issuer_Public_Key_Algorithum_Indicator", pki?.Issuer_Public_Key_Algorithum_Indicator, inp?.Issuer_Public_Key_Algorithum_Indicator);
            AddResult("Key_Name", pki?.Key_Name, inp?.Key_Name);
            AddResult("Key_Usage", pki?.Key_Usage, inp?.Key_Usage);
            AddResult("Key_Description", pki?.Key_Description, inp?.Key_Description);
            AddResult("Key_Format_Name", pki?.Key_Format_Name, inp?.Key_Format_Name);
            AddResult("Key_Format_ID", pki?.Key_Format_ID, inp?.Key_Format_ID);
            AddResult("Key_Size", pki?.Key_Size, inp?.Key_Size);
            AddResult("Key_Serial_Number", pki?.Key_Serial_Number, inp?.Key_Serial_Number);
            AddResult("Key_Tracking_Number", pki?.Key_Tracking_Number, inp?.Key_Tracking_Number);
            AddResult("Self_signed_Recording_head", pki?.Self_signed_Recording_head, inp?.Self_signed_Recording_head);
            AddResult("Service_Identifier", pki?.Service_Identifier, inp?.Service_Identifier);
            AddResult("Encryption_Key_Name", pki?.Encryption_Key_Name, inp?.Encryption_Key_Name);
            AddResult("Encryption_Key_Version", pki?.Encryption_Key_Version, inp?.Encryption_Key_Version);
            AddResult("Key_Size", pki?.Encryption_Key_Usage, inp?.Encryption_Key_Usage);
            AddResult("Encryption_Key_Description", pki?.Encryption_Key_Description, inp?.Encryption_Key_Description);
            AddResult("Encryption_Key_Type", pki?.Encryption_Key_Type, inp?.Encryption_Key_Type);
            AddResult("Certificate_Format", pki?.Certificate_Format, inp?.Certificate_Format);
            AddResult("BIN", pki?.BIN, inp?.BIN);
            AddResult("Certificate_Expiration_Date", pki?.Certificate_Expiration_Date, inp?.Certificate_Expiration_Date);
            AddResult("Key_SiSelf_signed_Certificate_Serial_Numberze", pki?.Self_signed_Certificate_Serial_Number, inp?.Self_signed_Certificate_Serial_Number);
            AddResult("Hash_Algorithim_Indicator", pki?.Hash_Algorithim_Indicator, inp?.Hash_Algorithim_Indicator);
            AddResult("Issuer_Public_Key_Algorithm_Indicator", pki?.Issuer_Public_Key_Algorithm_Indicator, inp?.Issuer_Public_Key_Algorithm_Indicator);
            AddResult("Self_Issuer_Public_Key_Length", pki?.Self_Issuer_Public_Key_Length, inp?.Self_Issuer_Public_Key_Length);
            AddResult("Self_Issuer_Public_Key_Exponent_Length", pki?.Self_Issuer_Public_Key_Exponent_Length, inp?.Self_Issuer_Public_Key_Exponent_Length);
            AddResult("Leftmost_Digis_of_the_Issuer_Public_Key", pki?.Leftmost_Digis_of_the_Issuer_Public_Key, inp?.Leftmost_Digis_of_the_Issuer_Public_Key);
            AddResult("Self_Issuer_Public_Key_Exponent", pki?.Self_Issuer_Public_Key_Exponent, inp?.Self_Issuer_Public_Key_Exponent);

            AddResult("RSA_PRIVATEEXP_enc", pki?.RSA_PRIVATEEXP_enc, inp?.RSA_PRIVATEEXP_enc);
            AddResult("RSA_P_enc", pki?.RSA_P_enc, inp?.RSA_P_enc);
            AddResult("RSA_Q_enc", pki?.RSA_Q_enc, inp?.RSA_Q_enc);
            AddResult("RSA_DP_enc", pki?.RSA_DP_enc, inp?.RSA_DP_enc);
            AddResult("RSA_DQ_enc", pki?.RSA_DQ_enc, inp?.RSA_DQ_enc);
            AddResult("RSA_Q_INV_enc", pki?.RSA_Q_INV_enc, inp?.RSA_Q_INV_enc);
            AddResult("ChainingMode", pki?.ChainingMode, inp?.ChainingMode);
            AddResult("PadMode", pki?.PadMode, inp?.PadMode);
            AddResult("KeyCheckValue_KEK", pki?.KeyCheckValue_KEK, inp?.KeyCheckValue_KEK);

            return results;
        }

    }
    public class CompareResult
    {
        public List<(string DisplayName, string Value)> Matched { get; set; } = new List<(string DisplayName, string Value)>();
        public List<(string DisplayName, string Value1, string Value2)> Unmatched { get; set; } = new List<(string DisplayName, string Value1, string Value2)>();

    }

    public class NBSCompareResults
    {
        public string Properties { get; set; }          // ex. Key_Value
        public string File_IPK { get; set; }     // Value from ipk
        public string File_INP { get; set; }     // Value from inp
        public string Status { get; set; }       // match / not match / only pki / only inp
    }

    public class Properties_PKI
    {
        //Unsigned Pulic Key Input Extension
        [Category("Encrypted")]
        [DisplayName("Encrypted Key Value")]
        [Description("Encrypted Key Value.")]
        public string Key_Value { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Transport Key")]
        [Description("Encrypted Key Transport Key")]
        public string Transport_Key { get; set; }

        [Category("Encrypted")]
        [DisplayName("Issue Public Key Length")]
        [Description("Issue Public Key Length")]
        public string Issue_Public_Key_Length { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Modulus")]
        [Description("Public Key Modulus")]
        public string Issue_Public_Key_Modulus { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Exponent")]
        [Description("Public Key Exponent")]
        public string Issue_Public_Key_Exponent_Length { get; set; }
        //public bool Unsigned_Pulic_Key_Input_Extension { get; set; } = true; 

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Check Value")]
        [Description("Encrypted Key Check Value.")]
        public string Issue_Public_Key_Exponent { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Method")]
        [Description("Encrypted Key Method.")]
        public string Issue_Public_Key_Algorithum_Indicator { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Name")]
        [Description("Encrypted Key Name.")]
        public string Key_Name { get; set; }


        //Self-signed Public Key Data
        [Category("Encrypted")]
        [DisplayName("Encrypted Key Usage")]
        [Description("Encrypted Key Usage.")]
        public string Key_Usage { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Description")]
        [Description("Encrypted Key Description.")]
        public string Key_Description { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Format Name")]
        [Description("Encrypted Key Format Name.")]
        public string Key_Format_Name { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Format ID")]
        [Description("Encrypted Key Format ID.")]
        public string Key_Format_ID { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Size")]
        [Description("Encrypted Key Size.")]
        public string Key_Size { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Serial Number")]
        [Description("Encrypted Key Serial Number.")]
        public string Key_Serial_Number { get; set; }

        [Category("Encrypted")]
        [DisplayName("Encrypted Key Tracking Number")]
        [Description("Encrypted Key Tracking Number.")]
        public string Key_Tracking_Number { get; set; }

        [Category("Encryption")]
        [DisplayName("Encryption Key Name")]
        [Description("Encryption Key Name.")]
        public string Encryption_Key_Name { get; set; }

        [Category("Encryption")]
        [DisplayName("Encryption Key Version")]
        [Description("Encryption Key Version.")]
        public string Encryption_Key_Version { get; set; }

        [Category("Encryption")]
        [DisplayName("Encryption Key Usage")]
        [Description("Encryption Key Usage.")]
        public string Encryption_Key_Usage { get; set; }

        [Category("Encryption")]
        [DisplayName("Encryption Key Description")]
        [Description("Encryption Key Description.")]
        public string Encryption_Key_Description { get; set; }

        [Category("Encryption")]
        [DisplayName("Encryption Key Type")]
        [Description("Encryption Key Type.")]
        public string Encryption_Key_Type { get; set; }

        [Category("Encryption")]
        [DisplayName("Status")]
        [Description("Status")]
        public string Status { get; set; } // "Same", "Different", "OnlyInFile1", "OnlyInFile2"

        [Browsable(false)] // ซ่อน Property นี้จาก PropertyGrid
        public string HiddenProperty { get; set; }

    }

    public class Properties_inp
    {
        //Unsigned Pulic Key Input Extension
        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Recording Head")]
        [Description("Recording Head")]
        public string Unsigned_Recording_Head { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issue Public Key Length")]
        [Description("Issue Public Key Length")]
        public string Issuer_Public_Key_Length { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issuer Public Key Modulus")]
        [Description("Public Key Modulus")]
        public string Issuer_Public_Key_Modulus { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issuer Public Key Exponent Length")]
        [Description("Issuer Public Key Exponent Length.")]
        public string Issuer_Public_Key_Exponent_Length { get; set; }
        //public bool Unsigned_Pulic_Key_Input_Extension { get; set; } = true; 

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issuer Public Key Exponent")]
        [Description("Public Key Exponent")]
        public string Issuer_Public_Key_Exponent { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Issuer Public Key Algorithum Identifier")]
        [Description("Issuer Public Key Algorithum Identifier.")]
        public string Issuer_Public_Key_Algorithum_Identifier { get; set; }

        [Category("Unsigned Pulic Key Input Extension")]
        [DisplayName("Certificate Serial Number")]
        [Description("Certificate Serial Number.")]
        public string Unsigned_Certificate_Serial_Number { get; set; }


        //Self-signed Public Key Data
        [Category("Self-signed Public Key Data")]
        [DisplayName("Readcording Head")]
        [Description("Readcording Head.")]
        public string Self_signed_Recording_head { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Service Identifier")]
        [Description("Service Identifier.")]
        public string Service_Identifier { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Certificate Format")]
        [Description("Certificate Format.")]
        public string Certificate_Format { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("BIN")]
        [Description("BIN.")]
        public string BIN { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Certificate Expiration Date")]
        [Description("Certificate Expiration Date.")]
        public string Certificate_Expiration_Date { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Certificate Serial Number")]
        [Description("Certificate Serial Number.")]
        public string Self_signed_Certificate_Serial_Number { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Hash Algorithim Indicator")]
        [Description("Hash Algorithim Indicator.")]
        public string Hash_Algorithim_Indicator { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Algorithm Indicator")]
        [Description("Issuer Public Key Algorithm Indicator.")]
        public string Issuer_Public_Key_Algorithm_Indicator { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Length")]
        [Description("Issuer Public Key Length.")]
        public string Self_Issuer_Public_Key_Length { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Exponent Length")]
        [Description("Issuer Public Key Exponent Length.")]
        public string Self_Issuer_Public_Key_Exponent_Length { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Leftmost Digis of the Issuer Public Key")]
        [Description("Leftmost Digis of the Issuer Public Key.")]
        public string Leftmost_Digis_of_the_Issuer_Public_Key { get; set; }

        [Category("Self-signed Public Key Data")]
        [DisplayName("Issuer Public Key Exponent")]
        [Description("Issuer Public Key Exponent.")]
        public string Self_Issuer_Public_Key_Exponent { get; set; }

        public string Hash_Result { get; set; }

        public string RemainingHexData { get; set; }

        [Browsable(false)] // ซ่อน Property นี้จาก PropertyGrid
        public string HiddenProperty { get; set; }
    }

}
