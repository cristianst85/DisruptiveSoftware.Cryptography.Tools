using DisruptiveSoftware.Cryptography.BouncyCastle.Extensions;
using DisruptiveSoftware.Cryptography.Extensions;
using DisruptiveSoftware.Cryptography.X509;
using SSLCertBundleGenerator.Commons;
using SSLCertBundleGenerator.Commons.Controls;
using SSLCertBundleGenerator.Commons.Controls.Validation;
using SSLCertBundleGenerator.Extensions;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using X509Constants = DisruptiveSoftware.Cryptography.X509.Constants;

namespace SSLCertBundleGenerator
{
    public partial class FormSSLCertBundleGenerator : Form
    {
        private volatile bool IsClosing;

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

            this.numericUpDownSerialNumber.Maximum = long.MaxValue;
            this.numericUpDownSerialNumber.Minimum = 2;
            this.numericUpDownSerialNumber.Value = 2;

            // SSL Certificate Enhanced Key Usage property must contain Server Authentication (1.3.6.1.5.5.7.3.1).
            this.checkBoxServerAuthentication.Checked = true;
            this.checkBoxServerAuthentication.Enabled = false;

            this.pictureBoxInfo.SetToolTip("Multiple Subject Alternative Names (SANs) can be specified separated by semicolons.");

            // Handlers.
            this.FormClosing += new FormClosingEventHandler(this.FormSSLCertBundleGenerator_Closing);
        }

        private void FormSSLCertBundleGenerator_Closing(object sender, FormClosingEventArgs e)
        {
            this.IsClosing = true;
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
            GenerateCertificatesAsync();
        }

        private async void GenerateCertificatesAsync()
        {
            try
            {
                if (!this.ValidateControls())
                {
                    UpdateStatusStrip("Please fill all required fields.");
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

                UpdateStatusStrip("Generating Certificate files...");

                ToggleControls(enabled: false);

                var now = DateTime.UtcNow;
                var keySize = Convert.ToUInt32(this.comboBoxKeySize.SelectedItem);
                var validityInMonths = Convert.ToInt32(this.comboBoxValidity.SelectedItem);
                var serialNumber = Convert.ToInt64(this.numericUpDownSerialNumber.Value);

                await Task.Run(() =>
                {
                    var certificateBuilderResult = new CACertificateBuilder()
                        .WithSerialNumberConfiguration(this.checkBoxRandomSerialNumber.Checked, serialNumber - 1)
                        .SetKeySize(keySize)
                        .SetSubjectDN(this.textBoxCN.Text + " CA", this.textBoxOU.Text, this.textBoxO.Text, null, this.textBoxC.Text)
                        .SetNotBefore(now)
                        .SetNotAfter(now.AddMonths(validityInMonths))
                        .Build();

                    var pkcs12Data = certificateBuilderResult.ExportCertificate(this.textBoxPassword.Text.ToSecureString());

                    var sslCertificateBuilder = new SSLCertificateBuilder()
                       .WithSerialNumberConfiguration(this.checkBoxRandomSerialNumber.Checked, serialNumber)
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

                    if (this.checkBoxCertificateExportCrt.Checked)
                    {
                        var certData = certificateBuilderResult.Certificate.ExportPublicKeyCertificate();
                        File.WriteAllBytes(Path.Combine(savePath, "caCertificate.crt"), certData);
                    }

                    var sslPkcs12Data = sslCertificateBuilderResult.ExportCertificate(this.textBoxPassword.Text.ToSecureString());
                    File.WriteAllBytes(Path.Combine(savePath, "sslCertificate.p12"), sslPkcs12Data);

                    if (this.checkBoxCertificateExportCrt.Checked)
                    {
                        var sslCertData = sslCertificateBuilderResult.Certificate.ExportPublicKeyCertificate();
                        File.WriteAllBytes(Path.Combine(savePath, "sslCertificate.crt"), sslCertData);
                    }
                });

                UpdateStatusStrip("Certificates generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UpdateStatusStrip(string.Empty);
            }

            ToggleControls(enabled: true);
        }

        private void UpdateStatusStrip(string text)
        {
            if (!this.IsClosing)
            {
                this.statusStrip.InvokeIfRequired(() =>
                {
                    this.toolStripStatusLabel.Text = text;
                    this.statusStrip.Update();
                });
            }
        }

        private void ToggleControls(bool enabled)
        {
            this.textBoxCN.Enabled = enabled;
            this.textBoxO.Enabled = enabled;
            this.textBoxOU.Enabled = enabled;
            this.textBoxC.Enabled = enabled;

            this.numericUpDownSerialNumber.Enabled = !this.checkBoxRandomSerialNumber.Checked;
            this.checkBoxRandomSerialNumber.Enabled = enabled;
            this.comboBoxKeySize.Enabled = enabled;
            this.comboBoxValidity.Enabled = enabled;

            this.textBoxSAN.Enabled = enabled;

            this.checkBoxClientAuthentication.Enabled = enabled;

            this.textBoxPassword.Enabled = enabled;
            this.buttonToggleShowPassword.Enabled = enabled;

            this.checkBoxCertificateExportCrt.Enabled = enabled;

            this.textBoxSavePath.Enabled = enabled;
            this.buttonBrowseSavePath.Enabled = enabled;

            this.buttonGenerate.Enabled = enabled;
        }

        private void CheckBoxRandomSerialNumber_CheckedChanged(object sender, EventArgs e)
        {
            this.numericUpDownSerialNumber.Enabled = !this.checkBoxRandomSerialNumber.Checked;
        }

        private void ButtonShowPassword_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.ToggleUseSystemPasswordChar();
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
            this.CloseApplication();
        }

        private void CloseApplication()
        {
            this.IsClosing = true;

            this.Close();
        }
    }
}
