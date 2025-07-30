using System;
using System.Text;
using System.Security.Cryptography;
namespace Encryptions
{
    public static class Utils
    {
        public enum CryptoMode
        {
            ECB,
            CBC
        }

        public static byte[] HexStringToBytes(string hex)
        {
            hex = hex.Replace(" ", "").Replace("-", "");
            int len = hex.Length;
            byte[] bytes = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
        public static string BytesToHexString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }


        public static byte[] PadToBlock(byte[] input, int blockSize = 8)
        {
            int padLen = blockSize - (input.Length % blockSize);
            byte[] padded = new byte[input.Length + padLen];
            Buffer.BlockCopy(input, 0, padded, 0, input.Length);
            for (int i = input.Length; i < padded.Length; i++) padded[i] = (byte)padLen;
            return padded;
        }

        public static byte[] TripleDesEncrypt(byte[] key, byte[] data, byte[] iv = null, bool useCBC = true)
        {
            using (var tdes = new TripleDESCryptoServiceProvider())
            {
                tdes.Key = key;
                tdes.Mode = useCBC ? CipherMode.CBC : CipherMode.ECB;
                tdes.Padding = PaddingMode.None;
                if (useCBC) tdes.IV = iv ?? new byte[8];

                ICryptoTransform encryptor = tdes.CreateEncryptor();
                byte[] padded = PadToBlock(data, 8);
                return encryptor.TransformFinalBlock(padded, 0, padded.Length);
            }
        }
        public static byte[] DeriveSessionKey(byte[] baseKey, byte[] modeByte, byte[] counter)
        {
            byte[] input = new byte[16];
            Buffer.BlockCopy(modeByte, 0, input, 0, 2);
            Buffer.BlockCopy(counter, 0, input, 2, 2);
            // rest is 0x00

            var encrypted = TripleDesEncrypt(baseKey, input, new byte[8]);
            byte[] result = new byte[16];
            Buffer.BlockCopy(encrypted, 0, result, 0, 16);
            return result;
        }

        public static byte[] ComputeCryptogram(byte[] key, byte[] data)
        {
            var fullResult = TripleDesEncrypt(key, data, new byte[8]);
            byte[] result = new byte[8];
            Buffer.BlockCopy(fullResult, 0, result, 0, 8);
            return result;
        }
        public static byte[] ComputeMac(byte[] key, byte[] data)
        {
            var encrypted = TripleDesEncrypt(key, PadToBlock(data), new byte[8]);
            byte[] mac = new byte[8];
            Buffer.BlockCopy(encrypted, encrypted.Length - 8, mac, 0, 8);
            return mac;
        }

        public static byte[] DeriveNewKey(byte[] masterKey, byte[] csn, byte[] batchId, byte[] constant)
        {
            byte[] input = new byte[32];
            Buffer.BlockCopy(csn, 0, input, 0, 4);
            Buffer.BlockCopy(batchId, 0, input, 4, 2);
            Buffer.BlockCopy(constant, 0, input, 6, 2);
            Buffer.BlockCopy(csn, 0, input, 8, 4);
            Buffer.BlockCopy(batchId, 0, input, 12, 2);
            Buffer.BlockCopy(constant, 0, input, 14, 2);

            var encrypted = TripleDesEncrypt(masterKey, input, null, useCBC: false);

            byte[] result = new byte[16];
            Buffer.BlockCopy(encrypted, 0, result, 0, 16);
            return result;
        }

        public static byte[] GetRandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return bytes;
        }

    }
}
