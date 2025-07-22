using System.Drawing;
using System.Windows.Forms;

namespace Smart_card_utility
{
    partial class Main
    {
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialSwitch darkModeSwitch;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.darkModeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.verify = new MaterialSkin.Controls.MaterialButton();
            this.OpenFile1 = new MaterialSkin.Controls.MaterialButton();
            this.Openfile2 = new MaterialSkin.Controls.MaterialButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dt_gv = new System.Windows.Forms.DataGridView();
            this.cbb_system = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_message = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_openfileAPDU = new MaterialSkin.Controls.MaterialButton();
            this.btn_execuetAPDU = new MaterialSkin.Controls.MaterialButton();
            this.txt_APDU = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cbb_typeAPDU = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_getATR = new MaterialSkin.Controls.MaterialButton();
            this.txt_getATR = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_getsn = new MaterialSkin.Controls.MaterialButton();
            this.txt_serialNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_powerOff = new MaterialSkin.Controls.MaterialButton();
            this.btn_powerOn = new MaterialSkin.Controls.MaterialButton();
            this.cbb_cardReader1 = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tv_card = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AID = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ICPersoEquipID = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICFabricator = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICPersoDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_osRelease_date = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICPersonalizer = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_osRelease_level = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_PrePersoEqp = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_IC_batchIdentifier = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_PrePersoDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_icSerailnumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICPrePersonalizer = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_osIdentifier = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICMPDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICFabricatorDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICEmbeddingDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICType = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICCManufacturer = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ICMod = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_ATR = new MaterialSkin.Controls.MaterialTextBox();
            this.cbb_cardManager = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_extAuth = new MaterialSkin.Controls.MaterialButton();
            this.btn_appDelete = new MaterialSkin.Controls.MaterialButton();
            this.btn_cardInfo = new MaterialSkin.Controls.MaterialButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdb_noKMC = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb_fixedENC = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb_deriveKMC = new MaterialSkin.Controls.MaterialRadioButton();
            this.txt_kmcKCV3 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_kmcKCV2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_kmcKCV1 = new MaterialSkin.Controls.MaterialTextBox();
            this.cbb_kmcValue3 = new MaterialSkin.Controls.MaterialComboBox();
            this.cbb_kmcValue2 = new MaterialSkin.Controls.MaterialComboBox();
            this.cbb_kmcValue1 = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_readerRefresh = new MaterialSkin.Controls.MaterialButton();
            this.cbb_cardReader2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rdo_new_kmc_fixed = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdo_new_derive_kmc = new MaterialSkin.Controls.MaterialRadioButton();
            this.txt_new_kmc_kcv3 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_new_kmc_kcv2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_new_kmc_kcv1 = new MaterialSkin.Controls.MaterialTextBox();
            this.cbb_new_no_kmc = new MaterialSkin.Controls.MaterialComboBox();
            this.cbb_new_kmc_fixed = new MaterialSkin.Controls.MaterialComboBox();
            this.cbb_new_kmc_key = new MaterialSkin.Controls.MaterialComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdo_old_no_kmc = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdo_old_kmc_fixed = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdo_old_derive_kmc = new MaterialSkin.Controls.MaterialRadioButton();
            this.txt_old_kmc_kcv3 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_old_kmc_kcv2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_old_kmc_kcv1 = new MaterialSkin.Controls.MaterialTextBox();
            this.cbb_old_no_kmc = new MaterialSkin.Controls.MaterialComboBox();
            this.cbb_old_kmc_fixed = new MaterialSkin.Controls.MaterialComboBox();
            this.cbb_old_kmc_key = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_updateCardmanager = new MaterialSkin.Controls.MaterialButton();
            this.txt_processMessage = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cbb_cardmanager2 = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_refresh2 = new MaterialSkin.Controls.MaterialButton();
            this.cbb_cardReader3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txt_AESKcv = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_getKCV = new MaterialSkin.Controls.MaterialButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbb_aesEncMode = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_ivAES = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.rdb_defualtZMK = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb_defualtLMK = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb_clearAES = new MaterialSkin.Controls.MaterialRadioButton();
            this.txt_valueAES = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_AESencrypt = new MaterialSkin.Controls.MaterialButton();
            this.btn_AEScmac = new MaterialSkin.Controls.MaterialButton();
            this.btn_AESdecrypt = new MaterialSkin.Controls.MaterialButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txt_AESCleardata = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txt_AESencrypt = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_DesInputdata1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_DesInputdata2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_DesInputdata3 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_DesResultXOR = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_DESKcvInput1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_DESKcvInput2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_DESKcvInput3 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_DesKCVResultXOR = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_DesXOR = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.btn_DesOddParity = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.rdb_DESDafualtZMK = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb_DESDafualtLMK = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb_DESClear = new MaterialSkin.Controls.MaterialRadioButton();
            this.txt_DESValue = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txt_DESKCV = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_DESGetKcv = new MaterialSkin.Controls.MaterialButton();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbb_desMode = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_DESIV = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_DesDecrypt = new MaterialSkin.Controls.MaterialButton();
            this.btn_DesEncrypt = new MaterialSkin.Controls.MaterialButton();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txt_DESClearData = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txt_DESEncryptData = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(699, 115);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 50);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(699, 165);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(280, 50);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(700, 243);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(64, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // darkModeSwitch
            // 
            this.darkModeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.darkModeSwitch.Depth = 0;
            this.darkModeSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkModeSwitch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.darkModeSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.darkModeSwitch.Location = new System.Drawing.Point(4, 79);
            this.darkModeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.darkModeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkModeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkModeSwitch.Name = "darkModeSwitch";
            this.darkModeSwitch.Ripple = true;
            this.darkModeSwitch.Size = new System.Drawing.Size(1364, 37);
            this.darkModeSwitch.TabIndex = 3;
            this.darkModeSwitch.Text = "Dark Mode";
            this.darkModeSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.darkModeSwitch.UseVisualStyleBackColor = false;
            this.darkModeSwitch.CheckedChanged += new System.EventHandler(this.darkModeSwitch_CheckedChanged);
            // 
            // verify
            // 
            this.verify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.verify.Depth = 0;
            this.verify.HighEmphasis = true;
            this.verify.Icon = null;
            this.verify.Location = new System.Drawing.Point(1279, 9);
            this.verify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.verify.MouseState = MaterialSkin.MouseState.HOVER;
            this.verify.Name = "verify";
            this.verify.NoAccentTextColor = System.Drawing.Color.Empty;
            this.verify.Size = new System.Drawing.Size(70, 36);
            this.verify.TabIndex = 5;
            this.verify.Text = "Verify";
            this.verify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.verify.UseAccentColor = false;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // OpenFile1
            // 
            this.OpenFile1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenFile1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenFile1.Depth = 0;
            this.OpenFile1.HighEmphasis = true;
            this.OpenFile1.Icon = null;
            this.OpenFile1.Location = new System.Drawing.Point(249, 9);
            this.OpenFile1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenFile1.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenFile1.Name = "OpenFile1";
            this.OpenFile1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenFile1.Size = new System.Drawing.Size(92, 36);
            this.OpenFile1.TabIndex = 6;
            this.OpenFile1.Text = "Open file";
            this.OpenFile1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenFile1.UseAccentColor = false;
            this.OpenFile1.Click += new System.EventHandler(this.OpenFile1_Click);
            // 
            // Openfile2
            // 
            this.Openfile2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Openfile2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Openfile2.Depth = 0;
            this.Openfile2.HighEmphasis = true;
            this.Openfile2.Icon = null;
            this.Openfile2.Location = new System.Drawing.Point(470, 9);
            this.Openfile2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Openfile2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Openfile2.Name = "Openfile2";
            this.Openfile2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Openfile2.Size = new System.Drawing.Size(92, 36);
            this.Openfile2.TabIndex = 9;
            this.Openfile2.Text = "Open file";
            this.Openfile2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Openfile2.UseAccentColor = false;
            this.Openfile2.Click += new System.EventHandler(this.Openfile2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem1.Text = "copy";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(79, 27);
            this.materialTabControl1.Location = new System.Drawing.Point(4, 116);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1364, 830);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dt_gv);
            this.tabPage1.Controls.Add(this.cbb_system);
            this.tabPage1.Controls.Add(this.Openfile2);
            this.tabPage1.Controls.Add(this.verify);
            this.tabPage1.Controls.Add(this.OpenFile1);
            this.tabPage1.ImageKey = "compare.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1356, 795);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compare Issuer public key";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dt_gv
            // 
            this.dt_gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_gv.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dt_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_gv.Location = new System.Drawing.Point(7, 63);
            this.dt_gv.Name = "dt_gv";
            this.dt_gv.RowHeadersWidth = 51;
            this.dt_gv.RowTemplate.Height = 24;
            this.dt_gv.Size = new System.Drawing.Size(1343, 726);
            this.dt_gv.TabIndex = 13;
            this.dt_gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_gv_CellContentClick);
            this.dt_gv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dt_gv_CellFormatting);
            // 
            // cbb_system
            // 
            this.cbb_system.AutoResize = false;
            this.cbb_system.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_system.Depth = 0;
            this.cbb_system.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_system.DropDownHeight = 174;
            this.cbb_system.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_system.DropDownWidth = 121;
            this.cbb_system.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_system.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_system.FormattingEnabled = true;
            this.cbb_system.Hint = "System";
            this.cbb_system.IntegralHeight = false;
            this.cbb_system.ItemHeight = 43;
            this.cbb_system.Items.AddRange(new object[] {
            "NBS",
            "Smart CPS v1",
            "Smart CPS v2"});
            this.cbb_system.Location = new System.Drawing.Point(7, 7);
            this.cbb_system.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_system.MaxDropDownItems = 4;
            this.cbb_system.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_system.Name = "cbb_system";
            this.cbb_system.Size = new System.Drawing.Size(220, 49);
            this.cbb_system.StartIndex = 0;
            this.cbb_system.TabIndex = 10;
            this.cbb_system.UseAccent = false;
            this.cbb_system.SelectedIndexChanged += new System.EventHandler(this.cbb_system_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ImageKey = "smartcard_reader.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1356, 795);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PC/SC Reader";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_message);
            this.groupBox3.Location = new System.Drawing.Point(3, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1347, 343);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // txt_message
            // 
            this.txt_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_message.Depth = 0;
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_message.Location = new System.Drawing.Point(6, 21);
            this.txt_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_message.Name = "txt_message";
            this.txt_message.ReadOnly = true;
            this.txt_message.Size = new System.Drawing.Size(1330, 316);
            this.txt_message.TabIndex = 0;
            this.txt_message.Text = "";
            this.txt_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_message_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_openfileAPDU);
            this.groupBox2.Controls.Add(this.btn_execuetAPDU);
            this.groupBox2.Controls.Add(this.txt_APDU);
            this.groupBox2.Controls.Add(this.cbb_typeAPDU);
            this.groupBox2.Location = new System.Drawing.Point(6, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1343, 244);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "APDU Commands";
            // 
            // btn_openfileAPDU
            // 
            this.btn_openfileAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_openfileAPDU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_openfileAPDU.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_openfileAPDU.Depth = 0;
            this.btn_openfileAPDU.HighEmphasis = true;
            this.btn_openfileAPDU.Icon = null;
            this.btn_openfileAPDU.Location = new System.Drawing.Point(1129, 24);
            this.btn_openfileAPDU.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_openfileAPDU.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_openfileAPDU.Name = "btn_openfileAPDU";
            this.btn_openfileAPDU.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_openfileAPDU.Size = new System.Drawing.Size(92, 36);
            this.btn_openfileAPDU.TabIndex = 12;
            this.btn_openfileAPDU.Text = "open file";
            this.btn_openfileAPDU.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_openfileAPDU.UseAccentColor = false;
            this.btn_openfileAPDU.UseVisualStyleBackColor = true;
            // 
            // btn_execuetAPDU
            // 
            this.btn_execuetAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_execuetAPDU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_execuetAPDU.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_execuetAPDU.Depth = 0;
            this.btn_execuetAPDU.HighEmphasis = true;
            this.btn_execuetAPDU.Icon = null;
            this.btn_execuetAPDU.Location = new System.Drawing.Point(1252, 24);
            this.btn_execuetAPDU.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_execuetAPDU.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_execuetAPDU.Name = "btn_execuetAPDU";
            this.btn_execuetAPDU.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_execuetAPDU.Size = new System.Drawing.Size(84, 36);
            this.btn_execuetAPDU.TabIndex = 10;
            this.btn_execuetAPDU.Text = "Execute";
            this.btn_execuetAPDU.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_execuetAPDU.UseAccentColor = false;
            this.btn_execuetAPDU.UseVisualStyleBackColor = true;
            this.btn_execuetAPDU.Click += new System.EventHandler(this.btn_execuetAPDU_Click);
            // 
            // txt_APDU
            // 
            this.txt_APDU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_APDU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_APDU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_APDU.Depth = 0;
            this.txt_APDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_APDU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_APDU.Location = new System.Drawing.Point(16, 78);
            this.txt_APDU.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_APDU.Name = "txt_APDU";
            this.txt_APDU.Size = new System.Drawing.Size(1320, 160);
            this.txt_APDU.TabIndex = 11;
            this.txt_APDU.Text = "";
            this.txt_APDU.TextChanged += new System.EventHandler(this.txt_APDU_TextChanged);
            // 
            // cbb_typeAPDU
            // 
            this.cbb_typeAPDU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_typeAPDU.AutoResize = false;
            this.cbb_typeAPDU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_typeAPDU.Depth = 0;
            this.cbb_typeAPDU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_typeAPDU.DropDownHeight = 174;
            this.cbb_typeAPDU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_typeAPDU.DropDownWidth = 121;
            this.cbb_typeAPDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_typeAPDU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_typeAPDU.FormattingEnabled = true;
            this.cbb_typeAPDU.Hint = "APDU TYPE";
            this.cbb_typeAPDU.IntegralHeight = false;
            this.cbb_typeAPDU.ItemHeight = 43;
            this.cbb_typeAPDU.Items.AddRange(new object[] {
            "Single APDU",
            "Batch *.jcsh Script",
            "JCOP 3 P40 Activate,put TK",
            "JCOP 3 P60 Activate,put TK"});
            this.cbb_typeAPDU.Location = new System.Drawing.Point(16, 22);
            this.cbb_typeAPDU.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_typeAPDU.MaxDropDownItems = 4;
            this.cbb_typeAPDU.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_typeAPDU.Name = "cbb_typeAPDU";
            this.cbb_typeAPDU.Size = new System.Drawing.Size(1070, 49);
            this.cbb_typeAPDU.StartIndex = 0;
            this.cbb_typeAPDU.TabIndex = 10;
            this.cbb_typeAPDU.SelectedIndexChanged += new System.EventHandler(this.cbb_typeAPDU_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_getATR);
            this.groupBox1.Controls.Add(this.txt_getATR);
            this.groupBox1.Controls.Add(this.btn_getsn);
            this.groupBox1.Controls.Add(this.txt_serialNumber);
            this.groupBox1.Controls.Add(this.btn_powerOff);
            this.groupBox1.Controls.Add(this.btn_powerOn);
            this.groupBox1.Controls.Add(this.cbb_cardReader1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smart Card Reader";
            // 
            // btn_getATR
            // 
            this.btn_getATR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_getATR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_getATR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_getATR.Depth = 0;
            this.btn_getATR.Enabled = false;
            this.btn_getATR.HighEmphasis = true;
            this.btn_getATR.Icon = null;
            this.btn_getATR.Location = new System.Drawing.Point(1257, 92);
            this.btn_getATR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_getATR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_getATR.Name = "btn_getATR";
            this.btn_getATR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_getATR.Size = new System.Drawing.Size(80, 36);
            this.btn_getATR.TabIndex = 9;
            this.btn_getATR.Text = "Get ATR";
            this.btn_getATR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_getATR.UseAccentColor = false;
            this.btn_getATR.UseVisualStyleBackColor = true;
            this.btn_getATR.Click += new System.EventHandler(this.btn_getATR_Click);
            // 
            // txt_getATR
            // 
            this.txt_getATR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_getATR.AnimateReadOnly = false;
            this.txt_getATR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_getATR.Depth = 0;
            this.txt_getATR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_getATR.Hint = "ATR";
            this.txt_getATR.LeadingIcon = null;
            this.txt_getATR.Location = new System.Drawing.Point(734, 89);
            this.txt_getATR.MaxLength = 50;
            this.txt_getATR.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_getATR.Multiline = false;
            this.txt_getATR.Name = "txt_getATR";
            this.txt_getATR.Size = new System.Drawing.Size(487, 50);
            this.txt_getATR.TabIndex = 7;
            this.txt_getATR.Text = "";
            this.txt_getATR.TrailingIcon = null;
            // 
            // btn_getsn
            // 
            this.btn_getsn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getsn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_getsn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_getsn.Depth = 0;
            this.btn_getsn.Enabled = false;
            this.btn_getsn.HighEmphasis = true;
            this.btn_getsn.Icon = null;
            this.btn_getsn.Location = new System.Drawing.Point(603, 93);
            this.btn_getsn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_getsn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_getsn.Name = "btn_getsn";
            this.btn_getsn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_getsn.Size = new System.Drawing.Size(78, 36);
            this.btn_getsn.TabIndex = 6;
            this.btn_getsn.Text = "Get S/N";
            this.btn_getsn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_getsn.UseAccentColor = false;
            this.btn_getsn.UseVisualStyleBackColor = true;
            this.btn_getsn.Click += new System.EventHandler(this.btn_getsn_Click);
            // 
            // txt_serialNumber
            // 
            this.txt_serialNumber.AnimateReadOnly = false;
            this.txt_serialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_serialNumber.Depth = 0;
            this.txt_serialNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_serialNumber.Hint = "S/N";
            this.txt_serialNumber.LeadingIcon = null;
            this.txt_serialNumber.Location = new System.Drawing.Point(16, 91);
            this.txt_serialNumber.MaxLength = 50;
            this.txt_serialNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_serialNumber.Multiline = false;
            this.txt_serialNumber.Name = "txt_serialNumber";
            this.txt_serialNumber.ReadOnly = true;
            this.txt_serialNumber.Size = new System.Drawing.Size(575, 50);
            this.txt_serialNumber.TabIndex = 5;
            this.txt_serialNumber.Text = "";
            this.txt_serialNumber.TrailingIcon = null;
            // 
            // btn_powerOff
            // 
            this.btn_powerOff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_powerOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_powerOff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_powerOff.Depth = 0;
            this.btn_powerOff.Enabled = false;
            this.btn_powerOff.HighEmphasis = true;
            this.btn_powerOff.Icon = null;
            this.btn_powerOff.Location = new System.Drawing.Point(1241, 24);
            this.btn_powerOff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_powerOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_powerOff.Name = "btn_powerOff";
            this.btn_powerOff.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_powerOff.Size = new System.Drawing.Size(102, 36);
            this.btn_powerOff.TabIndex = 3;
            this.btn_powerOff.Text = "Power Off";
            this.btn_powerOff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_powerOff.UseAccentColor = false;
            this.btn_powerOff.UseVisualStyleBackColor = true;
            this.btn_powerOff.Click += new System.EventHandler(this.btn_powerOff_Click);
            // 
            // btn_powerOn
            // 
            this.btn_powerOn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_powerOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_powerOn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_powerOn.Depth = 0;
            this.btn_powerOn.HighEmphasis = true;
            this.btn_powerOn.Icon = null;
            this.btn_powerOn.Location = new System.Drawing.Point(1097, 24);
            this.btn_powerOn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_powerOn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_powerOn.Name = "btn_powerOn";
            this.btn_powerOn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_powerOn.Size = new System.Drawing.Size(96, 36);
            this.btn_powerOn.TabIndex = 2;
            this.btn_powerOn.Text = "Power On";
            this.btn_powerOn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_powerOn.UseAccentColor = false;
            this.btn_powerOn.UseVisualStyleBackColor = true;
            this.btn_powerOn.Click += new System.EventHandler(this.btn_powerOn_Click);
            // 
            // cbb_cardReader1
            // 
            this.cbb_cardReader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_cardReader1.AutoResize = false;
            this.cbb_cardReader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_cardReader1.Depth = 0;
            this.cbb_cardReader1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_cardReader1.DropDownHeight = 174;
            this.cbb_cardReader1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_cardReader1.DropDownWidth = 121;
            this.cbb_cardReader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_cardReader1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_cardReader1.FormattingEnabled = true;
            this.cbb_cardReader1.Hint = "Readers";
            this.cbb_cardReader1.IntegralHeight = false;
            this.cbb_cardReader1.ItemHeight = 43;
            this.cbb_cardReader1.Location = new System.Drawing.Point(16, 21);
            this.cbb_cardReader1.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_cardReader1.MaxDropDownItems = 4;
            this.cbb_cardReader1.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_cardReader1.Name = "cbb_cardReader1";
            this.cbb_cardReader1.Size = new System.Drawing.Size(1044, 49);
            this.cbb_cardReader1.StartIndex = 0;
            this.cbb_cardReader1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tv_card);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txt_AID);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.cbb_cardManager);
            this.tabPage3.Controls.Add(this.btn_extAuth);
            this.tabPage3.Controls.Add(this.btn_appDelete);
            this.tabPage3.Controls.Add(this.btn_cardInfo);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.btn_readerRefresh);
            this.tabPage3.Controls.Add(this.cbb_cardReader2);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.ImageKey = "smartcard.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1356, 795);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SmartCard Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tv_card
            // 
            this.tv_card.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_card.Location = new System.Drawing.Point(797, 26);
            this.tv_card.Name = "tv_card";
            this.tv_card.Size = new System.Drawing.Size(553, 766);
            this.tv_card.TabIndex = 24;
            this.tv_card.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_card_AfterSelect);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Card Info Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "CPLC";
            // 
            // txt_AID
            // 
            this.txt_AID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_AID.AnimateReadOnly = false;
            this.txt_AID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AID.Depth = 0;
            this.txt_AID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AID.Hint = "Application ID (AID)";
            this.txt_AID.LeadingIcon = null;
            this.txt_AID.Location = new System.Drawing.Point(20, 316);
            this.txt_AID.MaxLength = 50;
            this.txt_AID.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_AID.Multiline = false;
            this.txt_AID.Name = "txt_AID";
            this.txt_AID.Size = new System.Drawing.Size(578, 50);
            this.txt_AID.TabIndex = 18;
            this.txt_AID.Text = "";
            this.txt_AID.TrailingIcon = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txt_ICPersoEquipID);
            this.panel1.Controls.Add(this.txt_ICFabricator);
            this.panel1.Controls.Add(this.txt_ICPersoDate);
            this.panel1.Controls.Add(this.txt_osRelease_date);
            this.panel1.Controls.Add(this.txt_ICPersonalizer);
            this.panel1.Controls.Add(this.txt_osRelease_level);
            this.panel1.Controls.Add(this.txt_PrePersoEqp);
            this.panel1.Controls.Add(this.txt_IC_batchIdentifier);
            this.panel1.Controls.Add(this.txt_PrePersoDate);
            this.panel1.Controls.Add(this.txt_icSerailnumber);
            this.panel1.Controls.Add(this.txt_ICPrePersonalizer);
            this.panel1.Controls.Add(this.txt_osIdentifier);
            this.panel1.Controls.Add(this.txt_ICMPDate);
            this.panel1.Controls.Add(this.txt_ICFabricatorDate);
            this.panel1.Controls.Add(this.txt_ICEmbeddingDate);
            this.panel1.Controls.Add(this.txt_ICType);
            this.panel1.Controls.Add(this.txt_ICCManufacturer);
            this.panel1.Controls.Add(this.txt_ICMod);
            this.panel1.Location = new System.Drawing.Point(7, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 316);
            this.panel1.TabIndex = 20;
            // 
            // txt_ICPersoEquipID
            // 
            this.txt_ICPersoEquipID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICPersoEquipID.AnimateReadOnly = false;
            this.txt_ICPersoEquipID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICPersoEquipID.Depth = 0;
            this.txt_ICPersoEquipID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICPersoEquipID.Hint = "IC Perso Equip ID";
            this.txt_ICPersoEquipID.LeadingIcon = null;
            this.txt_ICPersoEquipID.Location = new System.Drawing.Point(124, 534);
            this.txt_ICPersoEquipID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICPersoEquipID.MaxLength = 50;
            this.txt_ICPersoEquipID.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICPersoEquipID.Multiline = false;
            this.txt_ICPersoEquipID.Name = "txt_ICPersoEquipID";
            this.txt_ICPersoEquipID.Size = new System.Drawing.Size(346, 50);
            this.txt_ICPersoEquipID.TabIndex = 35;
            this.txt_ICPersoEquipID.Text = "";
            this.txt_ICPersoEquipID.TrailingIcon = null;
            // 
            // txt_ICFabricator
            // 
            this.txt_ICFabricator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICFabricator.AnimateReadOnly = false;
            this.txt_ICFabricator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICFabricator.Depth = 0;
            this.txt_ICFabricator.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICFabricator.Hint = "IC Fabricator";
            this.txt_ICFabricator.LeadingIcon = null;
            this.txt_ICFabricator.Location = new System.Drawing.Point(13, 16);
            this.txt_ICFabricator.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICFabricator.MaxLength = 50;
            this.txt_ICFabricator.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICFabricator.Multiline = false;
            this.txt_ICFabricator.Name = "txt_ICFabricator";
            this.txt_ICFabricator.Size = new System.Drawing.Size(94, 50);
            this.txt_ICFabricator.TabIndex = 20;
            this.txt_ICFabricator.Text = "";
            this.txt_ICFabricator.TrailingIcon = null;
            // 
            // txt_ICPersoDate
            // 
            this.txt_ICPersoDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICPersoDate.AnimateReadOnly = false;
            this.txt_ICPersoDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICPersoDate.Depth = 0;
            this.txt_ICPersoDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICPersoDate.Hint = "IC Perso Date";
            this.txt_ICPersoDate.LeadingIcon = null;
            this.txt_ICPersoDate.Location = new System.Drawing.Point(13, 534);
            this.txt_ICPersoDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICPersoDate.MaxLength = 50;
            this.txt_ICPersoDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICPersoDate.Multiline = false;
            this.txt_ICPersoDate.Name = "txt_ICPersoDate";
            this.txt_ICPersoDate.Size = new System.Drawing.Size(94, 50);
            this.txt_ICPersoDate.TabIndex = 34;
            this.txt_ICPersoDate.Text = "";
            this.txt_ICPersoDate.TrailingIcon = null;
            // 
            // txt_osRelease_date
            // 
            this.txt_osRelease_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_osRelease_date.AnimateReadOnly = false;
            this.txt_osRelease_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_osRelease_date.Depth = 0;
            this.txt_osRelease_date.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_osRelease_date.Hint = "OS Release date";
            this.txt_osRelease_date.LeadingIcon = null;
            this.txt_osRelease_date.Location = new System.Drawing.Point(123, 81);
            this.txt_osRelease_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_osRelease_date.MaxLength = 50;
            this.txt_osRelease_date.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_osRelease_date.Multiline = false;
            this.txt_osRelease_date.Name = "txt_osRelease_date";
            this.txt_osRelease_date.Size = new System.Drawing.Size(346, 50);
            this.txt_osRelease_date.TabIndex = 23;
            this.txt_osRelease_date.Text = "";
            this.txt_osRelease_date.TrailingIcon = null;
            // 
            // txt_ICPersonalizer
            // 
            this.txt_ICPersonalizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICPersonalizer.AnimateReadOnly = false;
            this.txt_ICPersonalizer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICPersonalizer.Depth = 0;
            this.txt_ICPersonalizer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICPersonalizer.Hint = "IC Personalizer";
            this.txt_ICPersonalizer.LeadingIcon = null;
            this.txt_ICPersonalizer.Location = new System.Drawing.Point(123, 467);
            this.txt_ICPersonalizer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICPersonalizer.MaxLength = 50;
            this.txt_ICPersonalizer.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICPersonalizer.Multiline = false;
            this.txt_ICPersonalizer.Name = "txt_ICPersonalizer";
            this.txt_ICPersonalizer.Size = new System.Drawing.Size(346, 50);
            this.txt_ICPersonalizer.TabIndex = 33;
            this.txt_ICPersonalizer.Text = "";
            this.txt_ICPersonalizer.TrailingIcon = null;
            // 
            // txt_osRelease_level
            // 
            this.txt_osRelease_level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_osRelease_level.AnimateReadOnly = false;
            this.txt_osRelease_level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_osRelease_level.Depth = 0;
            this.txt_osRelease_level.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_osRelease_level.Hint = "OS Release level";
            this.txt_osRelease_level.LeadingIcon = null;
            this.txt_osRelease_level.Location = new System.Drawing.Point(13, 145);
            this.txt_osRelease_level.Margin = new System.Windows.Forms.Padding(4);
            this.txt_osRelease_level.MaxLength = 50;
            this.txt_osRelease_level.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_osRelease_level.Multiline = false;
            this.txt_osRelease_level.Name = "txt_osRelease_level";
            this.txt_osRelease_level.Size = new System.Drawing.Size(94, 50);
            this.txt_osRelease_level.TabIndex = 24;
            this.txt_osRelease_level.Text = "";
            this.txt_osRelease_level.TrailingIcon = null;
            // 
            // txt_PrePersoEqp
            // 
            this.txt_PrePersoEqp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PrePersoEqp.AnimateReadOnly = false;
            this.txt_PrePersoEqp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PrePersoEqp.Depth = 0;
            this.txt_PrePersoEqp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PrePersoEqp.Hint = "IC Pre-Perso Eqp ID";
            this.txt_PrePersoEqp.LeadingIcon = null;
            this.txt_PrePersoEqp.Location = new System.Drawing.Point(13, 467);
            this.txt_PrePersoEqp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrePersoEqp.MaxLength = 50;
            this.txt_PrePersoEqp.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_PrePersoEqp.Multiline = false;
            this.txt_PrePersoEqp.Name = "txt_PrePersoEqp";
            this.txt_PrePersoEqp.Size = new System.Drawing.Size(94, 50);
            this.txt_PrePersoEqp.TabIndex = 32;
            this.txt_PrePersoEqp.Text = "";
            this.txt_PrePersoEqp.TrailingIcon = null;
            // 
            // txt_IC_batchIdentifier
            // 
            this.txt_IC_batchIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IC_batchIdentifier.AnimateReadOnly = false;
            this.txt_IC_batchIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IC_batchIdentifier.Depth = 0;
            this.txt_IC_batchIdentifier.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_IC_batchIdentifier.Hint = "IC Batch Identifier";
            this.txt_IC_batchIdentifier.LeadingIcon = null;
            this.txt_IC_batchIdentifier.Location = new System.Drawing.Point(124, 209);
            this.txt_IC_batchIdentifier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IC_batchIdentifier.MaxLength = 50;
            this.txt_IC_batchIdentifier.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_IC_batchIdentifier.Multiline = false;
            this.txt_IC_batchIdentifier.Name = "txt_IC_batchIdentifier";
            this.txt_IC_batchIdentifier.Size = new System.Drawing.Size(346, 50);
            this.txt_IC_batchIdentifier.TabIndex = 27;
            this.txt_IC_batchIdentifier.Text = "";
            this.txt_IC_batchIdentifier.TrailingIcon = null;
            // 
            // txt_PrePersoDate
            // 
            this.txt_PrePersoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PrePersoDate.AnimateReadOnly = false;
            this.txt_PrePersoDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PrePersoDate.Depth = 0;
            this.txt_PrePersoDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PrePersoDate.Hint = "IC Pre-Perso Date";
            this.txt_PrePersoDate.LeadingIcon = null;
            this.txt_PrePersoDate.Location = new System.Drawing.Point(123, 403);
            this.txt_PrePersoDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrePersoDate.MaxLength = 50;
            this.txt_PrePersoDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_PrePersoDate.Multiline = false;
            this.txt_PrePersoDate.Name = "txt_PrePersoDate";
            this.txt_PrePersoDate.Size = new System.Drawing.Size(346, 50);
            this.txt_PrePersoDate.TabIndex = 31;
            this.txt_PrePersoDate.Text = "";
            this.txt_PrePersoDate.TrailingIcon = null;
            // 
            // txt_icSerailnumber
            // 
            this.txt_icSerailnumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_icSerailnumber.AnimateReadOnly = false;
            this.txt_icSerailnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_icSerailnumber.Depth = 0;
            this.txt_icSerailnumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_icSerailnumber.Hint = "IC Serial Number";
            this.txt_icSerailnumber.LeadingIcon = null;
            this.txt_icSerailnumber.Location = new System.Drawing.Point(13, 209);
            this.txt_icSerailnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_icSerailnumber.MaxLength = 50;
            this.txt_icSerailnumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_icSerailnumber.Multiline = false;
            this.txt_icSerailnumber.Name = "txt_icSerailnumber";
            this.txt_icSerailnumber.Size = new System.Drawing.Size(94, 50);
            this.txt_icSerailnumber.TabIndex = 26;
            this.txt_icSerailnumber.Text = "";
            this.txt_icSerailnumber.TrailingIcon = null;
            // 
            // txt_ICPrePersonalizer
            // 
            this.txt_ICPrePersonalizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICPrePersonalizer.AnimateReadOnly = false;
            this.txt_ICPrePersonalizer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICPrePersonalizer.Depth = 0;
            this.txt_ICPrePersonalizer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICPrePersonalizer.Hint = "IC Pre-Personalizer";
            this.txt_ICPrePersonalizer.LeadingIcon = null;
            this.txt_ICPrePersonalizer.Location = new System.Drawing.Point(13, 403);
            this.txt_ICPrePersonalizer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICPrePersonalizer.MaxLength = 50;
            this.txt_ICPrePersonalizer.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICPrePersonalizer.Multiline = false;
            this.txt_ICPrePersonalizer.Name = "txt_ICPrePersonalizer";
            this.txt_ICPrePersonalizer.Size = new System.Drawing.Size(94, 50);
            this.txt_ICPrePersonalizer.TabIndex = 30;
            this.txt_ICPrePersonalizer.Text = "";
            this.txt_ICPrePersonalizer.TrailingIcon = null;
            // 
            // txt_osIdentifier
            // 
            this.txt_osIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_osIdentifier.AnimateReadOnly = false;
            this.txt_osIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_osIdentifier.Depth = 0;
            this.txt_osIdentifier.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_osIdentifier.Hint = "OS Identifier";
            this.txt_osIdentifier.LeadingIcon = null;
            this.txt_osIdentifier.Location = new System.Drawing.Point(13, 81);
            this.txt_osIdentifier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_osIdentifier.MaxLength = 50;
            this.txt_osIdentifier.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_osIdentifier.Multiline = false;
            this.txt_osIdentifier.Name = "txt_osIdentifier";
            this.txt_osIdentifier.Size = new System.Drawing.Size(94, 50);
            this.txt_osIdentifier.TabIndex = 22;
            this.txt_osIdentifier.Text = "";
            this.txt_osIdentifier.TrailingIcon = null;
            // 
            // txt_ICMPDate
            // 
            this.txt_ICMPDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICMPDate.AnimateReadOnly = false;
            this.txt_ICMPDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICMPDate.Depth = 0;
            this.txt_ICMPDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICMPDate.Hint = "IC MP Date";
            this.txt_ICMPDate.LeadingIcon = null;
            this.txt_ICMPDate.Location = new System.Drawing.Point(124, 273);
            this.txt_ICMPDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICMPDate.MaxLength = 50;
            this.txt_ICMPDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICMPDate.Multiline = false;
            this.txt_ICMPDate.Name = "txt_ICMPDate";
            this.txt_ICMPDate.Size = new System.Drawing.Size(346, 50);
            this.txt_ICMPDate.TabIndex = 27;
            this.txt_ICMPDate.Text = "";
            this.txt_ICMPDate.TrailingIcon = null;
            // 
            // txt_ICFabricatorDate
            // 
            this.txt_ICFabricatorDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICFabricatorDate.AnimateReadOnly = false;
            this.txt_ICFabricatorDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICFabricatorDate.Depth = 0;
            this.txt_ICFabricatorDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICFabricatorDate.Hint = "IC Fabricator Date";
            this.txt_ICFabricatorDate.LeadingIcon = null;
            this.txt_ICFabricatorDate.Location = new System.Drawing.Point(123, 145);
            this.txt_ICFabricatorDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICFabricatorDate.MaxLength = 50;
            this.txt_ICFabricatorDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICFabricatorDate.Multiline = false;
            this.txt_ICFabricatorDate.Name = "txt_ICFabricatorDate";
            this.txt_ICFabricatorDate.Size = new System.Drawing.Size(346, 50);
            this.txt_ICFabricatorDate.TabIndex = 25;
            this.txt_ICFabricatorDate.Text = "";
            this.txt_ICFabricatorDate.TrailingIcon = null;
            // 
            // txt_ICEmbeddingDate
            // 
            this.txt_ICEmbeddingDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICEmbeddingDate.AnimateReadOnly = false;
            this.txt_ICEmbeddingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICEmbeddingDate.Depth = 0;
            this.txt_ICEmbeddingDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICEmbeddingDate.Hint = "IC Embedding Date";
            this.txt_ICEmbeddingDate.LeadingIcon = null;
            this.txt_ICEmbeddingDate.Location = new System.Drawing.Point(123, 337);
            this.txt_ICEmbeddingDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICEmbeddingDate.MaxLength = 50;
            this.txt_ICEmbeddingDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICEmbeddingDate.Multiline = false;
            this.txt_ICEmbeddingDate.Name = "txt_ICEmbeddingDate";
            this.txt_ICEmbeddingDate.Size = new System.Drawing.Size(346, 50);
            this.txt_ICEmbeddingDate.TabIndex = 29;
            this.txt_ICEmbeddingDate.Text = "";
            this.txt_ICEmbeddingDate.TrailingIcon = null;
            // 
            // txt_ICType
            // 
            this.txt_ICType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICType.AnimateReadOnly = false;
            this.txt_ICType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICType.Depth = 0;
            this.txt_ICType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICType.Hint = "IC Type";
            this.txt_ICType.LeadingIcon = null;
            this.txt_ICType.Location = new System.Drawing.Point(123, 16);
            this.txt_ICType.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICType.MaxLength = 50;
            this.txt_ICType.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICType.Multiline = false;
            this.txt_ICType.Name = "txt_ICType";
            this.txt_ICType.Size = new System.Drawing.Size(346, 50);
            this.txt_ICType.TabIndex = 21;
            this.txt_ICType.Text = "";
            this.txt_ICType.TrailingIcon = null;
            // 
            // txt_ICCManufacturer
            // 
            this.txt_ICCManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICCManufacturer.AnimateReadOnly = false;
            this.txt_ICCManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICCManufacturer.Depth = 0;
            this.txt_ICCManufacturer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICCManufacturer.Hint = "ICC Manufacturer";
            this.txt_ICCManufacturer.LeadingIcon = null;
            this.txt_ICCManufacturer.Location = new System.Drawing.Point(13, 337);
            this.txt_ICCManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICCManufacturer.MaxLength = 50;
            this.txt_ICCManufacturer.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICCManufacturer.Multiline = false;
            this.txt_ICCManufacturer.Name = "txt_ICCManufacturer";
            this.txt_ICCManufacturer.Size = new System.Drawing.Size(94, 50);
            this.txt_ICCManufacturer.TabIndex = 28;
            this.txt_ICCManufacturer.Text = "";
            this.txt_ICCManufacturer.TrailingIcon = null;
            // 
            // txt_ICMod
            // 
            this.txt_ICMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ICMod.AnimateReadOnly = false;
            this.txt_ICMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ICMod.Depth = 0;
            this.txt_ICMod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ICMod.Hint = "IC Mod Fabricator";
            this.txt_ICMod.LeadingIcon = null;
            this.txt_ICMod.Location = new System.Drawing.Point(13, 273);
            this.txt_ICMod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICMod.MaxLength = 50;
            this.txt_ICMod.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ICMod.Multiline = false;
            this.txt_ICMod.Name = "txt_ICMod";
            this.txt_ICMod.Size = new System.Drawing.Size(94, 50);
            this.txt_ICMod.TabIndex = 26;
            this.txt_ICMod.Text = "";
            this.txt_ICMod.TrailingIcon = null;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txt_ATR);
            this.groupBox5.Location = new System.Drawing.Point(7, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(755, 81);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Card Data";
            // 
            // txt_ATR
            // 
            this.txt_ATR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ATR.AnimateReadOnly = false;
            this.txt_ATR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ATR.Depth = 0;
            this.txt_ATR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ATR.Hint = "Answer to reset (ATR)";
            this.txt_ATR.LeadingIcon = null;
            this.txt_ATR.Location = new System.Drawing.Point(13, 20);
            this.txt_ATR.MaxLength = 50;
            this.txt_ATR.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ATR.Multiline = false;
            this.txt_ATR.Name = "txt_ATR";
            this.txt_ATR.Size = new System.Drawing.Size(730, 50);
            this.txt_ATR.TabIndex = 19;
            this.txt_ATR.Text = "";
            this.txt_ATR.TrailingIcon = null;
            this.txt_ATR.TextChanged += new System.EventHandler(this.txt_ATR_TextChanged);
            // 
            // cbb_cardManager
            // 
            this.cbb_cardManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_cardManager.AutoResize = false;
            this.cbb_cardManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_cardManager.Depth = 0;
            this.cbb_cardManager.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_cardManager.DropDownHeight = 174;
            this.cbb_cardManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_cardManager.DropDownWidth = 121;
            this.cbb_cardManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_cardManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_cardManager.FormattingEnabled = true;
            this.cbb_cardManager.Hint = "Issuer Security Domain (Card Manager)";
            this.cbb_cardManager.IntegralHeight = false;
            this.cbb_cardManager.ItemHeight = 43;
            this.cbb_cardManager.Location = new System.Drawing.Point(20, 261);
            this.cbb_cardManager.MaxDropDownItems = 4;
            this.cbb_cardManager.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_cardManager.Name = "cbb_cardManager";
            this.cbb_cardManager.Size = new System.Drawing.Size(578, 49);
            this.cbb_cardManager.StartIndex = 0;
            this.cbb_cardManager.TabIndex = 13;
            // 
            // btn_extAuth
            // 
            this.btn_extAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_extAuth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_extAuth.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_extAuth.Depth = 0;
            this.btn_extAuth.HighEmphasis = true;
            this.btn_extAuth.Icon = null;
            this.btn_extAuth.Location = new System.Drawing.Point(654, 219);
            this.btn_extAuth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_extAuth.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_extAuth.Name = "btn_extAuth";
            this.btn_extAuth.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_extAuth.Size = new System.Drawing.Size(90, 36);
            this.btn_extAuth.TabIndex = 7;
            this.btn_extAuth.Text = "Ext Auth";
            this.btn_extAuth.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_extAuth.UseAccentColor = false;
            this.btn_extAuth.UseVisualStyleBackColor = true;
            this.btn_extAuth.Click += new System.EventHandler(this.btn_extAuth_Click);
            // 
            // btn_appDelete
            // 
            this.btn_appDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_appDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_appDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_appDelete.Depth = 0;
            this.btn_appDelete.Enabled = false;
            this.btn_appDelete.HighEmphasis = true;
            this.btn_appDelete.Icon = null;
            this.btn_appDelete.Location = new System.Drawing.Point(654, 153);
            this.btn_appDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_appDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_appDelete.Name = "btn_appDelete";
            this.btn_appDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_appDelete.Size = new System.Drawing.Size(105, 36);
            this.btn_appDelete.TabIndex = 6;
            this.btn_appDelete.Text = "App delete";
            this.btn_appDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_appDelete.UseAccentColor = false;
            this.btn_appDelete.UseVisualStyleBackColor = true;
            this.btn_appDelete.Click += new System.EventHandler(this.btn_appDelete_Click);
            // 
            // btn_cardInfo
            // 
            this.btn_cardInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cardInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cardInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cardInfo.Depth = 0;
            this.btn_cardInfo.HighEmphasis = true;
            this.btn_cardInfo.Icon = null;
            this.btn_cardInfo.Location = new System.Drawing.Point(654, 81);
            this.btn_cardInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cardInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cardInfo.Name = "btn_cardInfo";
            this.btn_cardInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cardInfo.Size = new System.Drawing.Size(96, 36);
            this.btn_cardInfo.TabIndex = 4;
            this.btn_cardInfo.Text = "Card Info";
            this.btn_cardInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cardInfo.UseAccentColor = false;
            this.btn_cardInfo.UseVisualStyleBackColor = true;
            this.btn_cardInfo.Click += new System.EventHandler(this.btn_cardInfo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rdb_noKMC);
            this.groupBox4.Controls.Add(this.rdb_fixedENC);
            this.groupBox4.Controls.Add(this.rdb_deriveKMC);
            this.groupBox4.Controls.Add(this.txt_kmcKCV3);
            this.groupBox4.Controls.Add(this.txt_kmcKCV2);
            this.groupBox4.Controls.Add(this.txt_kmcKCV1);
            this.groupBox4.Controls.Add(this.cbb_kmcValue3);
            this.groupBox4.Controls.Add(this.cbb_kmcValue2);
            this.groupBox4.Controls.Add(this.cbb_kmcValue1);
            this.groupBox4.Location = new System.Drawing.Point(7, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 192);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "KMC Info";
            // 
            // rdb_noKMC
            // 
            this.rdb_noKMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_noKMC.AutoSize = true;
            this.rdb_noKMC.Depth = 0;
            this.rdb_noKMC.Location = new System.Drawing.Point(6, 126);
            this.rdb_noKMC.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_noKMC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_noKMC.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_noKMC.Name = "rdb_noKMC";
            this.rdb_noKMC.Ripple = true;
            this.rdb_noKMC.Size = new System.Drawing.Size(93, 37);
            this.rdb_noKMC.TabIndex = 12;
            this.rdb_noKMC.TabStop = true;
            this.rdb_noKMC.Text = "No KMC";
            this.rdb_noKMC.UseVisualStyleBackColor = true;
            this.rdb_noKMC.CheckedChanged += new System.EventHandler(this.rdb_noKMC_CheckedChanged);
            // 
            // rdb_fixedENC
            // 
            this.rdb_fixedENC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_fixedENC.AutoSize = true;
            this.rdb_fixedENC.Depth = 0;
            this.rdb_fixedENC.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdb_fixedENC.Location = new System.Drawing.Point(7, 72);
            this.rdb_fixedENC.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_fixedENC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_fixedENC.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_fixedENC.Name = "rdb_fixedENC";
            this.rdb_fixedENC.Ripple = true;
            this.rdb_fixedENC.Size = new System.Drawing.Size(180, 37);
            this.rdb_fixedENC.TabIndex = 11;
            this.rdb_fixedENC.TabStop = true;
            this.rdb_fixedENC.Text = "Fixed ENC MAG DEK";
            this.rdb_fixedENC.UseVisualStyleBackColor = true;
            this.rdb_fixedENC.CheckedChanged += new System.EventHandler(this.rdb_fixedENC_CheckedChanged);
            // 
            // rdb_deriveKMC
            // 
            this.rdb_deriveKMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_deriveKMC.AutoSize = true;
            this.rdb_deriveKMC.Checked = true;
            this.rdb_deriveKMC.Depth = 0;
            this.rdb_deriveKMC.Location = new System.Drawing.Point(7, 17);
            this.rdb_deriveKMC.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_deriveKMC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_deriveKMC.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_deriveKMC.Name = "rdb_deriveKMC";
            this.rdb_deriveKMC.Ripple = true;
            this.rdb_deriveKMC.Size = new System.Drawing.Size(117, 37);
            this.rdb_deriveKMC.TabIndex = 10;
            this.rdb_deriveKMC.TabStop = true;
            this.rdb_deriveKMC.Text = "Derive KMC";
            this.rdb_deriveKMC.UseVisualStyleBackColor = true;
            this.rdb_deriveKMC.CheckedChanged += new System.EventHandler(this.rdb_deriveKMC_CheckedChanged);
            // 
            // txt_kmcKCV3
            // 
            this.txt_kmcKCV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kmcKCV3.AnimateReadOnly = false;
            this.txt_kmcKCV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kmcKCV3.Depth = 0;
            this.txt_kmcKCV3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_kmcKCV3.Hint = "KCV";
            this.txt_kmcKCV3.LeadingIcon = null;
            this.txt_kmcKCV3.Location = new System.Drawing.Point(475, 123);
            this.txt_kmcKCV3.MaxLength = 6;
            this.txt_kmcKCV3.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_kmcKCV3.Multiline = false;
            this.txt_kmcKCV3.Name = "txt_kmcKCV3";
            this.txt_kmcKCV3.Size = new System.Drawing.Size(101, 50);
            this.txt_kmcKCV3.TabIndex = 9;
            this.txt_kmcKCV3.Text = "";
            this.txt_kmcKCV3.TrailingIcon = null;
            this.txt_kmcKCV3.TextChanged += new System.EventHandler(this.txt_kmcKCV3_TextChanged);
            // 
            // txt_kmcKCV2
            // 
            this.txt_kmcKCV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kmcKCV2.AnimateReadOnly = false;
            this.txt_kmcKCV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kmcKCV2.Depth = 0;
            this.txt_kmcKCV2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_kmcKCV2.Hint = "KCV";
            this.txt_kmcKCV2.LeadingIcon = null;
            this.txt_kmcKCV2.Location = new System.Drawing.Point(475, 67);
            this.txt_kmcKCV2.MaxLength = 6;
            this.txt_kmcKCV2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_kmcKCV2.Multiline = false;
            this.txt_kmcKCV2.Name = "txt_kmcKCV2";
            this.txt_kmcKCV2.Size = new System.Drawing.Size(101, 50);
            this.txt_kmcKCV2.TabIndex = 8;
            this.txt_kmcKCV2.Text = "";
            this.txt_kmcKCV2.TrailingIcon = null;
            this.txt_kmcKCV2.TextChanged += new System.EventHandler(this.txt_kmcKCV2_TextChanged);
            // 
            // txt_kmcKCV1
            // 
            this.txt_kmcKCV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kmcKCV1.AnimateReadOnly = false;
            this.txt_kmcKCV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kmcKCV1.Depth = 0;
            this.txt_kmcKCV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txt_kmcKCV1.Hint = "KCV";
            this.txt_kmcKCV1.LeadingIcon = null;
            this.txt_kmcKCV1.Location = new System.Drawing.Point(475, 11);
            this.txt_kmcKCV1.MaxLength = 6;
            this.txt_kmcKCV1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_kmcKCV1.Multiline = false;
            this.txt_kmcKCV1.Name = "txt_kmcKCV1";
            this.txt_kmcKCV1.Size = new System.Drawing.Size(101, 50);
            this.txt_kmcKCV1.TabIndex = 7;
            this.txt_kmcKCV1.Text = "8BAF47";
            this.txt_kmcKCV1.TrailingIcon = null;
            this.txt_kmcKCV1.TextChanged += new System.EventHandler(this.txt_kmcKCV1_TextChanged);
            // 
            // cbb_kmcValue3
            // 
            this.cbb_kmcValue3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_kmcValue3.AutoResize = false;
            this.cbb_kmcValue3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_kmcValue3.Depth = 0;
            this.cbb_kmcValue3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_kmcValue3.DropDownHeight = 174;
            this.cbb_kmcValue3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_kmcValue3.DropDownWidth = 121;
            this.cbb_kmcValue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_kmcValue3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_kmcValue3.FormattingEnabled = true;
            this.cbb_kmcValue3.IntegralHeight = false;
            this.cbb_kmcValue3.ItemHeight = 43;
            this.cbb_kmcValue3.Location = new System.Drawing.Point(194, 121);
            this.cbb_kmcValue3.MaxDropDownItems = 4;
            this.cbb_kmcValue3.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_kmcValue3.Name = "cbb_kmcValue3";
            this.cbb_kmcValue3.Size = new System.Drawing.Size(266, 49);
            this.cbb_kmcValue3.StartIndex = 0;
            this.cbb_kmcValue3.TabIndex = 6;
            // 
            // cbb_kmcValue2
            // 
            this.cbb_kmcValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_kmcValue2.AutoResize = false;
            this.cbb_kmcValue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_kmcValue2.Depth = 0;
            this.cbb_kmcValue2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_kmcValue2.DropDownHeight = 174;
            this.cbb_kmcValue2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_kmcValue2.DropDownWidth = 121;
            this.cbb_kmcValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_kmcValue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_kmcValue2.FormattingEnabled = true;
            this.cbb_kmcValue2.IntegralHeight = false;
            this.cbb_kmcValue2.ItemHeight = 43;
            this.cbb_kmcValue2.Location = new System.Drawing.Point(194, 66);
            this.cbb_kmcValue2.MaxDropDownItems = 4;
            this.cbb_kmcValue2.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_kmcValue2.Name = "cbb_kmcValue2";
            this.cbb_kmcValue2.Size = new System.Drawing.Size(266, 49);
            this.cbb_kmcValue2.StartIndex = 0;
            this.cbb_kmcValue2.TabIndex = 4;
            // 
            // cbb_kmcValue1
            // 
            this.cbb_kmcValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_kmcValue1.AutoResize = false;
            this.cbb_kmcValue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_kmcValue1.Depth = 0;
            this.cbb_kmcValue1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_kmcValue1.DropDownHeight = 174;
            this.cbb_kmcValue1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_kmcValue1.DropDownWidth = 121;
            this.cbb_kmcValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_kmcValue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_kmcValue1.FormattingEnabled = true;
            this.cbb_kmcValue1.IntegralHeight = false;
            this.cbb_kmcValue1.ItemHeight = 43;
            this.cbb_kmcValue1.Items.AddRange(new object[] {
            "404142434445464748494A4B4C4D4E4F"});
            this.cbb_kmcValue1.Location = new System.Drawing.Point(194, 11);
            this.cbb_kmcValue1.MaxDropDownItems = 4;
            this.cbb_kmcValue1.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_kmcValue1.Name = "cbb_kmcValue1";
            this.cbb_kmcValue1.Size = new System.Drawing.Size(266, 49);
            this.cbb_kmcValue1.StartIndex = 0;
            this.cbb_kmcValue1.TabIndex = 5;
            // 
            // btn_readerRefresh
            // 
            this.btn_readerRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_readerRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_readerRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_readerRefresh.Depth = 0;
            this.btn_readerRefresh.HighEmphasis = true;
            this.btn_readerRefresh.Icon = null;
            this.btn_readerRefresh.Location = new System.Drawing.Point(654, 10);
            this.btn_readerRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_readerRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_readerRefresh.Name = "btn_readerRefresh";
            this.btn_readerRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_readerRefresh.Size = new System.Drawing.Size(84, 36);
            this.btn_readerRefresh.TabIndex = 2;
            this.btn_readerRefresh.Text = "Refresh";
            this.btn_readerRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_readerRefresh.UseAccentColor = false;
            this.btn_readerRefresh.UseVisualStyleBackColor = true;
            this.btn_readerRefresh.Click += new System.EventHandler(this.btn_readerRefresh_Click);
            // 
            // cbb_cardReader2
            // 
            this.cbb_cardReader2.AutoResize = false;
            this.cbb_cardReader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_cardReader2.Depth = 0;
            this.cbb_cardReader2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_cardReader2.DropDownHeight = 174;
            this.cbb_cardReader2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_cardReader2.DropDownWidth = 121;
            this.cbb_cardReader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_cardReader2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_cardReader2.FormattingEnabled = true;
            this.cbb_cardReader2.IntegralHeight = false;
            this.cbb_cardReader2.ItemHeight = 43;
            this.cbb_cardReader2.Location = new System.Drawing.Point(104, 6);
            this.cbb_cardReader2.MaxDropDownItems = 4;
            this.cbb_cardReader2.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_cardReader2.Name = "cbb_cardReader2";
            this.cbb_cardReader2.Size = new System.Drawing.Size(494, 49);
            this.cbb_cardReader2.StartIndex = 0;
            this.cbb_cardReader2.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(17, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Reader";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.btn_updateCardmanager);
            this.tabPage4.Controls.Add(this.txt_processMessage);
            this.tabPage4.Controls.Add(this.materialLabel7);
            this.tabPage4.Controls.Add(this.cbb_cardmanager2);
            this.tabPage4.Controls.Add(this.btn_refresh2);
            this.tabPage4.Controls.Add(this.cbb_cardReader3);
            this.tabPage4.Controls.Add(this.materialLabel6);
            this.tabPage4.ImageKey = "masterkey.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1356, 795);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Update CM MAster Key";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.groupBox7);
            this.panel5.Location = new System.Drawing.Point(13, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(660, 226);
            this.panel5.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.rdo_new_kmc_fixed);
            this.groupBox7.Controls.Add(this.rdo_new_derive_kmc);
            this.groupBox7.Controls.Add(this.txt_new_kmc_kcv3);
            this.groupBox7.Controls.Add(this.txt_new_kmc_kcv2);
            this.groupBox7.Controls.Add(this.txt_new_kmc_kcv1);
            this.groupBox7.Controls.Add(this.cbb_new_no_kmc);
            this.groupBox7.Controls.Add(this.cbb_new_kmc_fixed);
            this.groupBox7.Controls.Add(this.cbb_new_kmc_key);
            this.groupBox7.Location = new System.Drawing.Point(4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(653, 216);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "New KMC Info";
            // 
            // rdo_new_kmc_fixed
            // 
            this.rdo_new_kmc_fixed.AutoSize = true;
            this.rdo_new_kmc_fixed.Depth = 0;
            this.rdo_new_kmc_fixed.Location = new System.Drawing.Point(7, 87);
            this.rdo_new_kmc_fixed.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_new_kmc_fixed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_new_kmc_fixed.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_new_kmc_fixed.Name = "rdo_new_kmc_fixed";
            this.rdo_new_kmc_fixed.Ripple = true;
            this.rdo_new_kmc_fixed.Size = new System.Drawing.Size(180, 37);
            this.rdo_new_kmc_fixed.TabIndex = 11;
            this.rdo_new_kmc_fixed.TabStop = true;
            this.rdo_new_kmc_fixed.Text = "Fixed ENC MAG DEK";
            this.rdo_new_kmc_fixed.UseVisualStyleBackColor = true;
            this.rdo_new_kmc_fixed.CheckedChanged += new System.EventHandler(this.rdo_new_kmc_fixed_CheckedChanged);
            // 
            // rdo_new_derive_kmc
            // 
            this.rdo_new_derive_kmc.AutoSize = true;
            this.rdo_new_derive_kmc.Depth = 0;
            this.rdo_new_derive_kmc.Location = new System.Drawing.Point(7, 23);
            this.rdo_new_derive_kmc.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_new_derive_kmc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_new_derive_kmc.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_new_derive_kmc.Name = "rdo_new_derive_kmc";
            this.rdo_new_derive_kmc.Ripple = true;
            this.rdo_new_derive_kmc.Size = new System.Drawing.Size(117, 37);
            this.rdo_new_derive_kmc.TabIndex = 10;
            this.rdo_new_derive_kmc.TabStop = true;
            this.rdo_new_derive_kmc.Text = "Derive KMC";
            this.rdo_new_derive_kmc.UseVisualStyleBackColor = true;
            this.rdo_new_derive_kmc.CheckedChanged += new System.EventHandler(this.rdo_new_derive_kmc_CheckedChanged);
            // 
            // txt_new_kmc_kcv3
            // 
            this.txt_new_kmc_kcv3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_new_kmc_kcv3.AnimateReadOnly = false;
            this.txt_new_kmc_kcv3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_kmc_kcv3.Depth = 0;
            this.txt_new_kmc_kcv3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_new_kmc_kcv3.Hint = "KCV";
            this.txt_new_kmc_kcv3.LeadingIcon = null;
            this.txt_new_kmc_kcv3.Location = new System.Drawing.Point(517, 147);
            this.txt_new_kmc_kcv3.MaxLength = 6;
            this.txt_new_kmc_kcv3.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_new_kmc_kcv3.Multiline = false;
            this.txt_new_kmc_kcv3.Name = "txt_new_kmc_kcv3";
            this.txt_new_kmc_kcv3.Size = new System.Drawing.Size(121, 50);
            this.txt_new_kmc_kcv3.TabIndex = 9;
            this.txt_new_kmc_kcv3.Text = "";
            this.txt_new_kmc_kcv3.TrailingIcon = null;
            this.txt_new_kmc_kcv3.TextChanged += new System.EventHandler(this.txt_new_kmc_kcv3_TextChanged);
            // 
            // txt_new_kmc_kcv2
            // 
            this.txt_new_kmc_kcv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_new_kmc_kcv2.AnimateReadOnly = false;
            this.txt_new_kmc_kcv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_kmc_kcv2.Depth = 0;
            this.txt_new_kmc_kcv2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_new_kmc_kcv2.Hint = "KCV";
            this.txt_new_kmc_kcv2.LeadingIcon = null;
            this.txt_new_kmc_kcv2.Location = new System.Drawing.Point(517, 82);
            this.txt_new_kmc_kcv2.MaxLength = 6;
            this.txt_new_kmc_kcv2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_new_kmc_kcv2.Multiline = false;
            this.txt_new_kmc_kcv2.Name = "txt_new_kmc_kcv2";
            this.txt_new_kmc_kcv2.Size = new System.Drawing.Size(121, 50);
            this.txt_new_kmc_kcv2.TabIndex = 8;
            this.txt_new_kmc_kcv2.Text = "";
            this.txt_new_kmc_kcv2.TrailingIcon = null;
            this.txt_new_kmc_kcv2.TextChanged += new System.EventHandler(this.txt_new_kmc_kcv2_TextChanged);
            // 
            // txt_new_kmc_kcv1
            // 
            this.txt_new_kmc_kcv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_new_kmc_kcv1.AnimateReadOnly = false;
            this.txt_new_kmc_kcv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_kmc_kcv1.Depth = 0;
            this.txt_new_kmc_kcv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txt_new_kmc_kcv1.Hint = "KCV";
            this.txt_new_kmc_kcv1.LeadingIcon = null;
            this.txt_new_kmc_kcv1.Location = new System.Drawing.Point(517, 17);
            this.txt_new_kmc_kcv1.MaxLength = 6;
            this.txt_new_kmc_kcv1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_new_kmc_kcv1.Multiline = false;
            this.txt_new_kmc_kcv1.Name = "txt_new_kmc_kcv1";
            this.txt_new_kmc_kcv1.Size = new System.Drawing.Size(121, 50);
            this.txt_new_kmc_kcv1.TabIndex = 7;
            this.txt_new_kmc_kcv1.Text = "8BAF47";
            this.txt_new_kmc_kcv1.TrailingIcon = null;
            this.txt_new_kmc_kcv1.TextChanged += new System.EventHandler(this.txt_new_kmc_kcv1_TextChanged);
            // 
            // cbb_new_no_kmc
            // 
            this.cbb_new_no_kmc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_new_no_kmc.AutoResize = true;
            this.cbb_new_no_kmc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_new_no_kmc.Depth = 0;
            this.cbb_new_no_kmc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_new_no_kmc.DropDownHeight = 174;
            this.cbb_new_no_kmc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_new_no_kmc.DropDownWidth = 121;
            this.cbb_new_no_kmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_new_no_kmc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_new_no_kmc.FormattingEnabled = true;
            this.cbb_new_no_kmc.IntegralHeight = false;
            this.cbb_new_no_kmc.ItemHeight = 43;
            this.cbb_new_no_kmc.Location = new System.Drawing.Point(217, 145);
            this.cbb_new_no_kmc.MaxDropDownItems = 4;
            this.cbb_new_no_kmc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_new_no_kmc.Name = "cbb_new_no_kmc";
            this.cbb_new_no_kmc.Size = new System.Drawing.Size(121, 49);
            this.cbb_new_no_kmc.StartIndex = 0;
            this.cbb_new_no_kmc.TabIndex = 6;
            // 
            // cbb_new_kmc_fixed
            // 
            this.cbb_new_kmc_fixed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_new_kmc_fixed.AutoResize = true;
            this.cbb_new_kmc_fixed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_new_kmc_fixed.Depth = 0;
            this.cbb_new_kmc_fixed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_new_kmc_fixed.DropDownHeight = 174;
            this.cbb_new_kmc_fixed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_new_kmc_fixed.DropDownWidth = 121;
            this.cbb_new_kmc_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_new_kmc_fixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_new_kmc_fixed.FormattingEnabled = true;
            this.cbb_new_kmc_fixed.IntegralHeight = false;
            this.cbb_new_kmc_fixed.ItemHeight = 43;
            this.cbb_new_kmc_fixed.Location = new System.Drawing.Point(217, 81);
            this.cbb_new_kmc_fixed.MaxDropDownItems = 4;
            this.cbb_new_kmc_fixed.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_new_kmc_fixed.Name = "cbb_new_kmc_fixed";
            this.cbb_new_kmc_fixed.Size = new System.Drawing.Size(121, 49);
            this.cbb_new_kmc_fixed.StartIndex = 0;
            this.cbb_new_kmc_fixed.TabIndex = 4;
            // 
            // cbb_new_kmc_key
            // 
            this.cbb_new_kmc_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_new_kmc_key.AutoResize = true;
            this.cbb_new_kmc_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_new_kmc_key.Depth = 0;
            this.cbb_new_kmc_key.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_new_kmc_key.DropDownHeight = 174;
            this.cbb_new_kmc_key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_new_kmc_key.DropDownWidth = 121;
            this.cbb_new_kmc_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_new_kmc_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_new_kmc_key.FormattingEnabled = true;
            this.cbb_new_kmc_key.IntegralHeight = false;
            this.cbb_new_kmc_key.ItemHeight = 43;
            this.cbb_new_kmc_key.Items.AddRange(new object[] {
            "404142434445464748494A4B4C4D4E4F"});
            this.cbb_new_kmc_key.Location = new System.Drawing.Point(217, 17);
            this.cbb_new_kmc_key.MaxDropDownItems = 4;
            this.cbb_new_kmc_key.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_new_kmc_key.Name = "cbb_new_kmc_key";
            this.cbb_new_kmc_key.Size = new System.Drawing.Size(121, 49);
            this.cbb_new_kmc_key.StartIndex = 0;
            this.cbb_new_kmc_key.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Location = new System.Drawing.Point(13, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 216);
            this.panel4.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.rdo_old_no_kmc);
            this.groupBox6.Controls.Add(this.rdo_old_kmc_fixed);
            this.groupBox6.Controls.Add(this.rdo_old_derive_kmc);
            this.groupBox6.Controls.Add(this.txt_old_kmc_kcv3);
            this.groupBox6.Controls.Add(this.txt_old_kmc_kcv2);
            this.groupBox6.Controls.Add(this.txt_old_kmc_kcv1);
            this.groupBox6.Controls.Add(this.cbb_old_no_kmc);
            this.groupBox6.Controls.Add(this.cbb_old_kmc_fixed);
            this.groupBox6.Controls.Add(this.cbb_old_kmc_key);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(654, 210);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Old KMC Info";
            // 
            // rdo_old_no_kmc
            // 
            this.rdo_old_no_kmc.AutoSize = true;
            this.rdo_old_no_kmc.Depth = 0;
            this.rdo_old_no_kmc.Location = new System.Drawing.Point(6, 150);
            this.rdo_old_no_kmc.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_old_no_kmc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_old_no_kmc.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_old_no_kmc.Name = "rdo_old_no_kmc";
            this.rdo_old_no_kmc.Ripple = true;
            this.rdo_old_no_kmc.Size = new System.Drawing.Size(93, 37);
            this.rdo_old_no_kmc.TabIndex = 12;
            this.rdo_old_no_kmc.TabStop = true;
            this.rdo_old_no_kmc.Text = "No KMC";
            this.rdo_old_no_kmc.UseVisualStyleBackColor = true;
            this.rdo_old_no_kmc.CheckedChanged += new System.EventHandler(this.rdo_old_no_kmc_CheckedChanged);
            // 
            // rdo_old_kmc_fixed
            // 
            this.rdo_old_kmc_fixed.AutoSize = true;
            this.rdo_old_kmc_fixed.Depth = 0;
            this.rdo_old_kmc_fixed.Location = new System.Drawing.Point(7, 87);
            this.rdo_old_kmc_fixed.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_old_kmc_fixed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_old_kmc_fixed.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_old_kmc_fixed.Name = "rdo_old_kmc_fixed";
            this.rdo_old_kmc_fixed.Ripple = true;
            this.rdo_old_kmc_fixed.Size = new System.Drawing.Size(180, 37);
            this.rdo_old_kmc_fixed.TabIndex = 11;
            this.rdo_old_kmc_fixed.TabStop = true;
            this.rdo_old_kmc_fixed.Text = "Fixed ENC MAG DEK";
            this.rdo_old_kmc_fixed.UseVisualStyleBackColor = true;
            this.rdo_old_kmc_fixed.CheckedChanged += new System.EventHandler(this.rdo_old_kmc_fixed_CheckedChanged);
            // 
            // rdo_old_derive_kmc
            // 
            this.rdo_old_derive_kmc.AutoSize = true;
            this.rdo_old_derive_kmc.Depth = 0;
            this.rdo_old_derive_kmc.Location = new System.Drawing.Point(7, 23);
            this.rdo_old_derive_kmc.Margin = new System.Windows.Forms.Padding(0);
            this.rdo_old_derive_kmc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdo_old_derive_kmc.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdo_old_derive_kmc.Name = "rdo_old_derive_kmc";
            this.rdo_old_derive_kmc.Ripple = true;
            this.rdo_old_derive_kmc.Size = new System.Drawing.Size(117, 37);
            this.rdo_old_derive_kmc.TabIndex = 10;
            this.rdo_old_derive_kmc.TabStop = true;
            this.rdo_old_derive_kmc.Text = "Derive KMC";
            this.rdo_old_derive_kmc.UseVisualStyleBackColor = true;
            this.rdo_old_derive_kmc.CheckedChanged += new System.EventHandler(this.rdo_old_derive_kmc_CheckedChanged);
            // 
            // txt_old_kmc_kcv3
            // 
            this.txt_old_kmc_kcv3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_old_kmc_kcv3.AnimateReadOnly = false;
            this.txt_old_kmc_kcv3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_old_kmc_kcv3.Depth = 0;
            this.txt_old_kmc_kcv3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_old_kmc_kcv3.Hint = "KCV";
            this.txt_old_kmc_kcv3.LeadingIcon = null;
            this.txt_old_kmc_kcv3.Location = new System.Drawing.Point(527, 138);
            this.txt_old_kmc_kcv3.MaxLength = 6;
            this.txt_old_kmc_kcv3.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_old_kmc_kcv3.Multiline = false;
            this.txt_old_kmc_kcv3.Name = "txt_old_kmc_kcv3";
            this.txt_old_kmc_kcv3.Size = new System.Drawing.Size(121, 50);
            this.txt_old_kmc_kcv3.TabIndex = 9;
            this.txt_old_kmc_kcv3.Text = "";
            this.txt_old_kmc_kcv3.TrailingIcon = null;
            this.txt_old_kmc_kcv3.TextChanged += new System.EventHandler(this.txt_old_kmc_kcv3_TextChanged);
            // 
            // txt_old_kmc_kcv2
            // 
            this.txt_old_kmc_kcv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_old_kmc_kcv2.AnimateReadOnly = false;
            this.txt_old_kmc_kcv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_old_kmc_kcv2.Depth = 0;
            this.txt_old_kmc_kcv2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_old_kmc_kcv2.Hint = "KCV";
            this.txt_old_kmc_kcv2.LeadingIcon = null;
            this.txt_old_kmc_kcv2.Location = new System.Drawing.Point(527, 82);
            this.txt_old_kmc_kcv2.MaxLength = 6;
            this.txt_old_kmc_kcv2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_old_kmc_kcv2.Multiline = false;
            this.txt_old_kmc_kcv2.Name = "txt_old_kmc_kcv2";
            this.txt_old_kmc_kcv2.Size = new System.Drawing.Size(121, 50);
            this.txt_old_kmc_kcv2.TabIndex = 8;
            this.txt_old_kmc_kcv2.Text = "";
            this.txt_old_kmc_kcv2.TrailingIcon = null;
            this.txt_old_kmc_kcv2.TextChanged += new System.EventHandler(this.txt_old_kmc_kcv2_TextChanged);
            // 
            // txt_old_kmc_kcv1
            // 
            this.txt_old_kmc_kcv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_old_kmc_kcv1.AnimateReadOnly = false;
            this.txt_old_kmc_kcv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_old_kmc_kcv1.Depth = 0;
            this.txt_old_kmc_kcv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txt_old_kmc_kcv1.Hint = "KCV";
            this.txt_old_kmc_kcv1.LeadingIcon = null;
            this.txt_old_kmc_kcv1.Location = new System.Drawing.Point(527, 17);
            this.txt_old_kmc_kcv1.MaxLength = 6;
            this.txt_old_kmc_kcv1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_old_kmc_kcv1.Multiline = false;
            this.txt_old_kmc_kcv1.Name = "txt_old_kmc_kcv1";
            this.txt_old_kmc_kcv1.Size = new System.Drawing.Size(121, 50);
            this.txt_old_kmc_kcv1.TabIndex = 7;
            this.txt_old_kmc_kcv1.Text = "8BAF47";
            this.txt_old_kmc_kcv1.TrailingIcon = null;
            this.txt_old_kmc_kcv1.TextChanged += new System.EventHandler(this.txt_old_kmc_kcv1_TextChanged);
            // 
            // cbb_old_no_kmc
            // 
            this.cbb_old_no_kmc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_old_no_kmc.AutoResize = true;
            this.cbb_old_no_kmc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_old_no_kmc.Depth = 0;
            this.cbb_old_no_kmc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_old_no_kmc.DropDownHeight = 174;
            this.cbb_old_no_kmc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_old_no_kmc.DropDownWidth = 121;
            this.cbb_old_no_kmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_old_no_kmc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_old_no_kmc.FormattingEnabled = true;
            this.cbb_old_no_kmc.IntegralHeight = false;
            this.cbb_old_no_kmc.ItemHeight = 43;
            this.cbb_old_no_kmc.Location = new System.Drawing.Point(231, 138);
            this.cbb_old_no_kmc.MaxDropDownItems = 4;
            this.cbb_old_no_kmc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_old_no_kmc.Name = "cbb_old_no_kmc";
            this.cbb_old_no_kmc.Size = new System.Drawing.Size(121, 49);
            this.cbb_old_no_kmc.StartIndex = 0;
            this.cbb_old_no_kmc.TabIndex = 6;
            // 
            // cbb_old_kmc_fixed
            // 
            this.cbb_old_kmc_fixed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_old_kmc_fixed.AutoResize = true;
            this.cbb_old_kmc_fixed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_old_kmc_fixed.Depth = 0;
            this.cbb_old_kmc_fixed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_old_kmc_fixed.DropDownHeight = 174;
            this.cbb_old_kmc_fixed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_old_kmc_fixed.DropDownWidth = 121;
            this.cbb_old_kmc_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_old_kmc_fixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_old_kmc_fixed.FormattingEnabled = true;
            this.cbb_old_kmc_fixed.IntegralHeight = false;
            this.cbb_old_kmc_fixed.ItemHeight = 43;
            this.cbb_old_kmc_fixed.Location = new System.Drawing.Point(231, 83);
            this.cbb_old_kmc_fixed.MaxDropDownItems = 4;
            this.cbb_old_kmc_fixed.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_old_kmc_fixed.Name = "cbb_old_kmc_fixed";
            this.cbb_old_kmc_fixed.Size = new System.Drawing.Size(121, 49);
            this.cbb_old_kmc_fixed.StartIndex = 0;
            this.cbb_old_kmc_fixed.TabIndex = 4;
            // 
            // cbb_old_kmc_key
            // 
            this.cbb_old_kmc_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_old_kmc_key.AutoResize = true;
            this.cbb_old_kmc_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_old_kmc_key.Depth = 0;
            this.cbb_old_kmc_key.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_old_kmc_key.DropDownHeight = 174;
            this.cbb_old_kmc_key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_old_kmc_key.DropDownWidth = 335;
            this.cbb_old_kmc_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_old_kmc_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_old_kmc_key.FormattingEnabled = true;
            this.cbb_old_kmc_key.IntegralHeight = false;
            this.cbb_old_kmc_key.ItemHeight = 43;
            this.cbb_old_kmc_key.Items.AddRange(new object[] {
            "404142434445464748494A4B4C4D4E4F"});
            this.cbb_old_kmc_key.Location = new System.Drawing.Point(231, 17);
            this.cbb_old_kmc_key.MaxDropDownItems = 4;
            this.cbb_old_kmc_key.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_old_kmc_key.Name = "cbb_old_kmc_key";
            this.cbb_old_kmc_key.Size = new System.Drawing.Size(335, 49);
            this.cbb_old_kmc_key.StartIndex = 0;
            this.cbb_old_kmc_key.TabIndex = 5;
            // 
            // btn_updateCardmanager
            // 
            this.btn_updateCardmanager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_updateCardmanager.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_updateCardmanager.Depth = 0;
            this.btn_updateCardmanager.HighEmphasis = true;
            this.btn_updateCardmanager.Icon = null;
            this.btn_updateCardmanager.Location = new System.Drawing.Point(178, 585);
            this.btn_updateCardmanager.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_updateCardmanager.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_updateCardmanager.Name = "btn_updateCardmanager";
            this.btn_updateCardmanager.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_updateCardmanager.Size = new System.Drawing.Size(327, 36);
            this.btn_updateCardmanager.TabIndex = 8;
            this.btn_updateCardmanager.Text = "Update Card Manager Card Master Key";
            this.btn_updateCardmanager.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_updateCardmanager.UseAccentColor = false;
            this.btn_updateCardmanager.UseVisualStyleBackColor = true;
            this.btn_updateCardmanager.Click += new System.EventHandler(this.btn_updateCardmanager_Click);
            // 
            // txt_processMessage
            // 
            this.txt_processMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_processMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_processMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_processMessage.Depth = 0;
            this.txt_processMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_processMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_processMessage.Location = new System.Drawing.Point(679, 49);
            this.txt_processMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_processMessage.Name = "txt_processMessage";
            this.txt_processMessage.Size = new System.Drawing.Size(659, 522);
            this.txt_processMessage.TabIndex = 7;
            this.txt_processMessage.Text = "";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(676, 16);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(125, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Process Message";
            // 
            // cbb_cardmanager2
            // 
            this.cbb_cardmanager2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_cardmanager2.AutoResize = false;
            this.cbb_cardmanager2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_cardmanager2.Depth = 0;
            this.cbb_cardmanager2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_cardmanager2.DropDownHeight = 174;
            this.cbb_cardmanager2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_cardmanager2.DropDownWidth = 121;
            this.cbb_cardmanager2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_cardmanager2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_cardmanager2.FormattingEnabled = true;
            this.cbb_cardmanager2.Hint = "Issuer Security Domain (Card Manager)";
            this.cbb_cardmanager2.IntegralHeight = false;
            this.cbb_cardmanager2.ItemHeight = 43;
            this.cbb_cardmanager2.Items.AddRange(new object[] {
            "A000000003000000",
            "A000000004000000",
            "A000000151000000"});
            this.cbb_cardmanager2.Location = new System.Drawing.Point(9, 70);
            this.cbb_cardmanager2.MaxDropDownItems = 4;
            this.cbb_cardmanager2.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_cardmanager2.Name = "cbb_cardmanager2";
            this.cbb_cardmanager2.Size = new System.Drawing.Size(664, 49);
            this.cbb_cardmanager2.StartIndex = 0;
            this.cbb_cardmanager2.TabIndex = 3;
            // 
            // btn_refresh2
            // 
            this.btn_refresh2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_refresh2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_refresh2.Depth = 0;
            this.btn_refresh2.HighEmphasis = true;
            this.btn_refresh2.Icon = null;
            this.btn_refresh2.Location = new System.Drawing.Point(574, 9);
            this.btn_refresh2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_refresh2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_refresh2.Name = "btn_refresh2";
            this.btn_refresh2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_refresh2.Size = new System.Drawing.Size(84, 36);
            this.btn_refresh2.TabIndex = 2;
            this.btn_refresh2.Text = "Refresh";
            this.btn_refresh2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_refresh2.UseAccentColor = false;
            this.btn_refresh2.UseVisualStyleBackColor = true;
            this.btn_refresh2.Click += new System.EventHandler(this.btn_refresh2_Click);
            // 
            // cbb_cardReader3
            // 
            this.cbb_cardReader3.AutoResize = true;
            this.cbb_cardReader3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_cardReader3.Depth = 0;
            this.cbb_cardReader3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_cardReader3.DropDownHeight = 174;
            this.cbb_cardReader3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_cardReader3.DropDownWidth = 121;
            this.cbb_cardReader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_cardReader3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_cardReader3.FormattingEnabled = true;
            this.cbb_cardReader3.IntegralHeight = false;
            this.cbb_cardReader3.ItemHeight = 43;
            this.cbb_cardReader3.Location = new System.Drawing.Point(91, 6);
            this.cbb_cardReader3.MaxDropDownItems = 4;
            this.cbb_cardReader3.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_cardReader3.Name = "cbb_cardReader3";
            this.cbb_cardReader3.Size = new System.Drawing.Size(121, 49);
            this.cbb_cardReader3.StartIndex = 0;
            this.cbb_cardReader3.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(6, 16);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(50, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Reader";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel4);
            this.tabPage5.ImageKey = "aes.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1356, 795);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "AES Encryption";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox9, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox12, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1356, 795);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txt_AESKcv);
            this.groupBox10.Controls.Add(this.btn_getKCV);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(586, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(183, 153);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "KCV";
            // 
            // txt_AESKcv
            // 
            this.txt_AESKcv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_AESKcv.AnimateReadOnly = false;
            this.txt_AESKcv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AESKcv.Depth = 0;
            this.txt_AESKcv.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AESKcv.LeadingIcon = null;
            this.txt_AESKcv.Location = new System.Drawing.Point(7, 97);
            this.txt_AESKcv.MaxLength = 6;
            this.txt_AESKcv.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_AESKcv.Multiline = false;
            this.txt_AESKcv.Name = "txt_AESKcv";
            this.txt_AESKcv.Size = new System.Drawing.Size(185, 50);
            this.txt_AESKcv.TabIndex = 2;
            this.txt_AESKcv.Text = "";
            this.txt_AESKcv.TrailingIcon = null;
            this.txt_AESKcv.TextChanged += new System.EventHandler(this.txt_AESKcv_TextChanged);
            this.txt_AESKcv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AESKcv_KeyPress);
            // 
            // btn_getKCV
            // 
            this.btn_getKCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getKCV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_getKCV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_getKCV.Depth = 0;
            this.btn_getKCV.HighEmphasis = true;
            this.btn_getKCV.Icon = null;
            this.btn_getKCV.Location = new System.Drawing.Point(51, 24);
            this.btn_getKCV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_getKCV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_getKCV.Name = "btn_getKCV";
            this.btn_getKCV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_getKCV.Size = new System.Drawing.Size(81, 36);
            this.btn_getKCV.TabIndex = 2;
            this.btn_getKCV.Text = "Get KCV";
            this.btn_getKCV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_getKCV.UseAccentColor = false;
            this.btn_getKCV.UseVisualStyleBackColor = true;
            this.btn_getKCV.Click += new System.EventHandler(this.btn_getKCV_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbb_aesEncMode);
            this.groupBox9.Controls.Add(this.txt_ivAES);
            this.groupBox9.Controls.Add(this.materialLabel9);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(775, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(578, 153);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Encryption Mode";
            // 
            // cbb_aesEncMode
            // 
            this.cbb_aesEncMode.AutoResize = false;
            this.cbb_aesEncMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_aesEncMode.Depth = 0;
            this.cbb_aesEncMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_aesEncMode.DropDownHeight = 174;
            this.cbb_aesEncMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_aesEncMode.DropDownWidth = 121;
            this.cbb_aesEncMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_aesEncMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_aesEncMode.FormattingEnabled = true;
            this.cbb_aesEncMode.IntegralHeight = false;
            this.cbb_aesEncMode.ItemHeight = 43;
            this.cbb_aesEncMode.Items.AddRange(new object[] {
            "ECB",
            "CBC"});
            this.cbb_aesEncMode.Location = new System.Drawing.Point(140, 24);
            this.cbb_aesEncMode.MaxDropDownItems = 4;
            this.cbb_aesEncMode.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_aesEncMode.Name = "cbb_aesEncMode";
            this.cbb_aesEncMode.Size = new System.Drawing.Size(286, 49);
            this.cbb_aesEncMode.StartIndex = 0;
            this.cbb_aesEncMode.TabIndex = 7;
            this.cbb_aesEncMode.SelectedIndexChanged += new System.EventHandler(this.cbb_aesEncMode_SelectedIndexChanged);
            // 
            // txt_ivAES
            // 
            this.txt_ivAES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ivAES.AnimateReadOnly = false;
            this.txt_ivAES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ivAES.Depth = 0;
            this.txt_ivAES.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ivAES.Hint = "IV:";
            this.txt_ivAES.LeadingIcon = null;
            this.txt_ivAES.Location = new System.Drawing.Point(6, 97);
            this.txt_ivAES.MaxLength = 64;
            this.txt_ivAES.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ivAES.Multiline = false;
            this.txt_ivAES.Name = "txt_ivAES";
            this.txt_ivAES.Size = new System.Drawing.Size(566, 50);
            this.txt_ivAES.TabIndex = 5;
            this.txt_ivAES.Text = "";
            this.txt_ivAES.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(54, 41);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(45, 19);
            this.materialLabel9.TabIndex = 5;
            this.materialLabel9.Text = "Mode:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.materialLabel8);
            this.groupBox8.Controls.Add(this.rdb_defualtZMK);
            this.groupBox8.Controls.Add(this.rdb_defualtLMK);
            this.groupBox8.Controls.Add(this.rdb_clearAES);
            this.groupBox8.Controls.Add(this.txt_valueAES);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(577, 153);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "AES Key Infomation";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(0, 39);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(126, 19);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Wrapped by(DES)";
            // 
            // rdb_defualtZMK
            // 
            this.rdb_defualtZMK.AutoSize = true;
            this.rdb_defualtZMK.Depth = 0;
            this.rdb_defualtZMK.Location = new System.Drawing.Point(444, 29);
            this.rdb_defualtZMK.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_defualtZMK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_defualtZMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_defualtZMK.Name = "rdb_defualtZMK";
            this.rdb_defualtZMK.Ripple = true;
            this.rdb_defualtZMK.Size = new System.Drawing.Size(125, 37);
            this.rdb_defualtZMK.TabIndex = 3;
            this.rdb_defualtZMK.TabStop = true;
            this.rdb_defualtZMK.Text = "Default ZMK";
            this.rdb_defualtZMK.UseVisualStyleBackColor = true;
            // 
            // rdb_defualtLMK
            // 
            this.rdb_defualtLMK.AutoSize = true;
            this.rdb_defualtLMK.Depth = 0;
            this.rdb_defualtLMK.Location = new System.Drawing.Point(268, 29);
            this.rdb_defualtLMK.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_defualtLMK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_defualtLMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_defualtLMK.Name = "rdb_defualtLMK";
            this.rdb_defualtLMK.Ripple = true;
            this.rdb_defualtLMK.Size = new System.Drawing.Size(124, 37);
            this.rdb_defualtLMK.TabIndex = 2;
            this.rdb_defualtLMK.TabStop = true;
            this.rdb_defualtLMK.Text = "Default LMK";
            this.rdb_defualtLMK.UseVisualStyleBackColor = true;
            // 
            // rdb_clearAES
            // 
            this.rdb_clearAES.AutoSize = true;
            this.rdb_clearAES.Depth = 0;
            this.rdb_clearAES.Location = new System.Drawing.Point(160, 29);
            this.rdb_clearAES.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_clearAES.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_clearAES.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_clearAES.Name = "rdb_clearAES";
            this.rdb_clearAES.Ripple = true;
            this.rdb_clearAES.Size = new System.Drawing.Size(71, 37);
            this.rdb_clearAES.TabIndex = 1;
            this.rdb_clearAES.TabStop = true;
            this.rdb_clearAES.Text = "Clear";
            this.rdb_clearAES.UseVisualStyleBackColor = true;
            // 
            // txt_valueAES
            // 
            this.txt_valueAES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_valueAES.AnimateReadOnly = false;
            this.txt_valueAES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valueAES.Depth = 0;
            this.txt_valueAES.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_valueAES.Hint = "Value";
            this.txt_valueAES.LeadingIcon = null;
            this.txt_valueAES.Location = new System.Drawing.Point(6, 97);
            this.txt_valueAES.MaxLength = 64;
            this.txt_valueAES.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_valueAES.Multiline = false;
            this.txt_valueAES.Name = "txt_valueAES";
            this.txt_valueAES.Size = new System.Drawing.Size(565, 50);
            this.txt_valueAES.TabIndex = 0;
            this.txt_valueAES.Text = "";
            this.txt_valueAES.TrailingIcon = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_AESencrypt);
            this.panel3.Controls.Add(this.btn_AEScmac);
            this.panel3.Controls.Add(this.btn_AESdecrypt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(586, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 630);
            this.panel3.TabIndex = 2;
            // 
            // btn_AESencrypt
            // 
            this.btn_AESencrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AESencrypt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_AESencrypt.Depth = 0;
            this.btn_AESencrypt.HighEmphasis = true;
            this.btn_AESencrypt.Icon = null;
            this.btn_AESencrypt.Location = new System.Drawing.Point(30, 80);
            this.btn_AESencrypt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_AESencrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AESencrypt.Name = "btn_AESencrypt";
            this.btn_AESencrypt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_AESencrypt.Size = new System.Drawing.Size(113, 36);
            this.btn_AESencrypt.TabIndex = 0;
            this.btn_AESencrypt.Text = "Encrypt >>>";
            this.btn_AESencrypt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_AESencrypt.UseAccentColor = false;
            this.btn_AESencrypt.UseVisualStyleBackColor = true;
            this.btn_AESencrypt.Click += new System.EventHandler(this.btn_AESencrypt_Click);
            // 
            // btn_AEScmac
            // 
            this.btn_AEScmac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AEScmac.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AEScmac.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_AEScmac.Depth = 0;
            this.btn_AEScmac.HighEmphasis = true;
            this.btn_AEScmac.Icon = null;
            this.btn_AEScmac.Location = new System.Drawing.Point(35, 305);
            this.btn_AEScmac.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_AEScmac.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AEScmac.Name = "btn_AEScmac";
            this.btn_AEScmac.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_AEScmac.Size = new System.Drawing.Size(97, 36);
            this.btn_AEScmac.TabIndex = 5;
            this.btn_AEScmac.Text = "AES_CMAC";
            this.btn_AEScmac.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_AEScmac.UseAccentColor = false;
            this.btn_AEScmac.UseVisualStyleBackColor = true;
            this.btn_AEScmac.Click += new System.EventHandler(this.btn_AEScmac_Click);
            // 
            // btn_AESdecrypt
            // 
            this.btn_AESdecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AESdecrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AESdecrypt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_AESdecrypt.Depth = 0;
            this.btn_AESdecrypt.HighEmphasis = true;
            this.btn_AESdecrypt.Icon = null;
            this.btn_AESdecrypt.Location = new System.Drawing.Point(30, 194);
            this.btn_AESdecrypt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_AESdecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AESdecrypt.Name = "btn_AESdecrypt";
            this.btn_AESdecrypt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_AESdecrypt.Size = new System.Drawing.Size(108, 36);
            this.btn_AESdecrypt.TabIndex = 4;
            this.btn_AESdecrypt.Text = "<<<Decrypt";
            this.btn_AESdecrypt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_AESdecrypt.UseAccentColor = false;
            this.btn_AESdecrypt.UseVisualStyleBackColor = true;
            this.btn_AESdecrypt.Click += new System.EventHandler(this.btn_AESdecrypt_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txt_AESCleardata);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 162);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(577, 630);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Clear Data";
            // 
            // txt_AESCleardata
            // 
            this.txt_AESCleardata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_AESCleardata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AESCleardata.Depth = 0;
            this.txt_AESCleardata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_AESCleardata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AESCleardata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_AESCleardata.Location = new System.Drawing.Point(3, 18);
            this.txt_AESCleardata.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_AESCleardata.Name = "txt_AESCleardata";
            this.txt_AESCleardata.Size = new System.Drawing.Size(571, 609);
            this.txt_AESCleardata.TabIndex = 0;
            this.txt_AESCleardata.Text = "";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txt_AESencrypt);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(775, 162);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(578, 630);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Encrypted Data";
            // 
            // txt_AESencrypt
            // 
            this.txt_AESencrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_AESencrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AESencrypt.Depth = 0;
            this.txt_AESencrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_AESencrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AESencrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_AESencrypt.Location = new System.Drawing.Point(3, 18);
            this.txt_AESencrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_AESencrypt.Name = "txt_AESencrypt";
            this.txt_AESencrypt.Size = new System.Drawing.Size(572, 609);
            this.txt_AESencrypt.TabIndex = 0;
            this.txt_AESencrypt.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel3);
            this.tabPage6.Controls.Add(this.tableLayoutPanel2);
            this.tabPage6.Controls.Add(this.tableLayoutPanel1);
            this.tabPage6.ImageKey = "des.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1356, 795);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "DES Encryption";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.txt_DesInputdata1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_DesInputdata2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_DesInputdata3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_DesResultXOR, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_DESKcvInput1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_DESKcvInput2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_DESKcvInput3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_DesKCVResultXOR, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_DesXOR, 2, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 536);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1350, 212);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // txt_DesInputdata1
            // 
            this.txt_DesInputdata1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DesInputdata1.AnimateReadOnly = false;
            this.txt_DesInputdata1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DesInputdata1.Depth = 0;
            this.txt_DesInputdata1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DesInputdata1.Hint = "Input Data 1";
            this.txt_DesInputdata1.LeadingIcon = null;
            this.txt_DesInputdata1.Location = new System.Drawing.Point(3, 3);
            this.txt_DesInputdata1.MaxLength = 48;
            this.txt_DesInputdata1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DesInputdata1.Multiline = false;
            this.txt_DesInputdata1.Name = "txt_DesInputdata1";
            this.txt_DesInputdata1.Size = new System.Drawing.Size(939, 50);
            this.txt_DesInputdata1.TabIndex = 0;
            this.txt_DesInputdata1.Text = "";
            this.txt_DesInputdata1.TrailingIcon = null;
            this.txt_DesInputdata1.TextChanged += new System.EventHandler(this.txt_DesInputdata1_TextChanged);
            this.txt_DesInputdata1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DesInputdata1_KeyPress);
            // 
            // txt_DesInputdata2
            // 
            this.txt_DesInputdata2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DesInputdata2.AnimateReadOnly = false;
            this.txt_DesInputdata2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DesInputdata2.Depth = 0;
            this.txt_DesInputdata2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DesInputdata2.Hint = "Input Data 2";
            this.txt_DesInputdata2.LeadingIcon = null;
            this.txt_DesInputdata2.Location = new System.Drawing.Point(3, 56);
            this.txt_DesInputdata2.MaxLength = 48;
            this.txt_DesInputdata2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DesInputdata2.Multiline = false;
            this.txt_DesInputdata2.Name = "txt_DesInputdata2";
            this.txt_DesInputdata2.Size = new System.Drawing.Size(939, 50);
            this.txt_DesInputdata2.TabIndex = 1;
            this.txt_DesInputdata2.Text = "";
            this.txt_DesInputdata2.TrailingIcon = null;
            this.txt_DesInputdata2.TextChanged += new System.EventHandler(this.txt_DesInputdata2_TextChanged);
            this.txt_DesInputdata2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DesInputdata2_KeyPress);
            // 
            // txt_DesInputdata3
            // 
            this.txt_DesInputdata3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DesInputdata3.AnimateReadOnly = false;
            this.txt_DesInputdata3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DesInputdata3.Depth = 0;
            this.txt_DesInputdata3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DesInputdata3.Hint = "Input Data 3";
            this.txt_DesInputdata3.LeadingIcon = null;
            this.txt_DesInputdata3.Location = new System.Drawing.Point(3, 109);
            this.txt_DesInputdata3.MaxLength = 48;
            this.txt_DesInputdata3.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DesInputdata3.Multiline = false;
            this.txt_DesInputdata3.Name = "txt_DesInputdata3";
            this.txt_DesInputdata3.Size = new System.Drawing.Size(939, 50);
            this.txt_DesInputdata3.TabIndex = 2;
            this.txt_DesInputdata3.Text = "";
            this.txt_DesInputdata3.TrailingIcon = null;
            this.txt_DesInputdata3.TextChanged += new System.EventHandler(this.txt_DesInputdata3_TextChanged);
            this.txt_DesInputdata3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DesInputdata3_KeyPress);
            // 
            // txt_DesResultXOR
            // 
            this.txt_DesResultXOR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DesResultXOR.AnimateReadOnly = false;
            this.txt_DesResultXOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DesResultXOR.Depth = 0;
            this.txt_DesResultXOR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DesResultXOR.Hint = "Result";
            this.txt_DesResultXOR.LeadingIcon = null;
            this.txt_DesResultXOR.Location = new System.Drawing.Point(3, 162);
            this.txt_DesResultXOR.MaxLength = 48;
            this.txt_DesResultXOR.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DesResultXOR.Multiline = false;
            this.txt_DesResultXOR.Name = "txt_DesResultXOR";
            this.txt_DesResultXOR.Size = new System.Drawing.Size(939, 50);
            this.txt_DesResultXOR.TabIndex = 3;
            this.txt_DesResultXOR.Text = "";
            this.txt_DesResultXOR.TrailingIcon = null;
            // 
            // txt_DESKcvInput1
            // 
            this.txt_DESKcvInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DESKcvInput1.AnimateReadOnly = false;
            this.txt_DESKcvInput1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESKcvInput1.Depth = 0;
            this.txt_DESKcvInput1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESKcvInput1.Hint = "KCV";
            this.txt_DESKcvInput1.LeadingIcon = null;
            this.txt_DESKcvInput1.Location = new System.Drawing.Point(948, 3);
            this.txt_DESKcvInput1.MaxLength = 8;
            this.txt_DESKcvInput1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DESKcvInput1.Multiline = false;
            this.txt_DESKcvInput1.Name = "txt_DESKcvInput1";
            this.txt_DESKcvInput1.Size = new System.Drawing.Size(196, 50);
            this.txt_DESKcvInput1.TabIndex = 4;
            this.txt_DESKcvInput1.Text = "";
            this.txt_DESKcvInput1.TrailingIcon = null;
            this.txt_DESKcvInput1.TextChanged += new System.EventHandler(this.txt_DESKcvInput1_TextChanged);
            // 
            // txt_DESKcvInput2
            // 
            this.txt_DESKcvInput2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DESKcvInput2.AnimateReadOnly = false;
            this.txt_DESKcvInput2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESKcvInput2.Depth = 0;
            this.txt_DESKcvInput2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESKcvInput2.Hint = "KCV";
            this.txt_DESKcvInput2.LeadingIcon = null;
            this.txt_DESKcvInput2.Location = new System.Drawing.Point(948, 56);
            this.txt_DESKcvInput2.MaxLength = 8;
            this.txt_DESKcvInput2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DESKcvInput2.Multiline = false;
            this.txt_DESKcvInput2.Name = "txt_DESKcvInput2";
            this.txt_DESKcvInput2.Size = new System.Drawing.Size(196, 50);
            this.txt_DESKcvInput2.TabIndex = 5;
            this.txt_DESKcvInput2.Text = "";
            this.txt_DESKcvInput2.TrailingIcon = null;
            this.txt_DESKcvInput2.TextChanged += new System.EventHandler(this.txt_DESKcvInput2_TextChanged);
            // 
            // txt_DESKcvInput3
            // 
            this.txt_DESKcvInput3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DESKcvInput3.AnimateReadOnly = false;
            this.txt_DESKcvInput3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESKcvInput3.Depth = 0;
            this.txt_DESKcvInput3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESKcvInput3.Hint = "KCV";
            this.txt_DESKcvInput3.LeadingIcon = null;
            this.txt_DESKcvInput3.Location = new System.Drawing.Point(948, 109);
            this.txt_DESKcvInput3.MaxLength = 8;
            this.txt_DESKcvInput3.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DESKcvInput3.Multiline = false;
            this.txt_DESKcvInput3.Name = "txt_DESKcvInput3";
            this.txt_DESKcvInput3.Size = new System.Drawing.Size(196, 50);
            this.txt_DESKcvInput3.TabIndex = 6;
            this.txt_DESKcvInput3.Text = "";
            this.txt_DESKcvInput3.TrailingIcon = null;
            this.txt_DESKcvInput3.TextChanged += new System.EventHandler(this.txt_DESKcvInput3_TextChanged);
            // 
            // txt_DesKCVResultXOR
            // 
            this.txt_DesKCVResultXOR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DesKCVResultXOR.AnimateReadOnly = false;
            this.txt_DesKCVResultXOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DesKCVResultXOR.Depth = 0;
            this.txt_DesKCVResultXOR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DesKCVResultXOR.Hint = "KCV";
            this.txt_DesKCVResultXOR.LeadingIcon = null;
            this.txt_DesKCVResultXOR.Location = new System.Drawing.Point(948, 162);
            this.txt_DesKCVResultXOR.MaxLength = 8;
            this.txt_DesKCVResultXOR.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DesKCVResultXOR.Multiline = false;
            this.txt_DesKCVResultXOR.Name = "txt_DesKCVResultXOR";
            this.txt_DesKCVResultXOR.Size = new System.Drawing.Size(196, 50);
            this.txt_DesKCVResultXOR.TabIndex = 7;
            this.txt_DesKCVResultXOR.Text = "";
            this.txt_DesKCVResultXOR.TrailingIcon = null;
            this.txt_DesKCVResultXOR.TextChanged += new System.EventHandler(this.txt_DesKCVResultXOR_TextChanged);
            // 
            // btn_DesXOR
            // 
            this.btn_DesXOR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DesXOR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DesXOR.Depth = 0;
            this.btn_DesXOR.HighEmphasis = true;
            this.btn_DesXOR.Icon = null;
            this.btn_DesXOR.Location = new System.Drawing.Point(1151, 112);
            this.btn_DesXOR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_DesXOR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DesXOR.Name = "btn_DesXOR";
            this.btn_DesXOR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_DesXOR.Size = new System.Drawing.Size(64, 36);
            this.btn_DesXOR.TabIndex = 8;
            this.btn_DesXOR.Text = "XOR";
            this.btn_DesXOR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DesXOR.UseAccentColor = false;
            this.btn_DesXOR.UseVisualStyleBackColor = true;
            this.btn_DesXOR.Click += new System.EventHandler(this.btn_DesXOR_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox15, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox13, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox14, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1335, 159);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // groupBox15
            // 
            this.groupBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox15.Controls.Add(this.btn_DesOddParity);
            this.groupBox15.Controls.Add(this.materialLabel11);
            this.groupBox15.Controls.Add(this.rdb_DESDafualtZMK);
            this.groupBox15.Controls.Add(this.rdb_DESDafualtLMK);
            this.groupBox15.Controls.Add(this.rdb_DESClear);
            this.groupBox15.Controls.Add(this.txt_DESValue);
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(568, 153);
            this.groupBox15.TabIndex = 6;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "AES Key Infomation";
            // 
            // btn_DesOddParity
            // 
            this.btn_DesOddParity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DesOddParity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DesOddParity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DesOddParity.Depth = 0;
            this.btn_DesOddParity.HighEmphasis = true;
            this.btn_DesOddParity.Icon = null;
            this.btn_DesOddParity.Location = new System.Drawing.Point(456, 108);
            this.btn_DesOddParity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_DesOddParity.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DesOddParity.Name = "btn_DesOddParity";
            this.btn_DesOddParity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_DesOddParity.Size = new System.Drawing.Size(105, 36);
            this.btn_DesOddParity.TabIndex = 3;
            this.btn_DesOddParity.Text = "Odd Parity";
            this.btn_DesOddParity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DesOddParity.UseAccentColor = false;
            this.btn_DesOddParity.UseVisualStyleBackColor = true;
            this.btn_DesOddParity.Click += new System.EventHandler(this.btn_DesOddParity_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(0, 39);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(85, 19);
            this.materialLabel11.TabIndex = 4;
            this.materialLabel11.Text = "Wrapped by";
            // 
            // rdb_DESDafualtZMK
            // 
            this.rdb_DESDafualtZMK.AutoSize = true;
            this.rdb_DESDafualtZMK.Depth = 0;
            this.rdb_DESDafualtZMK.Location = new System.Drawing.Point(444, 29);
            this.rdb_DESDafualtZMK.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_DESDafualtZMK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_DESDafualtZMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_DESDafualtZMK.Name = "rdb_DESDafualtZMK";
            this.rdb_DESDafualtZMK.Ripple = true;
            this.rdb_DESDafualtZMK.Size = new System.Drawing.Size(125, 37);
            this.rdb_DESDafualtZMK.TabIndex = 3;
            this.rdb_DESDafualtZMK.TabStop = true;
            this.rdb_DESDafualtZMK.Text = "Default ZMK";
            this.rdb_DESDafualtZMK.UseVisualStyleBackColor = true;
            // 
            // rdb_DESDafualtLMK
            // 
            this.rdb_DESDafualtLMK.AutoSize = true;
            this.rdb_DESDafualtLMK.Depth = 0;
            this.rdb_DESDafualtLMK.Location = new System.Drawing.Point(268, 29);
            this.rdb_DESDafualtLMK.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_DESDafualtLMK.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_DESDafualtLMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_DESDafualtLMK.Name = "rdb_DESDafualtLMK";
            this.rdb_DESDafualtLMK.Ripple = true;
            this.rdb_DESDafualtLMK.Size = new System.Drawing.Size(124, 37);
            this.rdb_DESDafualtLMK.TabIndex = 2;
            this.rdb_DESDafualtLMK.TabStop = true;
            this.rdb_DESDafualtLMK.Text = "Default LMK";
            this.rdb_DESDafualtLMK.UseVisualStyleBackColor = true;
            // 
            // rdb_DESClear
            // 
            this.rdb_DESClear.AutoSize = true;
            this.rdb_DESClear.Depth = 0;
            this.rdb_DESClear.Location = new System.Drawing.Point(160, 29);
            this.rdb_DESClear.Margin = new System.Windows.Forms.Padding(0);
            this.rdb_DESClear.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb_DESClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb_DESClear.Name = "rdb_DESClear";
            this.rdb_DESClear.Ripple = true;
            this.rdb_DESClear.Size = new System.Drawing.Size(71, 37);
            this.rdb_DESClear.TabIndex = 1;
            this.rdb_DESClear.TabStop = true;
            this.rdb_DESClear.Text = "Clear";
            this.rdb_DESClear.UseVisualStyleBackColor = true;
            // 
            // txt_DESValue
            // 
            this.txt_DESValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DESValue.AnimateReadOnly = false;
            this.txt_DESValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESValue.Depth = 0;
            this.txt_DESValue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESValue.Hint = "Value";
            this.txt_DESValue.LeadingIcon = null;
            this.txt_DESValue.Location = new System.Drawing.Point(6, 97);
            this.txt_DESValue.MaxLength = 48;
            this.txt_DESValue.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DESValue.Multiline = false;
            this.txt_DESValue.Name = "txt_DESValue";
            this.txt_DESValue.Size = new System.Drawing.Size(442, 50);
            this.txt_DESValue.TabIndex = 0;
            this.txt_DESValue.Text = "";
            this.txt_DESValue.TrailingIcon = null;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.txt_DESKCV);
            this.groupBox13.Controls.Add(this.btn_DESGetKcv);
            this.groupBox13.Location = new System.Drawing.Point(577, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(180, 153);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "KCV";
            // 
            // txt_DESKCV
            // 
            this.txt_DESKCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DESKCV.AnimateReadOnly = false;
            this.txt_DESKCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESKCV.Depth = 0;
            this.txt_DESKCV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESKCV.LeadingIcon = null;
            this.txt_DESKCV.Location = new System.Drawing.Point(7, 97);
            this.txt_DESKCV.MaxLength = 6;
            this.txt_DESKCV.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DESKCV.Multiline = false;
            this.txt_DESKCV.Name = "txt_DESKCV";
            this.txt_DESKCV.Size = new System.Drawing.Size(185, 50);
            this.txt_DESKCV.TabIndex = 2;
            this.txt_DESKCV.Text = "";
            this.txt_DESKCV.TrailingIcon = null;
            this.txt_DESKCV.TextChanged += new System.EventHandler(this.txt_DESKCV_TextChanged);
            // 
            // btn_DESGetKcv
            // 
            this.btn_DESGetKcv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DESGetKcv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DESGetKcv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DESGetKcv.Depth = 0;
            this.btn_DESGetKcv.HighEmphasis = true;
            this.btn_DESGetKcv.Icon = null;
            this.btn_DESGetKcv.Location = new System.Drawing.Point(51, 24);
            this.btn_DESGetKcv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_DESGetKcv.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DESGetKcv.Name = "btn_DESGetKcv";
            this.btn_DESGetKcv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_DESGetKcv.Size = new System.Drawing.Size(81, 36);
            this.btn_DESGetKcv.TabIndex = 2;
            this.btn_DESGetKcv.Text = "Get KCV";
            this.btn_DESGetKcv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DESGetKcv.UseAccentColor = false;
            this.btn_DESGetKcv.UseVisualStyleBackColor = true;
            this.btn_DESGetKcv.Click += new System.EventHandler(this.btn_DESGetKcv_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox14.Controls.Add(this.cbb_desMode);
            this.groupBox14.Controls.Add(this.txt_DESIV);
            this.groupBox14.Controls.Add(this.materialLabel10);
            this.groupBox14.Location = new System.Drawing.Point(763, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(569, 153);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Encryption Mode";
            // 
            // cbb_desMode
            // 
            this.cbb_desMode.AutoResize = false;
            this.cbb_desMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_desMode.Depth = 0;
            this.cbb_desMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_desMode.DropDownHeight = 174;
            this.cbb_desMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_desMode.DropDownWidth = 121;
            this.cbb_desMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_desMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_desMode.FormattingEnabled = true;
            this.cbb_desMode.IntegralHeight = false;
            this.cbb_desMode.ItemHeight = 43;
            this.cbb_desMode.Items.AddRange(new object[] {
            "ECB",
            "CBC"});
            this.cbb_desMode.Location = new System.Drawing.Point(138, 24);
            this.cbb_desMode.MaxDropDownItems = 4;
            this.cbb_desMode.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_desMode.Name = "cbb_desMode";
            this.cbb_desMode.Size = new System.Drawing.Size(255, 49);
            this.cbb_desMode.StartIndex = 0;
            this.cbb_desMode.TabIndex = 7;
            this.cbb_desMode.SelectedIndexChanged += new System.EventHandler(this.cbb_desMode_SelectedIndexChanged);
            // 
            // txt_DESIV
            // 
            this.txt_DESIV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DESIV.AnimateReadOnly = false;
            this.txt_DESIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESIV.Depth = 0;
            this.txt_DESIV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESIV.Hint = "IV:";
            this.txt_DESIV.LeadingIcon = null;
            this.txt_DESIV.Location = new System.Drawing.Point(6, 97);
            this.txt_DESIV.MaxLength = 16;
            this.txt_DESIV.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_DESIV.Multiline = false;
            this.txt_DESIV.Name = "txt_DESIV";
            this.txt_DESIV.Size = new System.Drawing.Size(557, 50);
            this.txt_DESIV.TabIndex = 5;
            this.txt_DESIV.Text = "";
            this.txt_DESIV.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(54, 41);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(45, 19);
            this.materialLabel10.TabIndex = 5;
            this.materialLabel10.Text = "Mode:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox16, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox17, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 193);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 291);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_DesDecrypt);
            this.panel2.Controls.Add(this.btn_DesEncrypt);
            this.panel2.Location = new System.Drawing.Point(578, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 285);
            this.panel2.TabIndex = 2;
            // 
            // btn_DesDecrypt
            // 
            this.btn_DesDecrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DesDecrypt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DesDecrypt.Depth = 0;
            this.btn_DesDecrypt.HighEmphasis = true;
            this.btn_DesDecrypt.Icon = null;
            this.btn_DesDecrypt.Location = new System.Drawing.Point(38, 159);
            this.btn_DesDecrypt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_DesDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DesDecrypt.Name = "btn_DesDecrypt";
            this.btn_DesDecrypt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_DesDecrypt.Size = new System.Drawing.Size(108, 36);
            this.btn_DesDecrypt.TabIndex = 5;
            this.btn_DesDecrypt.Text = "<<<Decrypt";
            this.btn_DesDecrypt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DesDecrypt.UseAccentColor = false;
            this.btn_DesDecrypt.UseVisualStyleBackColor = true;
            this.btn_DesDecrypt.Click += new System.EventHandler(this.btn_DesDecrypt_Click);
            // 
            // btn_DesEncrypt
            // 
            this.btn_DesEncrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DesEncrypt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DesEncrypt.Depth = 0;
            this.btn_DesEncrypt.HighEmphasis = true;
            this.btn_DesEncrypt.Icon = null;
            this.btn_DesEncrypt.Location = new System.Drawing.Point(38, 54);
            this.btn_DesEncrypt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_DesEncrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DesEncrypt.Name = "btn_DesEncrypt";
            this.btn_DesEncrypt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_DesEncrypt.Size = new System.Drawing.Size(113, 36);
            this.btn_DesEncrypt.TabIndex = 4;
            this.btn_DesEncrypt.Text = "Encrypt >>>";
            this.btn_DesEncrypt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DesEncrypt.UseAccentColor = false;
            this.btn_DesEncrypt.UseVisualStyleBackColor = true;
            this.btn_DesEncrypt.Click += new System.EventHandler(this.btn_DesEncrypt_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.txt_DESClearData);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Location = new System.Drawing.Point(3, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(569, 285);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Clear Data";
            // 
            // txt_DESClearData
            // 
            this.txt_DESClearData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_DESClearData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESClearData.Depth = 0;
            this.txt_DESClearData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_DESClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESClearData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_DESClearData.Location = new System.Drawing.Point(3, 18);
            this.txt_DESClearData.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_DESClearData.Name = "txt_DESClearData";
            this.txt_DESClearData.Size = new System.Drawing.Size(563, 264);
            this.txt_DESClearData.TabIndex = 0;
            this.txt_DESClearData.Text = "";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txt_DESEncryptData);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Location = new System.Drawing.Point(765, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(570, 285);
            this.groupBox17.TabIndex = 4;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Encrypted Data";
            // 
            // txt_DESEncryptData
            // 
            this.txt_DESEncryptData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_DESEncryptData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DESEncryptData.Depth = 0;
            this.txt_DESEncryptData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_DESEncryptData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DESEncryptData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_DESEncryptData.Location = new System.Drawing.Point(3, 18);
            this.txt_DESEncryptData.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_DESEncryptData.Name = "txt_DESEncryptData";
            this.txt_DESEncryptData.Size = new System.Drawing.Size(564, 264);
            this.txt_DESEncryptData.TabIndex = 0;
            this.txt_DESEncryptData.Text = "";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtUsername);
            this.tabPage7.Controls.Add(this.btnLogin);
            this.tabPage7.Controls.Add(this.txtPassword);
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1356, 795);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "aes.png");
            this.menuIconList.Images.SetKeyName(1, "compare.png");
            this.menuIconList.Images.SetKeyName(2, "masterkey.png");
            this.menuIconList.Images.SetKeyName(3, "smartcard.png");
            this.menuIconList.Images.SetKeyName(4, "smartcard_reader.png");
            this.menuIconList.Images.SetKeyName(5, "des.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 950);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.darkModeSwitch);
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(400, 246);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart card utility";
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton verify;
        private MaterialSkin.Controls.MaterialButton OpenFile1;
        private MaterialSkin.Controls.MaterialButton Openfile2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialComboBox cbb_system;
        private System.Windows.Forms.DataGridView dt_gv;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private ToolStripMenuItem toolStripMenuItem1;
        private TabPage tabPage7;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btn_powerOff;
        private MaterialSkin.Controls.MaterialButton btn_powerOn;
        private MaterialSkin.Controls.MaterialComboBox cbb_cardReader1;
        private MaterialSkin.Controls.MaterialButton btn_getATR;
        private MaterialSkin.Controls.MaterialTextBox txt_getATR;
        private MaterialSkin.Controls.MaterialButton btn_getsn;
        private MaterialSkin.Controls.MaterialTextBox txt_serialNumber;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btn_execuetAPDU;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_APDU;
        private MaterialSkin.Controls.MaterialComboBox cbb_typeAPDU;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_message;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cbb_cardReader2;
        private GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialTextBox txt_kmcKCV1;
        private MaterialSkin.Controls.MaterialComboBox cbb_kmcValue3;
        private MaterialSkin.Controls.MaterialComboBox cbb_kmcValue2;
        private MaterialSkin.Controls.MaterialComboBox cbb_kmcValue1;
        private MaterialSkin.Controls.MaterialButton btn_readerRefresh;
        private MaterialSkin.Controls.MaterialRadioButton rdb_noKMC;
        private MaterialSkin.Controls.MaterialRadioButton rdb_fixedENC;
        private MaterialSkin.Controls.MaterialRadioButton rdb_deriveKMC;
        private MaterialSkin.Controls.MaterialTextBox txt_kmcKCV3;
        private MaterialSkin.Controls.MaterialTextBox txt_kmcKCV2;
        private MaterialSkin.Controls.MaterialButton btn_appDelete;
        private MaterialSkin.Controls.MaterialButton btn_cardInfo;
        private GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialComboBox cbb_cardManager;
        private MaterialSkin.Controls.MaterialButton btn_extAuth;
        private MaterialSkin.Controls.MaterialTextBox txt_AID;
        private MaterialSkin.Controls.MaterialTextBox txt_ATR;
        private MaterialSkin.Controls.MaterialTextBox txt_osRelease_date;
        private MaterialSkin.Controls.MaterialTextBox txt_osIdentifier;
        private MaterialSkin.Controls.MaterialTextBox txt_ICType;
        private MaterialSkin.Controls.MaterialTextBox txt_ICFabricator;
        private MaterialSkin.Controls.MaterialTextBox txt_ICMPDate;
        private MaterialSkin.Controls.MaterialTextBox txt_ICMod;
        private MaterialSkin.Controls.MaterialTextBox txt_IC_batchIdentifier;
        private MaterialSkin.Controls.MaterialTextBox txt_icSerailnumber;
        private MaterialSkin.Controls.MaterialTextBox txt_ICFabricatorDate;
        private MaterialSkin.Controls.MaterialTextBox txt_osRelease_level;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txt_ICEmbeddingDate;
        private MaterialSkin.Controls.MaterialTextBox txt_ICCManufacturer;
        private MaterialSkin.Controls.MaterialTextBox txt_ICPersoEquipID;
        private MaterialSkin.Controls.MaterialTextBox txt_ICPersoDate;
        private MaterialSkin.Controls.MaterialTextBox txt_ICPersonalizer;
        private MaterialSkin.Controls.MaterialTextBox txt_PrePersoEqp;
        private MaterialSkin.Controls.MaterialTextBox txt_PrePersoDate;
        private MaterialSkin.Controls.MaterialTextBox txt_ICPrePersonalizer;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton btn_refresh2;
        private MaterialSkin.Controls.MaterialComboBox cbb_cardReader3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialRadioButton rdo_old_no_kmc;
        private MaterialSkin.Controls.MaterialRadioButton rdo_old_kmc_fixed;
        private MaterialSkin.Controls.MaterialRadioButton rdo_old_derive_kmc;
        private MaterialSkin.Controls.MaterialTextBox txt_old_kmc_kcv3;
        private MaterialSkin.Controls.MaterialTextBox txt_old_kmc_kcv2;
        private MaterialSkin.Controls.MaterialTextBox txt_old_kmc_kcv1;
        private MaterialSkin.Controls.MaterialComboBox cbb_old_no_kmc;
        private MaterialSkin.Controls.MaterialComboBox cbb_old_kmc_fixed;
        private MaterialSkin.Controls.MaterialComboBox cbb_old_kmc_key;
        private MaterialSkin.Controls.MaterialComboBox cbb_cardmanager2;
        private MaterialSkin.Controls.MaterialButton btn_updateCardmanager;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_processMessage;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private GroupBox groupBox7;
        private MaterialSkin.Controls.MaterialRadioButton rdo_new_kmc_fixed;
        private MaterialSkin.Controls.MaterialRadioButton rdo_new_derive_kmc;
        private MaterialSkin.Controls.MaterialTextBox txt_new_kmc_kcv3;
        private MaterialSkin.Controls.MaterialTextBox txt_new_kmc_kcv2;
        private MaterialSkin.Controls.MaterialTextBox txt_new_kmc_kcv1;
        private MaterialSkin.Controls.MaterialComboBox cbb_new_no_kmc;
        private MaterialSkin.Controls.MaterialComboBox cbb_new_kmc_fixed;
        private MaterialSkin.Controls.MaterialComboBox cbb_new_kmc_key;
        private GroupBox groupBox10;
        private GroupBox groupBox9;
        private GroupBox groupBox8;
        private MaterialSkin.Controls.MaterialTextBox txt_AESKcv;
        private MaterialSkin.Controls.MaterialButton btn_getKCV;
        private MaterialSkin.Controls.MaterialRadioButton rdb_defualtZMK;
        private MaterialSkin.Controls.MaterialRadioButton rdb_defualtLMK;
        private MaterialSkin.Controls.MaterialRadioButton rdb_clearAES;
        private MaterialSkin.Controls.MaterialTextBox txt_valueAES;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txt_ivAES;
        private MaterialSkin.Controls.MaterialButton btn_AEScmac;
        private MaterialSkin.Controls.MaterialButton btn_AESdecrypt;
        private MaterialSkin.Controls.MaterialButton btn_AESencrypt;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btn_DesDecrypt;
        private MaterialSkin.Controls.MaterialButton btn_DesEncrypt;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox15;
        private MaterialSkin.Controls.MaterialButton btn_DesOddParity;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialRadioButton rdb_DESDafualtZMK;
        private MaterialSkin.Controls.MaterialRadioButton rdb_DESDafualtLMK;
        private MaterialSkin.Controls.MaterialRadioButton rdb_DESClear;
        private MaterialSkin.Controls.MaterialTextBox txt_DESValue;
        private GroupBox groupBox13;
        private MaterialSkin.Controls.MaterialTextBox txt_DESKCV;
        private MaterialSkin.Controls.MaterialButton btn_DESGetKcv;
        private GroupBox groupBox14;
        private MaterialSkin.Controls.MaterialTextBox txt_DESIV;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialTextBox txt_DesInputdata1;
        private MaterialSkin.Controls.MaterialTextBox txt_DesInputdata2;
        private MaterialSkin.Controls.MaterialTextBox txt_DesInputdata3;
        private MaterialSkin.Controls.MaterialTextBox txt_DesResultXOR;
        private MaterialSkin.Controls.MaterialTextBox txt_DESKcvInput1;
        private MaterialSkin.Controls.MaterialTextBox txt_DESKcvInput2;
        private MaterialSkin.Controls.MaterialTextBox txt_DESKcvInput3;
        private MaterialSkin.Controls.MaterialTextBox txt_DesKCVResultXOR;
        private MaterialSkin.Controls.MaterialButton btn_DesXOR;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private GroupBox groupBox11;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_AESCleardata;
        private GroupBox groupBox12;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_AESencrypt;
        private GroupBox groupBox16;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_DESClearData;
        private GroupBox groupBox17;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_DESEncryptData;
        private MaterialSkin.Controls.MaterialButton btn_openfileAPDU;
        private ImageList menuIconList;
        private MaterialSkin.Controls.MaterialComboBox cbb_aesEncMode;
        private MaterialSkin.Controls.MaterialComboBox cbb_desMode;
        private TreeView tv_card;
        private Panel panel4;
        private Panel panel5;
    }
}

