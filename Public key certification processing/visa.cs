using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace Public_key_certification_processing
{
    public class visa
    {
        private static int offset;
        private static string ReadBytes(int byteCount, string hex)
        {
            string results = hex.Substring(offset, byteCount * 2);
            offset += byteCount * 2;
            return results;
        }
        public static Properties_Files Header22(string hexInput)
        {
            offset = 0;

            var result = new Properties_Files();

            // 1. Record Header (1 byte) = 22
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Modulus Length (1 byte) Length NI of IPK Modulus in hex (number of bytes)
            result.Issue_Public_Key_Length = ReadBytes(1, hexInput);
            int pkLength = int.Parse(result.Issue_Public_Key_Length, NumberStyles.HexNumber);
            result.Issue_Public_Key_Length = (pkLength).ToString();

            // 3. Public Key (pkLength bytes) Issuer’s Public Key Modulus
            result.Issuer_Public_Key_Modulus = ReadBytes(pkLength, hexInput);

            // 4. Len (1 byte) 
            // Length of IPK Exponent(Number of bytes). Either hex
            // 01(for exponent 3) or hex 03(for exponent 65537)
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int keyExpLen = int.Parse(result.Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 5. KeyExp (keyExpLen bytes) Length of IPK Exponent (Number of bytes). Either hex 01(for exponent 3) or hex 03(for exponent 65537)
                result.Issuer_Public_Key_Exponent = ReadBytes(keyExpLen, hexInput);

            //// 6. Identifier (1 byte) IPK Exponent. Must be either 3 or 65537, that is, hex 03 or hex 01 00 01
            //result.Issuer_Public_Key_Algorithum_Identifier = ReadBytes(1, hexInput);

            // 7. Record (3 bytes) Tracking Number assigned to issuer by Visa
            result.Key_Tracking_Number = ReadBytes(3, hexInput);

            return result;
        }

        public static Properties_Files Header23(string hexInput)
        {
            offset = 0;
            
            var result = new Properties_Files();

            // 1. Record Header (1 byte) Hex 23
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Service identifier (4 byte)
            string code = ReadBytes(4, hexInput);
            if (code == "10100000")
                result.Service_Identifier = "Debit/credit";
            else if (code == "20100000")
                result.Service_Identifier = "Electron";
            else if (code == "20200000")
                result.Service_Identifier = " V PAY";
            else if (code == "30100000")
                result.Service_Identifier = "Interlink";
            else if (code == "80100000")
                result.Service_Identifier = "PLUS";

            // 3. Certificate format (1 byte) Hex 02
            result.Certificate_Format = ReadBytes(1, hexInput);

            // 4. Issuer identifier (4 byte) Leftmost three to eight digits from the Primary Account Number(PAN), padded on the right with hex Fs
            result.BIN = ReadBytes(4, hexInput);

            // 5. Certificate expiry date (2 byte) Month and Year (MMYY) after which this certificate is invalid
            result.Certificate_Expiration_Date = ReadBytes(2, hexInput);

            // 6. Tracking (3 bytes) Tracking Number as assigned by Visa to the issuer
            result.Key_Tracking_Number = ReadBytes(3, hexInput);

            // 7. Hash algorithm identifier (1 byte) Identifies the SHA-1 hash algorithm used to produce the
            // Hash Result. This value is hex 01 for SHA - 1, as defined in EMV 4.1, Book 2, Annex B3.1.
            result.Hash_Algorithim_Indicator = ReadBytes(1, hexInput);

            // 8. Algorithm identifier of issuer public key (1 byte)
            // Identifies the digital signature algorithm to be used with
            // the issuer’s Public Key.The value is hex 01 for RSA as it is
            // used here, as defined in EMV 4.1, Book 2, Annex B2.1.
            result.Issuer_Public_Key_Algorithm_Indicator = ReadBytes(1, hexInput);

            // 9. Length of issuer public key modulus (1 byte) Length NI of the IPK Modulus in hex (number of bytes).
            result.Self_Issuer_Public_Key_Length = ReadBytes(1, hexInput);
            int pkLength = int.Parse(result.Self_Issuer_Public_Key_Length, NumberStyles.HexNumber);

            // 10. Length of issuer’s public key index (1 byte)
            // Length e of the IPK Exponent in hex (number of bytes).
            // Either hex 01(for exponent 3) or hex 03(for exponent 65537).
            result.Self_Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int e = int.Parse(result.Self_Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 11. Left part of the issuer public key modulus  NI − (39 + e) bytes of IPK Modulus.
            result.Leftmost_Digis_of_the_Issuer_Public_Key = ReadBytes(pkLength - (39 + e), hexInput);

            //12. IPK Exponent. Is either 3 or 65537, that is, hex 03 or hex 01 00 01.
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(e, hexInput);

            // 13. Hash Result (20)
            // SHA-1 hash of all elements in this table, except Hash
            // Result, that is, of Header through IPK Exponent, in the
            // order that they appear in the table.
            result.Hash_Result = ReadBytes(20, hexInput);


            return result;
        }

        public static Properties_Files Header24(string hexInput)
        {
            offset = 0;

            var result = new Properties_Files();

            // 1. Record Header (1 byte) Hex 24
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Service identifier (4 byte)
            string code = ReadBytes(4, hexInput);
            if (code == "10100000")
                result.Service_Identifier = "Debit/credit";
            else if (code == " 20100000")
                result.Service_Identifier = "Electron";
            else if (code == " 20200000")
                result.Service_Identifier = " V PAY";
            else if (code == " 30100000")
                result.Service_Identifier = "Interlink";
            else if (code == " 80100000")
                result.Service_Identifier = "PLUS";

            // 3. Issuer identifier (4 byte) Issuer Identification Number(IIN)
            // Leftmost three to eight digits from the Primary Account Number(PAN), padded on the right with hex Fs.
           result.BIN = ReadBytes(4, hexInput);

            // 4. Record No. (3 byte) Certificate Serial Number assigned by VSDC CA.
            result.Self_signed_Certificate_Serial_Number = ReadBytes(3, hexInput);
            int Nca = int.Parse(result.Self_signed_Certificate_Serial_Number, NumberStyles.HexNumber);

            // 5. Certificate expiry date (2 byte)
            // Month and Year (MMYY) after which this certificate is invalid, as defined by the issuer.
            result.Certificate_Expiration_Date = ReadBytes(2, hexInput);

            // 9. Length of issuer public key modulus (1 byte) Length of the IPK Modulus Remainder in hex (number of bytes),
            result.Issue_Public_Key_Length = ReadBytes(1, hexInput);
            int Ni = int.Parse(result.Issue_Public_Key_Length, NumberStyles.HexNumber);

            // 10. Left part of the issuer public key modulus (NI − (39+e))
            // Field only present if NI > NCA - 36, and consists of the NI – NCA + 36 least significant bytes of the IPK Modulus.
            // NI is the length, in bytes, of the IPK Modulus and NCA is the length, in bytes, of the VSDC CA Key used to create the IPK certificate
            int len = 0;
            if (Ni > Nca - 36)
            {
                len = Ni - Nca + 36;
            }
            else
            {
                throw new Exception("Issuer public key length < CA . ");
            }
            result.Issuer_Public_Key_Modulus = ReadBytes(len, hexInput);

            // 11. Length of issuer’s public key index (1 byte)
            //Length e of the IPK Exponent in hex (Number of bytes).
            //Either hex 01(for exponent 3) or hex 03(for exponent 65537)
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int keyExpLen = int.Parse(result.Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 12. KeyExp (keyExpLen bytes)
            // IPK Exponent. Is either 3 or 65537, that is, hex 03 or hex 01 00 01.
            result.Issuer_Public_Key_Exponent = ReadBytes(keyExpLen, hexInput);

            // 13. CA Public Key Index Public Key Index for VSDC CA Key used to create the IPK certificate
            result.Issue_Public_Key_Length = ReadBytes(1, hexInput);

            return result;
        }

        public static Properties_Files Header6A(string hexInput)
        {
            offset = 0;
            var result = new Properties_Files();

            // 1. Record Header (1 byte) Hex 6A
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Certificate format (1 byte) Hex 02
            result.Certificate_Format = ReadBytes(1, hexInput);

            // 3. Issuer identifier (4 byte)
            // Leftmost three to eight digits from the Primary Account Number(PAN) padded on the right with hex Fs.
            result.BIN = ReadBytes(4, hexInput);

            // 4. Certificate expiry date (2 byte) Month and Year (MMYY) after which this certificate is invalid, as defined by the issuer
            result.Certificate_Expiration_Date = ReadBytes(2, hexInput);

            // 5. Certificate Serial Number (3 byte) Binary number unique to this certificate assigned by the CA.
            result.Self_signed_Certificate_Serial_Number = ReadBytes(3, hexInput);
            int Nca = int.Parse(result.Self_signed_Certificate_Serial_Number, NumberStyles.HexNumber);

            // 6. Hash algorithm identifier (1 byte)
            //Identifies the hash algorithm used to produce the Hash Result in the digital signature scheme. For SHA1, this value is hex 01.
            result.Hash_Algorithim_Indicator = ReadBytes(1, hexInput);

            // 7. Algorithm identifier of issuer public key (1 byte)
            //Identifies the digital signature algorithm to be used with the IPK.For RSA as specified in the EMV 4.1, Book 2, Appendix B2.1, this value is hex 01
            result.Issuer_Public_Key_Algorithm_Indicator = ReadBytes(1, hexInput);

            // 8. Modulus Length (1 byte)
            //Length NI of the IPK Modulus, in hex(number of bytes)
            result.Issue_Public_Key_Length = ReadBytes(1, hexInput);
            int Ni = int.Parse(result.Issue_Public_Key_Length, NumberStyles.HexNumber);
            result.Issue_Public_Key_Length = (Ni).ToString();

            // 9. Issuer Public Key Exponent Length(1 byte)
            // Identifies the length of the IPK Exponent in bytes.
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int keyExpLen = int.Parse(result.Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 10. Public Key (pkLength bytes)
            //Issuer Public Key Modulus or Leftmost part of the Issuer Public Key Modulus

            int len = 0;
            if (Ni <= Nca - 36)
            {
                len = Nca - 36 - Ni;
            }
            else if(Ni > Nca - 36)
            {
                len = Nca - 36;
            }
            result.Issuer_Public_Key_Modulus = ReadBytes(len, hexInput);

            // 11. Hash Result (20)
            // SHA - 1 hash of the data specified in EMV 4.1, Book 2, Section 5.1, Table 2.
            result.Hash_Result = ReadBytes(20, hexInput);


            return result;
        }
        public static Properties_Files Header20(string hexInput)
        {
            offset = 0;
            
            var result = new Properties_Files();

            // 1. Record Header (1 byte) Hex 20
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Service identifier (4 byte)
            // Identifies a Visa service.
            //The Proprietary Application Identifier Extension
            //(PIX) is left justified and padded on the right with
            //four hex zeros.
            //Current valid International Service Identifiers are:
            //• hex 1010 0000 for Debit / Credit
            //• hex 2010 0000 for Electron
            //• hex 2020 0000 for V PAY
            //• hex 3010 0000 for Interlink
            //• hex 8010 0000 for PLUS
            //For valid regional / National Service Identifiers,
            //check with your Visa representative for current list.
            string code = ReadBytes(4, hexInput);
            if (code == "10100000")
                result.Service_Identifier = "Debit/credit";
            else if (code == "20100000")
                result.Service_Identifier = "Electron";
            else if (code == "20200000")
                result.Service_Identifier = "V PAY";
            else if (code == "30100000")
                result.Service_Identifier = "Interlink";
            else if (code == "80100000")
                result.Service_Identifier = "PLUS";


            // 3. Length of VSDC CA Public Key Modulus (2 byte)
            // Length NCA of VSDC CA Public Key Modulus in hex (number of bytes). NCA will be an even number.
            result.Issue_Public_Key_Length = ReadBytes(1, hexInput);

            // 4. VSDC CA Public Key Algorithm Indicator(1 byte)
            // Identifies cryptographic algorithm used to generate the VSDC CA Public Key
            result.Issuer_Public_Key_Algorithm_Indicator = ReadBytes(1, hexInput);


            // 5. Length of VSDC CA Public Key Exponent (1 byte)
            //Length eCA of VSDC CA Public Key Exponent in hex (number of bytes).
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int eCA = int.Parse(result.Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 6. Registered Application Provider Identifier(RID) (5 byte) Identifies Visa. It is hex A0 00 00 00 03
            result.Certificate_Format = ReadBytes(5, hexInput);

            // 7. vSDC CA Public Key Index
            result.Self_Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int nCA = int.Parse(result.Self_Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 8. VSDC CA Public Key Modulus  Along with the RID, identifies the CA Public Key to use to recover the certificate
            result.Issuer_Public_Key_Modulus = ReadBytes(nCA, hexInput);

            // 9. vSDC CA Public Key Exponent Exponent of VSDC CA Public Key.
            result.Self_Issuer_Public_Key_Exponent_Length = ReadBytes(eCA, hexInput);

            // 10. Hash Result (20)
            result.Hash_Result = ReadBytes(20, hexInput);


            return result;

        }

        public static Properties_Files Header21(string hexInput)
        {
            offset = 0;
            var result = new Properties_Files();

            // 1. Record Header (1 byte)
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Service identifier (4 byte)
            string code = ReadBytes(4, hexInput);
            if (code == " 10100000")
                result.Service_Identifier = "Debit/credit";
            else if (code == " 20100000")
                result.Service_Identifier = "Electron";
            else if (code == " 20200000")
                result.Service_Identifier = " V PAY";
            else if (code == "30100000")
                result.Service_Identifier = "Interlink";
            else if (code == "80100000")
                result.Service_Identifier = "PLUS";

            // 3.Registered Application Provider Identifier(RID) (5byte) Identifies Visa. It is hex A0 00 00 00 03
            result.BIN = ReadBytes(5, hexInput);

            // 4. VSDC CA Public Key Index (1 byte) Along with the RID, identifies the CA Public Key to use to recover the certificate.
            result.Self_Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int Nca = int.Parse(result.Self_Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 5. Certificate expiry date (2 byte) Month and Year (MMYY) after which the Visa key represented by this certificate is invalid.
            result.Certificate_Expiration_Date = ReadBytes(2, hexInput);

            // 6. VSDC CA Public Key Algorithm Indicator(1 byte) Hex 01 for RSA as the algorithm used to generate the VSDC CA Public Key
            result.Issuer_Public_Key_Algorithm_Indicator = ReadBytes(1, hexInput);

            // 7. Left part of the issuer public key modulus
            // NCA − 36 + eCA leftmost (most significant) bytes of the VSDC CA Public Key Modulus, where NCA and
            //eCA are the lengths of the VSDC Public Key Modulus and VSDC Public Key Exponent, respectively.
            int Eca =0;
            result.Leftmost_Digis_of_the_Issuer_Public_Key = ReadBytes(Nca - (36 + Eca), hexInput);

            // 8. Hash algorithm identifier (1 byte) Hex 01 which identifies the SHA-1 hash algorithm used to produce the Hash Result.
            result.Hash_Algorithim_Indicator = ReadBytes(1, hexInput);

            // 9. VSDC CA Public Key Exponent Length(1 byte) Length eCA of VSDC CA Public Key Exponent in hex (number of bytes).
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int keyExpLen = int.Parse(result.Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 10. VSDC CA Public Key Exponent (eCA byte) Exponent of VSDC CA Public Key.
            result.Issuer_Public_Key_Exponent = ReadBytes(keyExpLen, hexInput);

            // 11. Hash Result (20)
            result.Hash_Result = ReadBytes(20, hexInput);

            return result;

        }

        public static Properties_Files MapINPFilesToProperties(string hexInput)
        {
            offset = 0;
            var result = new Properties_Files();

            // 1. Record Header (1 byte)
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Modulus Length (1 byte)
            result.Issue_Public_Key_Length = ReadBytes(1, hexInput);
            int pkLength = int.Parse(result.Issue_Public_Key_Length, NumberStyles.HexNumber);
            result.Issue_Public_Key_Length = (pkLength).ToString();

            // 3. Public Key (pkLength bytes)
            result.Issuer_Public_Key_Modulus = ReadBytes(pkLength, hexInput);

            // 4. Len (1 byte)
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int keyExpLen = int.Parse(result.Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 5. KeyExp (keyExpLen bytes)
            result.Issuer_Public_Key_Exponent = ReadBytes(keyExpLen, hexInput);

            // 6. Identifier (1 byte)
            result.Issuer_Public_Key_Algorithum_Identifier = ReadBytes(1, hexInput);

            // 7. Record (3 bytes)
            result.Key_Tracking_Number = ReadBytes(3, hexInput);

            if (offset < hexInput.Length)
            {
                string RemainingHexData = PublicKeyProcessor.VerifySignatureRSA(result.Issuer_Public_Key_Modulus, result.Issuer_Public_Key_Exponent, hexInput.Substring(offset));
                offset = 0;

                //Self-signed Public Key Data
                // 1. Record Header (1 byte)
                result.Self_signed_Recording_head = ReadBytes(1, RemainingHexData);

                // 2. Service identifier (4 byte)
                string code = ReadBytes(4, RemainingHexData);
                if (code == "01010000")
                    result.Service_Identifier = "Debit/credit";
                else if (code == "01010100")
                    result.Service_Identifier = "Debit";
                else if (code == "01010200")
                    result.Service_Identifier = "Credit";
                else if (code == "01010300")
                    result.Service_Identifier = "Quasi credit";
                else if (code == "01010600")
                    result.Service_Identifier = "stored-value e-cash";

                // 3. Certificate format (1 byte)
                result.Certificate_Format = ReadBytes(1, RemainingHexData);

                // 4. Issuer identifier (4 byte)
                result.BIN = ReadBytes(4, RemainingHexData);

                // 5. Certificate expiry date (2 byte)
                result.Certificate_Expiration_Date = ReadBytes(2, RemainingHexData);

                // 6. Record No. (3 byte)
                result.Self_signed_Certificate_Serial_Number = ReadBytes(3, RemainingHexData);

                // 7. Hash algorithm identifier (1 byte)
                result.Hash_Algorithim_Indicator = ReadBytes(1, RemainingHexData);

                // 8. Algorithm identifier of issuer public key (1 byte)
                result.Issuer_Public_Key_Algorithm_Indicator = ReadBytes(1, RemainingHexData);

                // 9. Length of issuer public key modulus (1 byte)
                result.Self_Issuer_Public_Key_Length = ReadBytes(1, RemainingHexData);
                pkLength = int.Parse(result.Self_Issuer_Public_Key_Length, NumberStyles.HexNumber);

                // 10. Length of issuer’s public key index (1 byte)
                result.Self_Issuer_Public_Key_Exponent_Length = ReadBytes(1, RemainingHexData);
                int e = int.Parse(result.Self_Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

                // 11. Left part of the issuer public key modulus (NI − (39+e))
                result.Leftmost_Digis_of_the_Issuer_Public_Key = ReadBytes(pkLength - (39 + e), RemainingHexData);

                // 12. Issuer public key index (e)
                result.Self_Issuer_Public_Key_Exponent = ReadBytes(1, RemainingHexData);


                // 13. Hash Result (20)
                result.Hash_Result = ReadBytes(20, RemainingHexData);
            }

            return result;

        }


        public static Properties_Files orginal(string hexInput)
        {
            int offset = 0;
            string ReadBytes(int byteCount, string hex)
            {
                string results = hex.Substring(offset, byteCount * 2);
                offset += byteCount * 2;
                return results;
            }
            var result = new Properties_Files();

            // 1. Record Header (1 byte)
            result.Unsigned_Recording_Head = ReadBytes(1, hexInput);

            // 2. Modulus Length (1 byte)
            result.Issue_Public_Key_Length = ReadBytes(1, hexInput);
            int pkLength = int.Parse(result.Issue_Public_Key_Length, NumberStyles.HexNumber);
            result.Issue_Public_Key_Length = (pkLength).ToString();

            // 3. Public Key (pkLength bytes)
            result.Issuer_Public_Key_Modulus = ReadBytes(pkLength, hexInput);

            // 4. Len (1 byte)
            // Length of IPK Exponent(Number of bytes). Either hex
            // 01(for exponent 3) or hex 03(for exponent 65537)
            result.Issuer_Public_Key_Exponent_Length = ReadBytes(1, hexInput);
            int keyExpLen = int.Parse(result.Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

            // 5. KeyExp (keyExpLen bytes)

            result.Issuer_Public_Key_Exponent = ReadBytes(keyExpLen, hexInput);




            // 6. Identifier (1 byte)
            result.Issuer_Public_Key_Algorithum_Identifier = ReadBytes(1, hexInput);

            // 7. Record (3 bytes)
            result.Key_Tracking_Number = ReadBytes(3, hexInput);

            if (offset < hexInput.Length)
            {
                string RemainingHexData = PublicKeyProcessor.VerifySignatureRSA(result.Issuer_Public_Key_Modulus, result.Issuer_Public_Key_Exponent, hexInput.Substring(offset));
                offset = 0;

                //Self-signed Public Key Data
                // 1. Record Header (1 byte)
                result.Self_signed_Recording_head = ReadBytes(1, RemainingHexData);

                // 2. Service identifier (4 byte)
                string code = ReadBytes(4, RemainingHexData);
                if (code == "01010000")
                    result.Service_Identifier = "Debit/credit";
                else if (code == "01010100")
                    result.Service_Identifier = "Debit";
                else if (code == "01010200")
                    result.Service_Identifier = "Credit";
                else if (code == "01010300")
                    result.Service_Identifier = "Quasi credit";
                else if (code == "01010600")
                    result.Service_Identifier = "stored-value e-cash";

                // 3. Certificate format (1 byte)
                result.Certificate_Format = ReadBytes(1, RemainingHexData);

                // 4. Issuer identifier (4 byte)
                result.BIN = ReadBytes(4, RemainingHexData);

                // 5. Certificate expiry date (2 byte)
                result.Certificate_Expiration_Date = ReadBytes(2, RemainingHexData);

                // 6. Record No. (3 byte)
                result.Self_signed_Certificate_Serial_Number = ReadBytes(3, RemainingHexData);

                // 7. Hash algorithm identifier (1 byte)
                result.Hash_Algorithim_Indicator = ReadBytes(1, RemainingHexData);

                // 8. Algorithm identifier of issuer public key (1 byte)
                result.Issuer_Public_Key_Algorithm_Indicator = ReadBytes(1, RemainingHexData);

                // 9. Length of issuer public key modulus (1 byte)
                result.Self_Issuer_Public_Key_Length = ReadBytes(1, RemainingHexData);
                pkLength = int.Parse(result.Self_Issuer_Public_Key_Length, NumberStyles.HexNumber);

                // 10. Length of issuer’s public key index (1 byte)
                result.Self_Issuer_Public_Key_Exponent_Length = ReadBytes(1, RemainingHexData);
                int e = int.Parse(result.Self_Issuer_Public_Key_Exponent_Length, NumberStyles.HexNumber);

                // 11. Left part of the issuer public key modulus (NI − (39+e))
                result.Leftmost_Digis_of_the_Issuer_Public_Key = ReadBytes(pkLength - (39 + e), RemainingHexData);

                // 12. Issuer public key index (e)
                result.Self_Issuer_Public_Key_Exponent = ReadBytes(1, RemainingHexData);


                // 13. Hash Result (20)
                result.Hash_Result = ReadBytes(20, RemainingHexData);
            }

            return result;
        }
    }
}
