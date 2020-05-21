using DisruptiveSoftware.Cryptography.BouncyCastle.Extensions;
using DisruptiveSoftware.Cryptography.Extensions;
using DisruptiveSoftware.Cryptography.X509;
using SSLCertBundleGenerator.Commons;
using SSLCertBundleGenerator.Commons.Controls;
using SSLCertBundleGenerator.Commons.Controls.Validation;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using X509Constants = DisruptiveSoftware.Cryptography.X509.Constants;

namespace SSLCertBundleGenerator
{
    public partial class FormSSLCertBundleGenerator : Form
    {
        public FormSSLCertBundleGenerator()
        {
            InitializeComponent();

            this.Text = this.Text.Replace("{version}", AssemblyUtils.GetVersion().ToString(3));

            this.toolStripStatusLabel.Text = string.Empty;

            this.comboBoxKeySize.Items.Add(X509Constants.RSAKeySize.KeySize1024);
            this.comboBoxKeySize.Items.Add(X509Constants.RSAKeySize.KeySize2048);
            this.comboBoxKeySize.Items.Add(X509Constants.RSAKeySize.KeySize4096);

            this.comboBoxValidity.Items.AddRange(Enumerable.Range(1, 24).Cast<object>().ToArray());           

            // Default values.
            this.comboBoxKeySize.SelectedItem = this.comboBoxKeySize.Items[1];
            this.comboBoxValidity.SelectedItem = this.comboBoxValidity.Items[11];

            // SSL Certificate Enhanced Key Usage property must contain Server Authentication (1.3.6.1.5.5.7.3.1).
            this.checkBoxServerAuthentication.Checked = true;
            this.checkBoxServerAuthentication.Enabled = false;
        }

        private bool ValidateControls()
        {
            bool result = true;

            result &= this.textBoxCN.IsValid(ValidationRules.Required);
            result &= this.textBoxOU.IsValid(ValidationRules.Required);
            result &= this.textBoxO.IsValid(ValidationRules.Required);
            result &= this.textBoxC.IsValid(ValidationRules.Required);
            result &= this.numericUpDownSerialNumber.IsValid(ValidationRules.Required);
            result &= this.textBoxPassword.IsValid(ValidationRules.Required);
            result &= this.textBoxSavePath.IsValid(ValidationRules.Required);

            return result;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateControls())
                {
                    this.toolStripStatusLabel.Text = "Please fill all required fields.";
                    this.statusStrip.Update();
                    return;
                }

                var savePath = this.textBoxSavePath.Text;

                if (!Directory.Exists(savePath))
                {
                    throw new Exception("Destination directory does not exist.");
                }

                if (Directory.GetFiles(savePath).Length > 0)
                {
                    throw new Exception("Destination directory must be empty.");
                }

                this.toolStripStatusLabel.Text = "Generating Certificate files...";
                this.statusStrip.Update();

                var now = DateTime.UtcNow;
                var keySize = Convert.ToUInt32(this.comboBoxKeySize.SelectedItem);
                var validityInMonths = Convert.ToInt32(this.comboBoxValidity.SelectedItem);
                var serialNumber = Convert.ToUInt64(this.numericUpDownSerialNumber.Value);

                var certificateBuilderResult = new CACertificateBuilder()
                    .SetSerialNumber(serialNumber - 1)
                    .SetKeySize(keySize)
                    .SetSubjectDN(this.textBoxCN.Text + " CA", this.textBoxOU.Text, this.textBoxO.Text, null, this.textBoxC.Text)
                    .SetNotBefore(now)
                    .SetNotAfter(now.AddMonths(validityInMonths))
                    .Build();

                var pkcs12Data = certificateBuilderResult.ExportCertificate(this.textBoxPassword.Text.ToSecureString());

                var sslCertificateBuilder = new SSLCertificateBuilder()
                   .SetSerialNumber(serialNumber)
                   .SetKeySize(keySize)
                   .SetSubjectDN(this.textBoxCN.Text, this.textBoxOU.Text, this.textBoxO.Text, null, this.textBoxC.Text)
                   .SetNotBefore(now)
                   .SetNotAfter(now.AddMonths(validityInMonths))
                   .SetIssuerCertificate(pkcs12Data, this.textBoxPassword.Text.ToSecureString());

                if (this.checkBoxClientAuthentication.Checked)
                {
                    sslCertificateBuilder = sslCertificateBuilder.SetClientAuthKeyUsage();
                };

                if (this.checkBoxServerAuthentication.Checked)
                {
                    sslCertificateBuilder = sslCertificateBuilder.SetServerAuthKeyUsage();
                };

                if (!this.textBoxSAN.Text.IsNullOrEmpty())
                {
                    var sans = this.textBoxSAN.Text.Split(';').Select(x => x.Trim()).ToList();
                    sslCertificateBuilder = sslCertificateBuilder.SetSubjectAlternativeNames(sans);
                };

                var sslCertificateBuilderResult = sslCertificateBuilder.Build();
                File.WriteAllBytes(Path.Combine(savePath, "caCertificate.p12"), pkcs12Data);

                if (this.checkBoxCertExpCrt.Checked)
                {
                    var certData = certificateBuilderResult.Certificate.ExportPublicKeyCertificate();
                    File.WriteAllBytes(Path.Combine(savePath, "caCertificate.crt"), certData);
                }

                var sslPkcs12Data = sslCertificateBuilderResult.ExportCertificate(this.textBoxPassword.Text.ToSecureString());
                File.WriteAllBytes(Path.Combine(savePath, "sslCertificate.p12"), sslPkcs12Data);

                if (this.checkBoxCertExpCrt.Checked)
                {
                    var sslCertData = sslCertificateBuilderResult.Certificate.ExportPublicKeyCertificate();
                    File.WriteAllBytes(Path.Combine(savePath, "sslCertificate.crt"), sslCertData);
                }

                this.toolStripStatusLabel.Text = "Done.";
                this.statusStrip.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.toolStripStatusLabel.Text = string.Empty;
                this.statusStrip.Update();
            }
        }

        private void ButtonShowPassword_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.ToogleUseSystemPasswordChar();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                var applicationPathDirectory = Path.GetDirectoryName(AssemblyUtils.GetApplicationPath());

                folderBrowserDialog.SelectedPath = textBoxSavePath.Text.IsNullOrEmpty() ? applicationPathDirectory : textBoxSavePath.Text;

                folderBrowserDialog.ShowNewFolderButton = true;
                folderBrowserDialog.Description = "Please choose a directory where to save certificates.";

                if (DialogResult.OK == folderBrowserDialog.ShowDialog())
                {
                    textBoxSavePath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormAbout())
            {
                form.Text = form.Text.Replace("{title}", Application.ProductName);
                form.Update();

                form.ShowDialog(this);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
