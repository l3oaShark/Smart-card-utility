using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Encryptions.Utils;

namespace Encryptions
{
    public static class DesHelper
    {

        private static readonly int[] AllowedKeySizes = { 8, 16, 24, 32, 48 };

        public static void ValidateKey(byte[] key)
        {
            if (Array.IndexOf(AllowedKeySizes, key.Length) < 0)
                throw new ArgumentException("Key must be 8, 16, 24, 32, or 48 bytes");
        }

        // 1. Generate Key with Odd Parity
        public static string SetOddParity(string keyHex)
        {
            byte[] keyBytes = Utils.HexStringToBytes(keyHex);
            ValidateKey(keyBytes);

            byte[] result = new byte[keyBytes.Length];
            for (int i = 0; i < keyBytes.Length; i++)
            {
                byte b = keyBytes[i];
                int bitCount = Convert.ToString(b, 2).Count(c => c == '1');

                result[i] = (byte)(bitCount % 2 == 0 ? b ^ 0x01 : b);
            }

            return Utils.BytesToHexString(result);
        }

        // 2. Calculate KCV (Key Check Value) = encrypt 8-byte zero with key, return first 3 bytes
        public static string GetKCV(string keyHex)
        {
            byte[] keyBytes = Utils.HexStringToBytes(keyHex);
            ValidateKey(keyBytes);
            try
            {
                var engine = new DesEdeEngine();
                var parameters = new DesEdeParameters(keyBytes);
                engine.Init(true, parameters);

                byte[] zeroBlock = new byte[8];
                byte[] encrypted = new byte[8];
                engine.ProcessBlock(zeroBlock, 0, encrypted, 0);

                byte[] kcv = encrypted.Take(3).ToArray();
                return Utils.BytesToHexString(kcv);
            }
            catch (ArgumentException ex) when (ex.Message.Contains("attempt to create weak DESede key"))
            {
                DialogResult result = MessageBox.Show(
                    "A weak DES key was detected.\nDo you want to proceed anyway?",
                    "Weak Key Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    //if (keyBytes.Length == 16)
                    //{
                    //    byte[] extendedKey = new byte[24];
                    //    Array.Copy(keyBytes, 0, extendedKey, 0, 16);
                    //    Array.Copy(keyBytes, 0, extendedKey, 16, 8); // K3 = K1
                    //    keyBytes = extendedKey;
                    //}

                    //if (keyBytes.Length != 24)
                    //    throw new ArgumentException("Key must be 16 or 24 bytes");

                    // ใช้ ECB mode เข้ารหัสบล็อก 0x00 8 ไบต์
                    var engine = new DesEdeEngine(); // Triple DES Engine (DES-EDE)
                    engine.Init(true, new KeyParameter(keyBytes));

                    byte[] inputBlock = new byte[8]; // บล็อกข้อมูลเป็น 0x00 ทั้งหมด
                    byte[] outputBlock = new byte[8];
                    engine.ProcessBlock(inputBlock, 0, outputBlock, 0);

                    return Utils.BytesToHexString(outputBlock.Take(3).ToArray());
                }
                else
                {
                   return string.Empty;
                }
            }





        }
        
        // 3. Encrypt data with DES ECB NoPadding
        public static string Encrypt(string keyHex, string dataHex, CryptoMode mode, string ivHex)
        {
            byte[] keyBytes = Utils.HexStringToBytes(keyHex);
            byte[] dataBytes = Utils.HexStringToBytes(dataHex);
            ValidateKey(keyBytes);

            byte[] ivBytes = null;
            if (!string.IsNullOrEmpty(ivHex))
                ivBytes = Utils.HexStringToBytes(ivHex);

            IBlockCipher engine = new DesEdeEngine();
            IBlockCipher blockCipher;

            if (mode == CryptoMode.CBC)
            {
                if (ivBytes == null || ivBytes.Length != 8)
                    throw new ArgumentException("IV must be 8 bytes for CBC mode.");

                blockCipher = new CbcBlockCipher(engine);
            }
            else if (mode == CryptoMode.ECB)
            {
                blockCipher = engine;
            }
            else
            {
                throw new ArgumentException("Unsupported cipher mode: " + mode);
            }


            if (keyBytes.Length == 8)
            {
                keyBytes = keyBytes.Concat(keyBytes).ToArray(); // 8 + 8 = 16 bytes
            }


            BufferedBlockCipher cipher = new BufferedBlockCipher(blockCipher);

            ICipherParameters parameters;
            if (mode == CryptoMode.CBC)
            {
                parameters = new ParametersWithIV(new DesEdeParameters(keyBytes), ivBytes);
            }
            else
            {
                parameters = new DesEdeParameters(keyBytes);
            }

            cipher.Init(true, parameters);

            byte[] outputBytes = cipher.DoFinal(dataBytes);
            return Utils.BytesToHexString(outputBytes);
        }


        // 4. Decrypt data with DES ECB NoPadding
        public static string Decrypt(string keyHex, string encryptedHex, CryptoMode mode, string ivHex)
        {
            byte[] keyBytes = Utils.HexStringToBytes(keyHex);
            byte[] encryptedBytes = Utils.HexStringToBytes(encryptedHex);
            ValidateKey(keyBytes);

            byte[] ivBytes = null;
            if (!string.IsNullOrEmpty(ivHex))
                ivBytes = Utils.HexStringToBytes(ivHex);

            IBlockCipher engine = new DesEdeEngine();
            IBlockCipher blockCipher;

            if (mode == CryptoMode.CBC)
            {
                if (ivBytes == null || ivBytes.Length != 8)
                    throw new ArgumentException("IV must be 8 bytes for CBC mode.");

                blockCipher = new CbcBlockCipher(engine);
            }
            else if (mode == CryptoMode.ECB)
            {
                blockCipher = engine;
            }
            else
            {
                throw new ArgumentException("Unsupported cipher mode: " + mode);
            }

            if (keyBytes.Length == 8)
            {
                keyBytes = keyBytes.Concat(keyBytes).ToArray(); // 8 + 8 = 16 bytes
            }

            BufferedBlockCipher cipher = new BufferedBlockCipher(blockCipher);

            ICipherParameters parameters;
            if (mode == CryptoMode.CBC)
            {
                parameters = new ParametersWithIV(new DesEdeParameters(keyBytes), ivBytes);
            }
            else
            {
                parameters = new DesEdeParameters(keyBytes);
            }

            cipher.Init(false, parameters);  // false = decrypt

            byte[] outputBytes = cipher.DoFinal(encryptedBytes);
            return Utils.BytesToHexString(outputBytes);
        }


        // 5. XOR 3 key values and return new key and KCV
        public static (string xorKey, string kcv) XorThreeKeys(string keyHex1, string keyHex2, string keyHex3)
        {
            byte[] keyBytes1 = Utils.HexStringToBytes(keyHex1);
            byte[] keyBytes2 = Utils.HexStringToBytes(keyHex2);
            byte[] keyBytes3 = Utils.HexStringToBytes(keyHex3);

            int length = keyBytes1.Length;
            if ((length == 16 || length == 24) &&
                keyBytes2.Length == length && keyBytes3.Length == length)
            {
                var result = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    result[i] = (byte)(keyBytes1[i] ^ keyBytes2[i] ^ keyBytes3[i]);
                }

                string xorKeyHex = Utils.BytesToHexString(result);
                string oddKeyHex = SetOddParity(xorKeyHex);

                string kcv = GetKCV(oddKeyHex);
                return (oddKeyHex, kcv);
            }
            else
            {
                throw new ArgumentException("All keys must be the same length and either 16 or 24 bytes");
            }
        }
    }
}
