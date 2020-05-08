namespace SSLCertBundleGenerator
{
    partial class FormSSLCertBundleGenerator
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSSLCertBundleGenerator));
            this.groupBoxSSLOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxClientAuthentication = new System.Windows.Forms.CheckBox();
            this.checkBoxServerAuthentication = new System.Windows.Forms.CheckBox();
            this.labelSAN = new System.Windows.Forms.Label();
            this.textBoxSAN = new System.Windows.Forms.TextBox();
            this.groupBoxExportOptions = new System.Windows.Forms.GroupBox();
            this.buttonToogleShowPassword = new System.Windows.Forms.Button();
            this.labelSavePath = new System.Windows.Forms.Label();
            this.buttonBrowseSavePath = new System.Windows.Forms.Button();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.checkBoxCertExpCrt = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxSubjectDN = new System.Windows.Forms.GroupBox();
            this.labelO = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelOU = new System.Windows.Forms.Label();
            this.textBoxCN = new System.Windows.Forms.TextBox();
            this.textBoxOU = new System.Windows.Forms.TextBox();
            this.labelCN = new System.Windows.Forms.Label();
            this.textBoxO = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxCertificateOptions = new System.Windows.Forms.GroupBox();
            this.labelBits = new System.Windows.Forms.Label();
            this.labelMonths = new System.Windows.Forms.Label();
            this.comboBoxValidity = new System.Windows.Forms.ComboBox();
            this.labelValidity = new System.Windows.Forms.Label();
            this.comboBoxKeySize = new System.Windows.Forms.ComboBox();
            this.labelKeySize = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.numericUpDownSerialNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSSLOptions.SuspendLayout();
            this.groupBoxExportOptions.SuspendLayout();
            this.groupBoxSubjectDN.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxCertificateOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSSLOptions
            // 
            this.groupBoxSSLOptions.Controls.Add(this.checkBoxClientAuthentication);
            this.groupBoxSSLOptions.Controls.Add(this.checkBoxServerAuthentication);
            this.groupBoxSSLOptions.Controls.Add(this.labelSAN);
            this.groupBoxSSLOptions.Controls.Add(this.textBoxSAN);
            this.groupBoxSSLOptions.Location = new System.Drawing.Point(12, 271);
            this.groupBoxSSLOptions.Name = "groupBoxSSLOptions";
            this.groupBoxSSLOptions.Size = new System.Drawing.Size(320, 82);
            this.groupBoxSSLOptions.TabIndex = 19;
            this.groupBoxSSLOptions.TabStop = false;
            this.groupBoxSSLOptions.Text = "SSL Options";
            // 
            // checkBoxClientAuthentication
            // 
            this.checkBoxClientAuthentication.AutoSize = true;
            this.checkBoxClientAuthentication.Location = new System.Drawing.Point(145, 54);
            this.checkBoxClientAuthentication.Name = "checkBoxClientAuthentication";
            this.checkBoxClientAuthentication.Size = new System.Drawing.Size(123, 17);
            this.checkBoxClientAuthentication.TabIndex = 23;
            this.checkBoxClientAuthentication.Text = "Client Authentication";
            this.checkBoxClientAuthentication.UseVisualStyleBackColor = true;
            // 
            // checkBoxServerAuthentication
            // 
            this.checkBoxServerAuthentication.AutoSize = true;
            this.checkBoxServerAuthentication.Location = new System.Drawing.Point(11, 54);
            this.checkBoxServerAuthentication.Name = "checkBoxServerAuthentication";
            this.checkBoxServerAuthentication.Size = new System.Drawing.Size(128, 17);
            this.checkBoxServerAuthentication.TabIndex = 22;
            this.checkBoxServerAuthentication.Text = "Server Authentication";
            this.checkBoxServerAuthentication.UseVisualStyleBackColor = true;
            // 
            // labelSAN
            // 
            this.labelSAN.AutoSize = true;
            this.labelSAN.Location = new System.Drawing.Point(30, 22);
            this.labelSAN.Name = "labelSAN";
            this.labelSAN.Size = new System.Drawing.Size(37, 13);
            this.labelSAN.TabIndex = 20;
            this.labelSAN.Text = "SANs:";
            // 
            // textBoxSAN
            // 
            this.textBoxSAN.Location = new System.Drawing.Point(70, 19);
            this.textBoxSAN.Name = "textBoxSAN";
            this.textBoxSAN.Size = new System.Drawing.Size(205, 20);
            this.textBoxSAN.TabIndex = 21;
            // 
            // groupBoxExportOptions
            // 
            this.groupBoxExportOptions.Controls.Add(this.buttonToogleShowPassword);
            this.groupBoxExportOptions.Controls.Add(this.labelSavePath);
            this.groupBoxExportOptions.Controls.Add(this.buttonBrowseSavePath);
            this.groupBoxExportOptions.Controls.Add(this.textBoxSavePath);
            this.groupBoxExportOptions.Controls.Add(this.checkBoxCertExpCrt);
            this.groupBoxExportOptions.Controls.Add(this.textBoxPassword);
            this.groupBoxExportOptions.Controls.Add(this.labelPassword);
            this.groupBoxExportOptions.Location = new System.Drawing.Point(12, 359);
            this.groupBoxExportOptions.Name = "groupBoxExportOptions";
            this.groupBoxExportOptions.Size = new System.Drawing.Size(320, 127);
            this.groupBoxExportOptions.TabIndex = 24;
            this.groupBoxExportOptions.TabStop = false;
            this.groupBoxExportOptions.Text = "Export Options";
            // 
            // buttonToogleShowPassword
            // 
            this.buttonToogleShowPassword.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonToogleShowPassword.Location = new System.Drawing.Point(280, 29);
            this.buttonToogleShowPassword.Name = "buttonToogleShowPassword";
            this.buttonToogleShowPassword.Size = new System.Drawing.Size(34, 20);
            this.buttonToogleShowPassword.TabIndex = 27;
            this.buttonToogleShowPassword.Text = "···";
            this.buttonToogleShowPassword.UseVisualStyleBackColor = true;
            this.buttonToogleShowPassword.Click += new System.EventHandler(this.ButtonShowPassword_Click);
            // 
            // labelSavePath
            // 
            this.labelSavePath.AutoSize = true;
            this.labelSavePath.Location = new System.Drawing.Point(7, 97);
            this.labelSavePath.Name = "labelSavePath";
            this.labelSavePath.Size = new System.Drawing.Size(60, 13);
            this.labelSavePath.TabIndex = 29;
            this.labelSavePath.Text = "Save Path:";
            // 
            // buttonBrowseSavePath
            // 
            this.buttonBrowseSavePath.Location = new System.Drawing.Point(280, 93);
            this.buttonBrowseSavePath.Name = "buttonBrowseSavePath";
            this.buttonBrowseSavePath.Size = new System.Drawing.Size(34, 20);
            this.buttonBrowseSavePath.TabIndex = 31;
            this.buttonBrowseSavePath.Text = "...";
            this.buttonBrowseSavePath.UseVisualStyleBackColor = true;
            this.buttonBrowseSavePath.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(70, 94);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(205, 20);
            this.textBoxSavePath.TabIndex = 30;
            // 
            // checkBoxCertExpCrt
            // 
            this.checkBoxCertExpCrt.AutoSize = true;
            this.checkBoxCertExpCrt.Location = new System.Drawing.Point(11, 65);
            this.checkBoxCertExpCrt.Name = "checkBoxCertExpCrt";
            this.checkBoxCertExpCrt.Size = new System.Drawing.Size(258, 17);
            this.checkBoxCertExpCrt.TabIndex = 28;
            this.checkBoxCertExpCrt.Text = "Export Public Key Certificate to binary format (.crt)";
            this.checkBoxCertExpCrt.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(70, 30);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(205, 20);
            this.textBoxPassword.TabIndex = 26;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(11, 33);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Password:";
            // 
            // groupBoxSubjectDN
            // 
            this.groupBoxSubjectDN.Controls.Add(this.labelO);
            this.groupBoxSubjectDN.Controls.Add(this.labelC);
            this.groupBoxSubjectDN.Controls.Add(this.labelOU);
            this.groupBoxSubjectDN.Controls.Add(this.textBoxCN);
            this.groupBoxSubjectDN.Controls.Add(this.textBoxOU);
            this.groupBoxSubjectDN.Controls.Add(this.labelCN);
            this.groupBoxSubjectDN.Controls.Add(this.textBoxO);
            this.groupBoxSubjectDN.Controls.Add(this.textBoxC);
            this.groupBoxSubjectDN.Location = new System.Drawing.Point(12, 27);
            this.groupBoxSubjectDN.Name = "groupBoxSubjectDN";
            this.groupBoxSubjectDN.Size = new System.Drawing.Size(320, 130);
            this.groupBoxSubjectDN.TabIndex = 1;
            this.groupBoxSubjectDN.TabStop = false;
            this.groupBoxSubjectDN.Text = "Subject DN";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(33, 50);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(69, 13);
            this.labelO.TabIndex = 4;
            this.labelO.Text = "Organization:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(56, 102);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(46, 13);
            this.labelC.TabIndex = 8;
            this.labelC.Text = "Country:";
            // 
            // labelOU
            // 
            this.labelOU.AutoSize = true;
            this.labelOU.Location = new System.Drawing.Point(11, 76);
            this.labelOU.Name = "labelOU";
            this.labelOU.Size = new System.Drawing.Size(91, 13);
            this.labelOU.TabIndex = 6;
            this.labelOU.Text = "Organization Unit:";
            // 
            // textBoxCN
            // 
            this.textBoxCN.Location = new System.Drawing.Point(108, 21);
            this.textBoxCN.Name = "textBoxCN";
            this.textBoxCN.Size = new System.Drawing.Size(115, 20);
            this.textBoxCN.TabIndex = 3;
            // 
            // textBoxOU
            // 
            this.textBoxOU.Location = new System.Drawing.Point(108, 73);
            this.textBoxOU.Name = "textBoxOU";
            this.textBoxOU.Size = new System.Drawing.Size(115, 20);
            this.textBoxOU.TabIndex = 7;
            // 
            // labelCN
            // 
            this.labelCN.AutoSize = true;
            this.labelCN.Location = new System.Drawing.Point(20, 24);
            this.labelCN.Name = "labelCN";
            this.labelCN.Size = new System.Drawing.Size(82, 13);
            this.labelCN.TabIndex = 2;
            this.labelCN.Text = "Common Name:";
            // 
            // textBoxO
            // 
            this.textBoxO.Location = new System.Drawing.Point(108, 47);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.Size = new System.Drawing.Size(115, 20);
            this.textBoxO.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(108, 99);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(115, 20);
            this.textBoxC.TabIndex = 9;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(134, 492);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 32;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuItemHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(344, 24);
            this.mainMenu.TabIndex = 33;
            this.mainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuFile.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 528);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(344, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 34;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel.Text = "{status}";
            // 
            // groupBoxCertificateOptions
            // 
            this.groupBoxCertificateOptions.Controls.Add(this.labelBits);
            this.groupBoxCertificateOptions.Controls.Add(this.labelMonths);
            this.groupBoxCertificateOptions.Controls.Add(this.comboBoxValidity);
            this.groupBoxCertificateOptions.Controls.Add(this.labelValidity);
            this.groupBoxCertificateOptions.Controls.Add(this.comboBoxKeySize);
            this.groupBoxCertificateOptions.Controls.Add(this.labelKeySize);
            this.groupBoxCertificateOptions.Controls.Add(this.labelSerialNumber);
            this.groupBoxCertificateOptions.Controls.Add(this.numericUpDownSerialNumber);
            this.groupBoxCertificateOptions.Location = new System.Drawing.Point(11, 163);
            this.groupBoxCertificateOptions.Name = "groupBoxCertificateOptions";
            this.groupBoxCertificateOptions.Size = new System.Drawing.Size(320, 102);
            this.groupBoxCertificateOptions.TabIndex = 10;
            this.groupBoxCertificateOptions.TabStop = false;
            this.groupBoxCertificateOptions.Text = "Certificate Options";
            // 
            // labelBits
            // 
            this.labelBits.AutoSize = true;
            this.labelBits.Location = new System.Drawing.Point(230, 49);
            this.labelBits.Name = "labelBits";
            this.labelBits.Size = new System.Drawing.Size(23, 13);
            this.labelBits.TabIndex = 15;
            this.labelBits.Text = "bits";
            // 
            // labelMonths
            // 
            this.labelMonths.AutoSize = true;
            this.labelMonths.Location = new System.Drawing.Point(230, 76);
            this.labelMonths.Name = "labelMonths";
            this.labelMonths.Size = new System.Drawing.Size(41, 13);
            this.labelMonths.TabIndex = 18;
            this.labelMonths.Text = "months";
            // 
            // comboBoxValidity
            // 
            this.comboBoxValidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValidity.FormattingEnabled = true;
            this.comboBoxValidity.Location = new System.Drawing.Point(109, 73);
            this.comboBoxValidity.Name = "comboBoxValidity";
            this.comboBoxValidity.Size = new System.Drawing.Size(115, 21);
            this.comboBoxValidity.TabIndex = 17;
            // 
            // labelValidity
            // 
            this.labelValidity.AutoSize = true;
            this.labelValidity.Location = new System.Drawing.Point(60, 76);
            this.labelValidity.Name = "labelValidity";
            this.labelValidity.Size = new System.Drawing.Size(43, 13);
            this.labelValidity.TabIndex = 16;
            this.labelValidity.Text = "Validity:";
            // 
            // comboBoxKeySize
            // 
            this.comboBoxKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeySize.FormattingEnabled = true;
            this.comboBoxKeySize.Location = new System.Drawing.Point(109, 46);
            this.comboBoxKeySize.Name = "comboBoxKeySize";
            this.comboBoxKeySize.Size = new System.Drawing.Size(115, 21);
            this.comboBoxKeySize.TabIndex = 14;
            // 
            // labelKeySize
            // 
            this.labelKeySize.AutoSize = true;
            this.labelKeySize.Location = new System.Drawing.Point(52, 49);
            this.labelKeySize.Name = "labelKeySize";
            this.labelKeySize.Size = new System.Drawing.Size(51, 13);
            this.labelKeySize.TabIndex = 13;
            this.labelKeySize.Text = "Key Size:";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(27, 22);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(76, 13);
            this.labelSerialNumber.TabIndex = 11;
            this.labelSerialNumber.Text = "Serial Number:";
            // 
            // numericUpDownSerialNumber
            // 
            this.numericUpDownSerialNumber.Location = new System.Drawing.Point(109, 19);
            this.numericUpDownSerialNumber.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownSerialNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSerialNumber.Name = "numericUpDownSerialNumber";
            this.numericUpDownSerialNumber.Size = new System.Drawing.Size(115, 20);
            this.numericUpDownSerialNumber.TabIndex = 12;
            this.numericUpDownSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSerialNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // FormSSLCertBundleGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 550);
            this.Controls.Add(this.groupBoxCertificateOptions);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxSSLOptions);
            this.Controls.Add(this.groupBoxExportOptions);
            this.Controls.Add(this.groupBoxSubjectDN);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "FormSSLCertBundleGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSLCertBundleGenerator {version}";
            this.groupBoxSSLOptions.ResumeLayout(false);
            this.groupBoxSSLOptions.PerformLayout();
            this.groupBoxExportOptions.ResumeLayout(false);
            this.groupBoxExportOptions.PerformLayout();
            this.groupBoxSubjectDN.ResumeLayout(false);
            this.groupBoxSubjectDN.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxCertificateOptions.ResumeLayout(false);
            this.groupBoxCertificateOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSSLOptions;
        private System.Windows.Forms.CheckBox checkBoxClientAuthentication;
        private System.Windows.Forms.CheckBox checkBoxServerAuthentication;
        private System.Windows.Forms.Label labelSAN;
        private System.Windows.Forms.TextBox textBoxSAN;
        private System.Windows.Forms.GroupBox groupBoxExportOptions;
        private System.Windows.Forms.CheckBox checkBoxCertExpCrt;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.GroupBox groupBoxSubjectDN;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelOU;
        private System.Windows.Forms.TextBox textBoxCN;
        private System.Windows.Forms.TextBox textBoxOU;
        private System.Windows.Forms.Label labelCN;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button buttonBrowseSavePath;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Label labelSavePath;
        private System.Windows.Forms.Button buttonToogleShowPassword;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupBoxCertificateOptions;
        private System.Windows.Forms.ComboBox comboBoxValidity;
        private System.Windows.Forms.Label labelValidity;
        private System.Windows.Forms.ComboBox comboBoxKeySize;
        private System.Windows.Forms.Label labelKeySize;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownSerialNumber;
        private System.Windows.Forms.Label labelMonths;
        private System.Windows.Forms.Label labelBits;
    }
}

