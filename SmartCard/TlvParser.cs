using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCard
{
    public class TlvParser
    {
        public static Dictionary<string, byte[]> Parse(byte[] data)
        {
            var result = new Dictionary<string, byte[]>();
            int i = 0;

            while (i < data.Length)
            {
                string tag = data[i++].ToString("X2");
                if ((Convert.ToByte(tag, 16) & 0x1F) == 0x1F) tag += data[i++].ToString("X2");

                int length = data[i++];
                if ((length & 0x80) != 0)
                {
                    int numBytes = length & 0x7F;
                    length = 0;
                    for (int j = 0; j < numBytes; j++) length = (length << 8) | data[i++];
                }

                var value = data.Skip(i).Take(length).ToArray();
                result[tag] = value;
                i += length;
            }

            return result;
        }

        public class TLV
        {
            public string Tag { get; set; }
            public int Length { get; set; }
            public byte[] Value { get; set; }

            public override string ToString()
            {
                return $"Tag: {Tag}, Length: {Length}, Value: {BitConverter.ToString(Value).Replace("-", " ")}";
            }
        }

        public class CardInfo
        {
            public string legnth { get; set; }
            public string value { get; set; }
            public string package { get; set; }
            public List<string> applete { get; set; }

        }


        public static List<TLV> ParseTlv(byte[] data)
        {
            List<TLV> tlvs = new List<TLV>();
            int index = 0;

            while (index < data.Length)
            {
                // Read Tag (1 or more bytes)
                int tagStart = index++;
                if (index >= data.Length) break;

                byte tagByte = data[tagStart];
                string tag = tagByte.ToString("X2");

                // Multi-byte tag? If (tag & 0x1F) == 0x1F, read next tag byte(s)
                if ((tagByte & 0x1F) == 0x1F)
                {
                    while (index < data.Length && (data[index] & 0x80) == 0x80)
                    {
                        tag += data[index++].ToString("X2");
                    }
                    if (index < data.Length)
                        tag += data[index++].ToString("X2");
                }

                if (index >= data.Length) break;

                // Read Length (1 or more bytes)
                int length = 0;
                byte lenByte = data[index++];
                if ((lenByte & 0x80) == 0)
                {
                    length = lenByte;
                }
                else
                {
                    int numLenBytes = lenByte & 0x7F;
                    if (index + numLenBytes > data.Length) break;

                    for (int i = 0; i < numLenBytes; i++)
                    {
                        length = (length << 8) | data[index++];
                    }
                }

                if (index + length > data.Length) break;

                byte[] value = data.Skip(index).Take(length).ToArray();
                index += length;

                tlvs.Add(new TLV
                {
                    Tag = tag,
                    Length = length,
                    Value = value
                });
            }

            return tlvs;
        }

        public static List<CardInfo> ParseCardInfo(string data)
        {
            List<CardInfo> cardInfos = new List<CardInfo>();
            int index = 0;
            data = data.Replace(" ","").Replace("-","");

            while (index < data.Length)
            {
                // Read Tag (1 or more bytes)
                if (index >= data.Length) break;

                string length = data.Substring(index, 2);
                index += length.Length;

                string value = data.Substring(index, int.Parse(length, System.Globalization.NumberStyles.HexNumber) * 2);
                index += value.Length;

                string package = data.Substring(index, 6);
                index += package.Length;


                List<string> applete = new List<string>();
                if (package.Substring(0, 2) == "01")
                {
                    int appleteCount = int.Parse(package.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

                    for (int i = 0; i < appleteCount; i++)
                    {
                        string lenghtdata_app = data.Substring(index, 2);
                        index += lenghtdata_app.Length;
                        if(index+ int.Parse(lenghtdata_app, System.Globalization.NumberStyles.HexNumber) * 2 < data.Length)
                        {
                            string data_app = data.Substring(index, int.Parse(lenghtdata_app, System.Globalization.NumberStyles.HexNumber) * 2);
                            index += data_app.Length;

                            applete.Add(data_app);
                        }
                        else
                        {
                            string data_app = data.Substring(index, data.Length-index);
                            index += data_app.Length;

                            applete.Add(data_app);
                        }
                    }

                }
                else if (package.Substring(0, 2) != "01")
                {
                    package = string.Empty;
                }

                cardInfos.Add(new CardInfo
                {
                    legnth = length,
                    value = value,
                    package = package,
                    applete = applete
                });
                
            }

            return cardInfos;
        }
    }

}
