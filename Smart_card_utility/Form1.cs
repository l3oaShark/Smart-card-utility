using Encryptions;
using MaterialSkin;
using MaterialSkin.Controls;
using Public_key_certification_processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartCard;
using static SmartCard.TlvParser;

namespace Smart_card_utility
{
    public partial class Main : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public string filepki;
        public string fileINP;
        //string customFilter;
        //string baseFilter = "Text files (*.txt;*.enc)|*.txt;*.enc";
        //string allFilter = "All files (*.*)|*.*";


        string customDesc = "Custom files (*.kekexp;*.inp)";
        string customPattern = "*.kekexp;*.inp";

        string baseDesc = "Text files (*.txt;*.enc)";
        string basePattern = "*.txt;*.enc";

        string allDesc = "All files (*.*)";
        string allPattern = "*.*";

        public Properties_Files pkiFile = new Properties_Files();
        public Properties_Files inpFile = new Properties_Files();

        StringBuilder sb_message = new StringBuilder();


        private IntPtr hContext = IntPtr.Zero;
        private SmartCardManager smart_card = new SmartCardManager();
        private IntPtr hCard = IntPtr.Zero;

        Utils.CryptoMode cryptoMode;
        public Main()
        {
            InitializeComponent();
            hContext = smart_card.EstablishContext();
            LoadReadersToComboBox();
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500, Primary.Indigo700,
                Primary.Indigo100, Accent.Pink200,
                TextShade.WHITE
            );
            btn_openfileAPDU.Hide();

            if (cbb_aesEncMode.SelectedIndex == 0) // ECB
            {
                txt_ivAES.Enabled = false;
                cryptoMode = Utils.CryptoMode.ECB;
            }

            else if (cbb_aesEncMode.SelectedIndex > 0) // CBC    
            {
                txt_ivAES.Enabled = true;
                cryptoMode = Utils.CryptoMode.CBC;

            }

            if (cbb_desMode.Text == "ECB")
            {
                txt_DESIV.Enabled = false;
                txt_DESIV.Text = string.Empty;
                cryptoMode = Utils.CryptoMode.ECB;

            }
            else if (cbb_desMode.Text == "CBC") // CBC
            {
                txt_DESIV.Enabled = true;
                cryptoMode = Utils.CryptoMode.CBC;

            }
            cbb_kmcValue1.Visible = true;
            txt_kmcKCV1.Visible = true;

            cbb_kmcValue2.Visible = false;
            txt_kmcKCV2.Visible = false;

            cbb_kmcValue3.Visible = false;
            txt_kmcKCV3.Visible = false;
        }
        private void LoadReadersToComboBox()
        {
            var readerList = SmartCardManager.GetSmartCardReaders();
            cbb_cardReader1.Items.Clear();
            cbb_cardReader2.Items.Clear();
            cbb_cardReader3.Items.Clear();

            if (readerList.Count > 0)
            {
                cbb_cardReader1.Items.AddRange(readerList.ToArray());
                cbb_cardReader2.Items.AddRange(readerList.ToArray());
                cbb_cardReader3.Items.AddRange(readerList.ToArray());

                cbb_cardReader1.SelectedIndex = 0;
                cbb_cardReader2.SelectedIndex = 0;
                cbb_cardReader3.SelectedIndex = 0;
            }
            //else
            //{
            //    MessageBox.Show("Not found Smartcard Reader");
            //}
        }
        private bool IsHexChar(char c)
        {
            return (c >= '0' && c <= '9') ||
                   (c >= 'A' && c <= 'F') ||
                   (c >= 'a' && c <= 'f');
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (username == "admin" && password == "1234")
                MessageBox.Show("Login successful!");
            else
                MessageBox.Show("Invalid credentials");
        }

        private void darkModeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = darkModeSwitch.Checked
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
            if (cbb_system.Text == "NBS")
            {
                OpenFile1.Text = "Open File .IPK";
                Openfile2.Text = "Open File .INP";
                //customFilter = "Custom files (*.pki;*.inp)|*.pki;*.inp";
                customDesc = "Custom files (*.pki;*.inp)";
                customPattern = "*.pki;*.inp";
            }
            else if (cbb_system.Text == "Smart CPS v1")
            {
                OpenFile1.Text = "Open File .kekexp";
                Openfile2.Text = "Open File .INP";
                customDesc = "Custom files (*.kekexp;*.inp)";
                customPattern = "*.kekexp;*.inp";
            }
            else if (cbb_system.Text == "Smart CPS v2")
            {
                OpenFile1.Text = "Open File .kekexp";
                Openfile2.Text = "Open File .INP";
                customDesc = "Custom files (*.kekexp;*.inp)";
                customPattern = "*.kekexp;*.inp";
            }
        }

        private void verify_Click(object sender, EventArgs e)
        {
            PublicKeyProcessor processor = new PublicKeyProcessor();
            if (cbb_system.Text == "NBS")
            {
                List<NBSCompareResults> compareResults = processor.NBSComparePkiInp(pkiFile, inpFile);
                dt_gv.DataSource = compareResults;
            }
            else if (cbb_system.Text == "Smart CPS v1")
            {
                List<NBSCompareResults> compareResults = processor.CPSv1ComparePkiInp(pkiFile, inpFile);
                dt_gv.DataSource = compareResults;
            }
            else if (cbb_system.Text == "Smart CPS v2")
            {

            }

        }
        private List<Properties_Files> allFiles = new List<Properties_Files>();

        private void RefreshGridView()
        {
            dt_gv.AutoGenerateColumns = true;
            dt_gv.DataSource = null;
            dt_gv.DataSource = allFiles;
        }
        private void OpenFile1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //openFileDialog.Filter = $"{customFilter}|{baseFilter}|{allFilter}";
                openFileDialog.Filter = $"{customDesc}|{customPattern}|{baseDesc}|{basePattern}|{allDesc}|{allPattern}";
                openFileDialog.Title = "Select Public Key Data File";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    filepki = openFileDialog.FileName;
                    if (cbb_system.Text == "NBS")
                    {
                        pkiFile = PublicKeyProcessor.LoadFromTextFileNBSPki(filepki);
                    }
                    else if (cbb_system.Text == "Smart CPS v1")
                    {
                        pkiFile = PublicKeyProcessor.LoadFromTextFileSmartCPSv1Pki(filepki);
                    }
                    else if (cbb_system.Text == "Smart CPS v2")
                    {

                    }

                    if (pkiFile != null)
                    {
                        allFiles.Add(pkiFile);
                        RefreshGridView();
                    }
                }
            }
        }

        private void Openfile2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //openFileDialog.Filter = "Text files (*.txt;*.enc)|*.txt;*.enc|All files (*.*)|*.*";
                openFileDialog.Filter = $"{customDesc}|{customPattern}|{baseDesc}|{basePattern}|{allDesc}|{allPattern}";
                openFileDialog.Title = "Select Public Key Data File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    fileINP = openFileDialog.FileName;
                    inpFile = PublicKeyProcessor.LoadFromTextFileINP(fileINP);
                    if (inpFile != null)
                    {
                        allFiles.Add(inpFile);
                        RefreshGridView();
                    }
                }
            }
        }
        private void dt_gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;
            if (dt_gv.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();

                switch (status)
                {
                    case "Matched":
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "Unmatched":
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "Only pki":
                        e.CellStyle.BackColor = Color.LightGoldenrodYellow;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case "Only inp":
                        e.CellStyle.BackColor = Color.LightYellow;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    default:
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }


        private void cbb_system_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_system.Text == "NBS")
            {
                OpenFile1.Text = "Open File .IPK";
                Openfile2.Text = "Open File .INP";
                customDesc = "Custom files (*.pki;*.inp)";
                customPattern = "*.pki;*.inp";
            }
            else if (cbb_system.Text == "Smart CPS v1")
            {
                OpenFile1.Text = "Open File .kekexe";
                Openfile2.Text = "Open File .INP";
                customDesc = "Custom files (*.kekexe;*.inp)";
                customPattern = "*.kekexe;*.inp";
            }
            else if (cbb_system.Text == "Smart CPS v2")
            {
                OpenFile1.Text = "Open File .kekexe";
                Openfile2.Text = "Open File .INP";
                customDesc = "Custom files (*.kekexe;*.inp)";
                customPattern = "*.kekexe;*.inp";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dt_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        private void btn_AEScmac_Click(object sender, EventArgs e)
        {
            try
            {
                txt_AESencrypt.Text = AesHelper.GetAesCmac(txt_AESCleardata.Text.Trim(), txt_valueAES.Text.Trim(), txt_ivAES.Text.Trim(), cbb_aesEncMode.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_getATR_Click(object sender, EventArgs e)
        {
            if (hCard != IntPtr.Zero)
            {
                byte[] atrBytes = SmartCardManager.GetCardATR(hCard);

                if (atrBytes != null)
                {
                    string atrHex = BitConverter.ToString(atrBytes).Replace("-", " ");
                    txt_getATR.Text = atrHex;
                }
                else
                {
                    MessageBox.Show("Can't read ATR.");
                }
            }
        }

        private void cbb_typeAPDU_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbb_typeAPDU.SelectedIndex == 1)//Batch *.jcsh Script
            {
                btn_openfileAPDU.Show();
            }
            else
            {
                btn_openfileAPDU.Hide();
            }

        }

        private void btn_powerOn_Click(object sender, EventArgs e)
        {
            enableButton(true);
            if (cbb_cardReader1.SelectedItem != null)
            {
                hCard = SmartCardManager.PowerOnCard(hContext, cbb_cardReader1.SelectedItem.ToString(), out _);
            }
        }

        private void btn_powerOff_Click(object sender, EventArgs e)
        {

            if (hCard != IntPtr.Zero)
            {
                enableButton(false);
                SmartCardManager.PowerOffCard(hCard);
            }

        }
        void enableButton(bool enable)
        {
            btn_powerOn.Enabled = !enable;
            cbb_cardReader1.Enabled = !enable;

            btn_powerOff.Enabled = enable;
            btn_getATR.Enabled = enable;
            btn_openfileAPDU.Enabled = enable;
            btn_getsn.Enabled = enable;

        }

        private void btn_getsn_Click(object sender, EventArgs e)
        {
            byte[] serialNumber = SmartCardManager.GetCardSerialNumber(cbb_cardReader1.SelectedItem.ToString());

            if (serialNumber != null)
            {
                string snHex = BitConverter.ToString(serialNumber).Replace("-", " ");
                txt_serialNumber.Text = snHex;
            }
            else
            {
                MessageBox.Show("Can't read Serial Number.");
            }
        }
        private void btn_execuetAPDU_Click(object sender, EventArgs e)
        {

            if (txt_APDU.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter APDU command.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string readerName = cbb_cardReader1.SelectedItem?.ToString();
                byte[] apdu = HexStringToByteArray(txt_APDU.Text.Trim());

                byte[] response = ApduHelper.TransmitApduCommand(readerName, apdu);
                byte[] dataOnly = response.Take(response.Length - 2).ToArray();
                string hex = BitConverter.ToString(response).Replace("-", " ");


                sb_message.Append("[" + DateTime.Now.ToString() + "]   Send           " + txt_APDU.Text.Trim() + "\n");
                sb_message.Append("[" + DateTime.Now.ToString() + "]   Received           " + hex + "\n");

                List<TLV> tlvList = TlvParser.ParseTlv(dataOnly);
                foreach (var tlv in tlvList)
                {
                    sb_message.Append("[" + DateTime.Now.ToString() + "]   Received           " + tlv + "\n");
                }

                txt_message.Text = sb_message.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "APDU Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private byte[] HexStringToByteArray(string hex)
        {
            hex = hex.Replace(" ", "").Replace("-", "");
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        private void btn_getKCV_Click(object sender, EventArgs e)
        {
            try
            {
                //byte[] keybyte = Encoding.UTF8.GetBytes(txt_valueAES.Text);
                //AesHelper.ValidateKey(keybyte);
                var result_byte = AesHelper.GetKCV(txt_valueAES.Text, cbb_aesEncMode.Text);

                txt_AESKcv.Text = result_byte;
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_aesEncMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_aesEncMode.SelectedIndex == 0) // ECB
            {
                txt_ivAES.Enabled = false;
                txt_ivAES.Text = string.Empty;

            }

            else
            {
                txt_ivAES.Enabled = true;
            }
        }

        private void btn_AESencrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txt_AESencrypt.Text = AesHelper.Encrypt(txt_AESCleardata.Text.Trim(), txt_valueAES.Text.Trim(), txt_ivAES.Text.Trim(), cbb_aesEncMode.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AESdecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txt_AESCleardata.Text = AesHelper.Decrypt(txt_AESencrypt.Text.Trim(), txt_valueAES.Text.Trim(), txt_ivAES.Text.Trim(), cbb_aesEncMode.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_desMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_desMode.Text == "ECB")
            {
                txt_DESIV.Enabled = false;
                txt_DESIV.Text = string.Empty;
                cryptoMode = Utils.CryptoMode.ECB;

            }
            else
            {
                txt_DESIV.Enabled = true;
                cryptoMode = Utils.CryptoMode.CBC;

            }
        }

        private void btn_DesOddParity_Click(object sender, EventArgs e)
        {
            try
            {
                txt_DESValue.Text = DesHelper.SetOddParity(txt_DESValue.Text.Trim());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DESGetKcv_Click(object sender, EventArgs e)
        {
            try
            {
                txt_DESKCV.Text = DesHelper.GetKCV(txt_DESValue.Text.Trim());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DesEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txt_DESEncryptData.Text = DesHelper.Encrypt(txt_DESValue.Text, txt_DESClearData.Text, cryptoMode, txt_DESIV.Text);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DesDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txt_DESClearData.Text = DesHelper.Decrypt(txt_DESValue.Text, txt_DESEncryptData.Text, cryptoMode, txt_DESIV.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DesXOR_Click(object sender, EventArgs e)
        {
            if (txt_DesInputdata1.Text != string.Empty && txt_DesInputdata2.Text != string.Empty && txt_DesInputdata3.Text != string.Empty)
            {
                var result = DesHelper.XorThreeKeys(txt_DesInputdata1.Text, txt_DesInputdata2.Text, txt_DesInputdata3.Text);
                txt_DesResultXOR.Text = result.xorKey;
                txt_DesKCVResultXOR.Text = result.kcv;
            }
            else
            {
                MessageBox.Show("Please enter all three keys to perform XOR operation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_DesInputdata1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsControl(c) && !IsHexChar(c))
            {
                e.Handled = true;
            }
            try
            {
                if (txt_DesInputdata1.Text.Length == 32 || txt_DesInputdata1.Text.Length == 48)
                {
                    txt_DESKcvInput1.Text = DesHelper.GetKCV(txt_DesInputdata1.Text);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_DesInputdata2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsControl(c) && !IsHexChar(c))
            {
                e.Handled = true;
            }

            try
            {
                if (txt_DesInputdata2.Text.Length == 32 || txt_DesInputdata2.Text.Length == 48)
                {
                    txt_DESKcvInput2.Text = DesHelper.GetKCV(txt_DesInputdata2.Text);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_DesInputdata3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsControl(c) && !IsHexChar(c))
            {
                e.Handled = true;
            }
            try
            {
                if (txt_DesInputdata3.Text.Length == 32 || txt_DesInputdata3.Text.Length == 48)
                {
                    txt_DESKcvInput3.Text = DesHelper.GetKCV(txt_DesInputdata3.Text);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_DesInputdata1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DesInputdata1.SelectionStart;
            txt_DesInputdata1.Text = txt_DesInputdata1.Text.ToUpper();
            txt_DesInputdata1.SelectionStart = selectionStart;
        }

        private void txt_DesInputdata2_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DesInputdata2.SelectionStart;
            txt_DesInputdata2.Text = txt_DesInputdata2.Text.ToUpper();
            txt_DesInputdata2.SelectionStart = selectionStart;
        }

        private void txt_DesInputdata3_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DesInputdata3.SelectionStart;
            txt_DesInputdata3.Text = txt_DesInputdata3.Text.ToUpper();
            txt_DesInputdata3.SelectionStart = selectionStart;
        }

        private void txt_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                sb_message.Clear();
                txt_message.Clear();

            }
        }

        private void txt_AESKcv_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar = char.ToUpper(e.KeyChar);

            //if (txt_AESKcv.Text.Length >= 6 && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    return;
            //}

            //if (!Uri.IsHexDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txt_AESKcv_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_AESKcv.SelectionStart;
            txt_AESKcv.Text = txt_AESKcv.Text.ToUpper();
            txt_AESKcv.SelectionStart = selectionStart;
        }

        private void txt_DESKCV_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DESKCV.SelectionStart;
            txt_DESKCV.Text = txt_DESKCV.Text.ToUpper();
            txt_DESKCV.SelectionStart = selectionStart;
        }

        private void txt_kmcKCV1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_kmcKCV1.SelectionStart;
            txt_kmcKCV1.Text = txt_kmcKCV1.Text.ToUpper();
            txt_kmcKCV1.SelectionStart = selectionStart;
        }

        private void txt_kmcKCV2_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_kmcKCV2.SelectionStart;
            txt_kmcKCV2.Text = txt_kmcKCV2.Text.ToUpper();
            txt_kmcKCV2.SelectionStart = selectionStart;
        }

        private void txt_kmcKCV3_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_kmcKCV3.SelectionStart;
            txt_kmcKCV3.Text = txt_kmcKCV3.Text.ToUpper();
            txt_kmcKCV3.SelectionStart = selectionStart;
        }

        private void txt_APDU_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_APDU.SelectionStart;
            txt_APDU.Text = txt_APDU.Text.ToUpper();
            txt_APDU.SelectionStart = selectionStart;
        }

        private void txt_DESKcvInput1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DESKcvInput1.SelectionStart;
            txt_DESKcvInput1.Text = txt_DESKcvInput1.Text.ToUpper();
            txt_DESKcvInput1.SelectionStart = selectionStart;
        }

        private void txt_DESKcvInput2_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DESKcvInput2.SelectionStart;
            txt_DESKcvInput2.Text = txt_DESKcvInput2.Text.ToUpper();
            txt_DESKcvInput2.SelectionStart = selectionStart;
        }

        private void txt_DESKcvInput3_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DESKcvInput3.SelectionStart;
            txt_DESKcvInput3.Text = txt_DESKcvInput3.Text.ToUpper();
            txt_DESKcvInput3.SelectionStart = selectionStart;
        }

        private void txt_DesKCVResultXOR_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_DesKCVResultXOR.SelectionStart;
            txt_DesKCVResultXOR.Text = txt_DesKCVResultXOR.Text.ToUpper();
            txt_DesKCVResultXOR.SelectionStart = selectionStart;
        }

        private void txt_old_kmc_kcv1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_old_kmc_kcv1.SelectionStart;
            txt_old_kmc_kcv1.Text = txt_old_kmc_kcv1.Text.ToUpper();
            txt_old_kmc_kcv1.SelectionStart = selectionStart;
        }

        private void txt_old_kmc_kcv2_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_old_kmc_kcv2.SelectionStart;
            txt_old_kmc_kcv2.Text = txt_old_kmc_kcv2.Text.ToUpper();
            txt_old_kmc_kcv2.SelectionStart = selectionStart;
        }

        private void txt_old_kmc_kcv3_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_old_kmc_kcv3.SelectionStart;
            txt_old_kmc_kcv3.Text = txt_old_kmc_kcv3.Text.ToUpper();
            txt_old_kmc_kcv3.SelectionStart = selectionStart;
        }

        private void txt_new_kmc_kcv1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_new_kmc_kcv1.SelectionStart;
            txt_new_kmc_kcv1.Text = txt_new_kmc_kcv1.Text.ToUpper();
            txt_new_kmc_kcv1.SelectionStart = selectionStart;
        }

        private void txt_new_kmc_kcv2_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_new_kmc_kcv2.SelectionStart;
            txt_new_kmc_kcv2.Text = txt_new_kmc_kcv2.Text.ToUpper();
            txt_new_kmc_kcv2.SelectionStart = selectionStart;
        }

        private void txt_new_kmc_kcv3_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_new_kmc_kcv3.SelectionStart;
            txt_new_kmc_kcv3.Text = txt_new_kmc_kcv3.Text.ToUpper();
            txt_new_kmc_kcv3.SelectionStart = selectionStart;
        }

        private void txt_ATR_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_ATR.SelectionStart;
            txt_ATR.Text = txt_ATR.Text.ToUpper();
            txt_ATR.SelectionStart = selectionStart;
        }

        private void btn_cardInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_deriveKMC.Checked)
                {
                    if (cbb_cardReader2.SelectedItem != null)
                    {
                        hCard = SmartCardManager.PowerOnCard(hContext, cbb_cardReader2.SelectedItem.ToString(), out _);
                    }

                    var (cardInfo, aid, atr) = SmartCardInfo.ReadCardInfo(
                    cbb_cardReader2.Text,
                    cbb_kmcValue1.Text,
                    HexStringToByteArray(txt_kmcKCV1.Text)
                     );
                    txt_ATR.Text = atr;
                    //txt_AID.Text = aid;

                    if (cardInfo != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (var kvp in cardInfo)
                        {
                            sb.AppendLine($"Length: {kvp.legnth}, Value: {kvp.value}, Package: {kvp.package}");
                            if (kvp.applete != null)
                            {
                                foreach (var app in kvp.applete)
                                {
                                    sb.AppendLine($"Applet: {app}");
                                }
                            }
                            sb.AppendLine("\n");
                        }

                        txt_cardInfo.Text = sb.ToString();
                    }

                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูล card info หรืออ่านล้มเหลว");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rdb_deriveKMC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_deriveKMC.Checked)
            {
                rdb_fixedENC.Checked = false;
                rdb_noKMC.Checked = false;

                cbb_kmcValue1.Visible = true;
                txt_kmcKCV1.Visible = true;

                cbb_kmcValue2.Visible = false;
                txt_kmcKCV2.Visible = false;

                cbb_kmcValue3.Visible = false;
                txt_kmcKCV3.Visible = false;
            }


        }

        private void rdb_fixedENC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_fixedENC.Checked)
            {
                rdb_deriveKMC.Checked = false;
                rdb_noKMC.Checked = false;

                cbb_kmcValue1.Visible = true;
                txt_kmcKCV1.Visible = true;

                cbb_kmcValue2.Visible = true;
                txt_kmcKCV2.Visible = true;

                cbb_kmcValue3.Visible = false;
                txt_kmcKCV3.Visible = false;
            }


        }

        private void rdb_noKMC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_noKMC.Checked)
            {
                rdb_fixedENC.Checked = false;
                rdb_deriveKMC.Checked = false;

                cbb_kmcValue1.Visible = false;
                txt_kmcKCV1.Visible = false;

                cbb_kmcValue2.Visible = false;
                txt_kmcKCV2.Visible = false;

                cbb_kmcValue3.Visible = false;
                txt_kmcKCV3.Visible = false;
            }
        }
    }

}