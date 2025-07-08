using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities.Encoders;

namespace Encryptions
{
    public class AesHelper
    {
        private static readonly int[] AllowedKeySizes = { 16, 24, 32 };

        public static void ValidateKey(byte[] key)
        {
            if (Array.IndexOf(AllowedKeySizes, key.Length) < 0)
                throw new ArgumentException("Key must be 16, 24, or 32 bytes (AES-128/192/256)");
        }

        public static string Encrypt(string plaintext, string keyHex, string iv, string mode)
        {
            byte[] keyBytes = HexStringToBytes(keyHex);
            byte[] iVBytes = HexStringToBytes(iv);
            byte[] inputBytes = HexStringToBytes(plaintext);

            int keyLen = keyBytes.Length;

            ValidateKey(keyBytes);
            byte[] result;

            using (var aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = mode.ToUpper() == "ECB" ? CipherMode.ECB :
                          mode.ToUpper() == "CBC" ? CipherMode.CBC :
                          throw new ArgumentException("Only ECB and CBC modes are supported.");
                if (aes.Mode == CipherMode.CBC)
                {
                    if (iVBytes == null || iVBytes.Length != aes.BlockSize / 8)
                        throw new ArgumentException("Invalid IV length for CBC mode.");
                    aes.IV = iVBytes;
                }
                aes.Padding = PaddingMode.None;

                using (var encryptor = aes.CreateEncryptor())
                {
                    result = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                }
            }
            return (BitConverter.ToString(result).Replace("-", ""));

        }

        public static string Decrypt(string ciphertext, string keyHex, string ivHex, string mode)
        {
            byte[] keyBytes = HexStringToBytes(keyHex);
            byte[] cipherBytes = HexStringToBytes(ciphertext);

            byte[] iVBytes = HexStringToBytes(ivHex);

            ValidateKey(keyBytes);
            byte[] decrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Mode = mode.ToUpper() == "ECB" ? CipherMode.ECB :
                           mode.ToUpper() == "CBC" ? CipherMode.CBC :
                           throw new ArgumentException("Only ECB and CBC modes are supported.");
                aes.Padding = PaddingMode.None;
                aes.Key = keyBytes;
                if (aes.Mode == CipherMode.CBC)
                {
                    if (iVBytes == null || iVBytes.Length != aes.BlockSize / 8)
                        throw new ArgumentException("Invalid IV length for CBC mode.");
                    aes.IV = iVBytes;
                }

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    decrypted = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                }
            }
            return BitConverter.ToString(decrypted).Replace("-", "");

        }
        static byte[] HexStringToBytes(string hex)
        {
            int len = hex.Length;
            byte[] bytes = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        public static string GetKCV(string keyHex, string mode)
        {
            byte[] keyBytes = HexStringToBytes(keyHex);
            int keyLength = keyBytes.Length;
            ValidateKey(keyBytes);
            byte[] zeroBlock = new byte[16];

            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.None;
                aes.Key = keyBytes;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] encrypted = encryptor.TransformFinalBlock(zeroBlock, 0, zeroBlock.Length);
                    return BitConverter.ToString(encrypted, 0, 3).Replace("-", "");
                }
            }
        }

        public static string GetAesCmac(string messageHex, string keyHex,string ivHex, string mode)
        {
            byte[] keyBytes = HexStringToBytes(keyHex);
            byte[] messageBytes = HexStringToBytes(messageHex);


            CMac cmac = new CMac(new Org.BouncyCastle.Crypto.Engines.AesEngine());
            cmac.Init(new KeyParameter(keyBytes));
            cmac.BlockUpdate(messageBytes, 0, messageBytes.Length);

            byte[] output = new byte[cmac.GetMacSize()];
            cmac.DoFinal(output, 0);

            return BitConverter.ToString(output).Replace("-", "");
            
        }

    }
}
