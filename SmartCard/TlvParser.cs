using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmartCard.TlvParser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        public class Applications
        {
            public string length { get; set; }
            public string app { get; set; }
            public string details { get; set; }

        }
        public class CPLC
        {
            public string IC_Fabricator { get; set; }
            public string IC_Type   { get; set; }
            public string OS_ID { get; set; }
            public string OS_release_date { get; set; }
            public string OS_release_level { get; set; }
            public string IC_Fabrication_Date { get; set; }
            public string IC_Serial_Number { get; set; }
            public string IC_Batch_Identifier  { get; set; }
            public string IC_Module_Fabricator { get; set; }
            public string IC_Module_Packaging_Date { get; set; }
            public string ICC_Manufacturer   { get; set; }
            public string IC_Embedding_Date { get; set; }
            public string IC_Pre_Personalizer { get; set; }
            public string IC_Pre_Perso_Equipment_Date { get; set; }
            public string IC_Pre_Perso_Equipment_ID { get; set; }
            public string IC_Personalizer { get; set; }
            public string IC_Personalization_Date { get; set; }
            public string IC_Perso_Equipment_ID { get; set; }

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
        public static List<Applications> ParseApplications(string data)
        {
            List<Applications> apps = new List<Applications>();
            int index = 0;
            data = data.Replace(" ", "").Replace("-", "");
            while (index < data.Length)
            {
                // Read Tag (1 or more bytes)
                if (index >= data.Length) break;
                
                string length = data.Substring(index, 2);
                if(int.Parse(length, System.Globalization.NumberStyles.HexNumber) * 2 >= data.Length )break;

                index += length.Length;

                string app = data.Substring(index, int.Parse(length, System.Globalization.NumberStyles.HexNumber) * 2);
                index += app.Length;

                string details = data.Substring(index, 4);
                index += details.Length;

                apps.Add(new Applications
                {
                    length = length,
                    app = app,
                    details = details
                });

                string status = data.Substring(index, 4);
                if (status == "9000")
                {
                    break;
                }


            }
            return apps;
        }
        
        public static List<CPLC> ParseCPLC(string data)
        {
            List<CPLC> cplc = new List<CPLC>();
            int index = 0;
            data = data.Replace(" ", "").Replace("-", "");

            while (index < data.Length)
            {
                // Read Tag (1 or more bytes)
                if (index >= data.Length) break;
                string info =data.Substring(index, 6);

                index += info.Length;
                string ic_fabricator = data.Substring(index, 4);
                index += ic_fabricator.Length;

                string ic_type = data.Substring(index, 4);
                index += ic_type.Length;

                string os_id = data.Substring(index, 4);
                index += os_id.Length;

                string os_release_date = data.Substring(index, 4);
                index += os_release_date.Length;

                string os_release_level = data.Substring(index, 4);
                index += os_release_level.Length;

                string ic_fabrication_date = data.Substring(index, 4);
                index += ic_fabrication_date.Length;

                string ic_serial_number = data.Substring(index, 8);
                index += ic_serial_number.Length;

                string ic_batch_identifier = data.Substring(index, 4);
                index += ic_batch_identifier.Length;

                string ic_module_fabricator = data.Substring(index, 4);
                index += ic_module_fabricator.Length;

                string ic_module_packaging_date = data.Substring(index, 4);
                index += ic_module_packaging_date.Length;

                string icc_manufacturer = data.Substring(index, 4);
                index += icc_manufacturer.Length;

                string ic_embedding_date = data.Substring(index, 4);
                index += ic_embedding_date.Length;

                string ic_pre_personalizer = data.Substring(index, 4);
                index += ic_pre_personalizer.Length;

                string ic_pre_perso_equipment_date = data.Substring(index, 4);
                index += ic_pre_perso_equipment_date.Length;

                string ic_pre_perso_equipment_id = data.Substring(index, 8);
                index += ic_pre_perso_equipment_id.Length;

                string ic_personalizer = data.Substring(index, 4);
                index += ic_personalizer.Length;

                string ic_personalization_date = data.Substring(index, 4);
                index += ic_personalization_date.Length;

                string ic_perso_equipment_id = data.Substring(index, 8);
                index += ic_perso_equipment_id.Length;

                string status = data.Substring(index, 4);
                index += status.Length;
                if (status != "9000")
                {
                    MessageBox.Show($"CPLC Error: {status}");
                    break; 
                }

                cplc.Add(new CPLC
                {
                    IC_Fabricator = ic_fabricator,
                    IC_Type = ic_type,
                    OS_ID = os_id,
                    OS_release_date = os_release_date,
                    OS_release_level= os_release_level,
                    IC_Fabrication_Date = ic_fabrication_date,
                    IC_Serial_Number = ic_serial_number,
                    IC_Batch_Identifier = ic_batch_identifier,
                    IC_Module_Fabricator = ic_module_fabricator,
                    IC_Module_Packaging_Date = ic_module_packaging_date,
                    ICC_Manufacturer = icc_manufacturer,
                    IC_Embedding_Date = ic_embedding_date,
                    IC_Pre_Personalizer = ic_pre_personalizer,
                    IC_Pre_Perso_Equipment_Date = ic_pre_perso_equipment_date,
                    IC_Pre_Perso_Equipment_ID = ic_pre_perso_equipment_id,
                    IC_Personalizer = ic_personalizer,
                    IC_Personalization_Date = ic_personalization_date,
                    IC_Perso_Equipment_ID = ic_perso_equipment_id

                });

            }


            return cplc;
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
