namespace CertUtil
{
    partial class FormCertUtil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCertUtil));
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBoxPrivateKeyFile = new System.Windows.Forms.GroupBox();
            this.buttonToogleShowPassword = new System.Windows.Forms.Button();
            this.buttonBrowsePath = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxExportOptions = new System.Windows.Forms.GroupBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxPrivateKeyFile.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.groupBoxExportOptions.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(33, 22);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(32, 13);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path:";
            // 
            // groupBoxPrivateKeyFile
            // 
            this.groupBoxPrivateKeyFile.Controls.Add(this.buttonToogleShowPassword);
            this.groupBoxPrivateKeyFile.Controls.Add(this.buttonBrowsePath);
            this.groupBoxPrivateKeyFile.Controls.Add(this.textBoxPassword);
            this.groupBoxPrivateKeyFile.Controls.Add(this.textBoxPath);
            this.groupBoxPrivateKeyFile.Controls.Add(this.labelPassword);
            this.groupBoxPrivateKeyFile.Controls.Add(this.labelPath);
            this.groupBoxPrivateKeyFile.Location = new System.Drawing.Point(12, 27);
            this.groupBoxPrivateKeyFile.Name = "groupBoxPrivateKeyFile";
            this.groupBoxPrivateKeyFile.Size = new System.Drawing.Size(295, 78);
            this.groupBoxPrivateKeyFile.TabIndex = 1;
            this.groupBoxPrivateKeyFile.TabStop = false;
            this.groupBoxPrivateKeyFile.Text = "Private Key File";
            // 
            // buttonToogleShowPassword
            // 
            this.buttonToogleShowPassword.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonToogleShowPassword.Location = new System.Drawing.Point(250, 44);
            this.buttonToogleShowPassword.Name = "buttonToogleShowPassword";
            this.buttonToogleShowPassword.Size = new System.Drawing.Size(34, 20);
            this.buttonToogleShowPassword.TabIndex = 30;
            this.buttonToogleShowPassword.Text = "···";
            this.buttonToogleShowPassword.UseVisualStyleBackColor = true;
            this.buttonToogleShowPassword.Click += new System.EventHandler(this.ButtonToogleShowPassword_Click);
            // 
            // buttonBrowsePath
            // 
            this.buttonBrowsePath.Location = new System.Drawing.Point(250, 18);
            this.buttonBrowsePath.Name = "buttonBrowsePath";
            this.buttonBrowsePath.Size = new System.Drawing.Size(34, 20);
            this.buttonBrowsePath.TabIndex = 2;
            this.buttonBrowsePath.Text = "...";
            this.buttonBrowsePath.UseVisualStyleBackColor = true;
            this.buttonBrowsePath.Click += new System.EventHandler(this.ButtonBrowsePath_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(69, 45);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(175, 20);
            this.textBoxPassword.TabIndex = 29;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(69, 19);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(175, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 48);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Password:";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(318, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBoxExportOptions
            // 
            this.groupBoxExportOptions.Controls.Add(this.labelFormat);
            this.groupBoxExportOptions.Controls.Add(this.comboBoxFormat);
            this.groupBoxExportOptions.Controls.Add(this.labelObject);
            this.groupBoxExportOptions.Controls.Add(this.comboBoxObject);
            this.groupBoxExportOptions.Controls.Add(this.label2);
            this.groupBoxExportOptions.Location = new System.Drawing.Point(12, 111);
            this.groupBoxExportOptions.Name = "groupBoxExportOptions";
            this.groupBoxExportOptions.Size = new System.Drawing.Size(295, 78);
            this.groupBoxExportOptions.TabIndex = 25;
            this.groupBoxExportOptions.TabStop = false;
            this.groupBoxExportOptions.Text = "Export Options";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(23, 49);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(42, 13);
            this.labelFormat.TabIndex = 33;
            this.labelFormat.Text = "Format:";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(69, 46);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(175, 21);
            this.comboBoxFormat.TabIndex = 34;
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new System.Drawing.Point(24, 22);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(41, 13);
            this.labelObject.TabIndex = 31;
            this.labelObject.Text = "Object:";
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Location = new System.Drawing.Point(69, 19);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(175, 21);
            this.comboBoxObject.TabIndex = 32;
            this.comboBoxObject.SelectionChangeCommitted += ComboBoxObject_SelectionChangeCommitted;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(122, 197);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 26;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 231);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(318, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 35;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel.Text = "{status}";
            // 
            // FormCertUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 253);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.groupBoxExportOptions);
            this.Controls.Add(this.groupBoxPrivateKeyFile);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "FormCertUtil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CertUtil {version}";
            this.groupBoxPrivateKeyFile.ResumeLayout(false);
            this.groupBoxPrivateKeyFile.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBoxExportOptions.ResumeLayout(false);
            this.groupBoxExportOptions.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBoxPrivateKeyFile;
        private System.Windows.Forms.Button buttonBrowsePath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonToogleShowPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxExportOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}