using Smart_card_utility;
using SmartCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartCardUtility
{
    public class SmartCardInfo
    {
        private readonly string _readerName;

        public SmartCardInfo(string readerName)
        {
            _readerName = readerName;
        }

        // ดึง ATR จากบัตร
        public byte[] GetATR()
        {
            var smartCard = new SmartCardManager();
            
                IntPtr hContext = smartCard.EstablishContext();
                uint protocol;
                IntPtr hCard = SmartCardManager.PowerOnCard(hContext, _readerName, out IntPtr cardHandle);
                if (hCard == IntPtr.Zero)
                    return null;

                var atr = SmartCardManager.GetCardATR(hCard);

                //SmartCardManager.PowerOffCard(hCard);
            return atr;
            
        }

        // ดึงข้อมูลโดยส่ง APDU (Get Data แบบ ISO7816)
        public byte[] GetData(byte p1, byte p2, int le = 0)
        {
            // ตัวอย่าง APDU: 80 CA P1 P2 Le (Mifare, GlobalPlatform)
            byte lc = 0;
            List<byte> apdu = new List<byte> { 0x80, 0xCA, p1, p2 };
            if (le > 0)
                apdu.Add((byte)le);

            return ApduHelper.TransmitApduCommand(_readerName, apdu.ToArray());
        }

        // อ่านข้อมูลโดยส่ง APDU Read Binary (ตัวอย่าง)
        public byte[] ReadBinary(byte p1, byte p2, int le)
        {
            byte[] apdu = new byte[] { 0x00, 0xB0, p1, p2, (byte)le };
            return ApduHelper.TransmitApduCommand(_readerName, apdu);
        }

        // แปลง ATR เป็น string สั้นๆ (เช่น ISO 7816 T=1)
        public string DecodeATR(byte[] atr)
        {
            if (atr == null || atr.Length == 0)
                return "No ATR";

            // ตัวอย่างง่ายๆ (ควรใช้ library แยก ATR จริงจัง)
            string atrStr = BitConverter.ToString(atr).Replace("-", " ");
            if (atrStr.StartsWith("3B 65")) return "ISO 7816 T=1";
            if (atrStr.StartsWith("3B 68")) return "ISO 7816 T=0";
            return "Unknown ATR: " + atrStr;
        }

        // Parse TLV เพื่ออ่านข้อมูลตาม Tag
        public Dictionary<string, string> ParseCardInfoFromTlv(byte[] tlvData)
        {
            var tlvs = TlvParser.ParseTlv(tlvData);
            Dictionary<string, string> info = new Dictionary<string, string>();

            foreach (var tlv in tlvs)
            {
                string tag = tlv.Tag.ToUpper();
                string valStr = Encoding.ASCII.GetString(tlv.Value);

                switch (tag)
                {
                    case "5F20": info["Cardholder Name"] = valStr; break;
                    case "5F2D": info["Language Preference"] = valStr; break;
                    case "9F0B": info["IC Fabricator"] = valStr; break;
                    case "9F0C": info["OS Identifier"] = valStr; break;
                    case "9F0D": info["OS Release"] = valStr; break;
                    case "9F10": info["IC Serial Number"] = valStr; break;
                    // เพิ่ม tag อื่นๆ ตามความต้องการได้
                    default:
                        info[tag] = valStr;
                        break;
                }
            }

            return info;
        }

        // ฟังก์ชันหลักดึงข้อมูลบัตร (ตัวอย่าง)
        public Dictionary<string, string> GetCardInfo()
        {
            // 1. ดึง ATR
            var atr = GetATR();
            string atrInfo = DecodeATR(atr);

            // 2. ดึงข้อมูล Card Info (สมมุติว่าบัตร support GET DATA 0x9F10)
            var rawData = GetData(0x9F, 0x10, 0); // Le=0 หมายถึงขอข้อมูลทั้งหมด

            var info = new Dictionary<string, string>();
            info["ATR"] = atrInfo;

            if (rawData != null)
            {
                var parsed = ParseCardInfoFromTlv(rawData);
                foreach (var kv in parsed)
                    info[kv.Key] = kv.Value;
            }
            else
            {
                info["Error"] = "Failed to get card info";
            }

            return info;
        }
    }
}
