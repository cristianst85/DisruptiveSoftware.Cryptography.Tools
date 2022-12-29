using CertUtil.Commons;
using CertUtil.Commons.Controls;
using CertUtil.Commons.Controls.Validation;
using DisruptiveSoftware.Cryptography.Extensions;
using DisruptiveSoftware.Cryptography.Utils;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertUtil
{
    public partial class FormCertUtil : Form
    {
        private volatile bool IsClosing;

        public FormCertUtil()
        {
            InitializeComponent();

            this.Text = this.Text.Replace("{version}", AssemblyUtils.GetVersion().ToString(3));

            this.toolStripStatusLabel.Text = string.Empty;

            foreach (var cryptoObject in CertUtilConstants.CryptographicObjects)
            {
                this.comboBoxObject.Items.Add(cryptoObject.Key);
            }

            this.comboBoxObject.SelectedItem = this.comboBoxObject.Items[0];

            foreach (var pkcFormat in CertUtilConstants.PublicKeyCertificatesFormats)
            {
                this.comboBoxFormat.Items.Add(pkcFormat.Key);
            }

            this.comboBoxFormat.SelectedItem = this.comboBoxFormat.Items[0];

            // Handlers.
            this.comboBoxObject.SelectionChangeCommitted += ComboBoxObject_SelectionChangeCommitted;
            this.FormClosing += new FormClosingEventHandler(this.FormCertUtil_Closing);
        }

        private void FormCertUtil_Closing(object sender, FormClosingEventArgs e)
        {
            this.IsClosing = true;
        }

        private bool ValidateControls()
        {
            bool result = true;

            result &= this.textBoxPath.IsValid(ValidationRules.FileExists);

            return result;
        }

        private void ButtonBrowsePath_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = string.Empty;
                openFileDialog.Multiselect = false;
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.Title = "Please choose a file that contains the private key...";
                openFileDialog.Filter = "PKCS #12 (*.p12)|*.p12|Personal Information Exchange (*.pfx)|*.pfx|All files (*.*)|*.*";

                if (DialogResult.OK == openFileDialog.ShowDialog(this))
                {
                    this.textBoxPath.Text = openFileDialog.FileName;
                    this.textBoxPath.Select(this.textBoxPath.Text.Length, 0);
                }
            }
        }

        private void ButtonToggleShowPassword_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.ToggleUseSystemPasswordChar();
        }

        private void ComboBoxObject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.comboBoxFormat.Items.Clear();

            var selectedItemObject = (string)this.comboBoxObject.SelectedItem;

            if (CertUtilConstants.CryptographicObjects[selectedItemObject] == CertUtilConstants.CryptographicObjectType.PublicKeyCertificate)
            {
                foreach (var pkcFormat in CertUtilConstants.PublicKeyCertificatesFormats)
                {
                    this.comboBoxFormat.Items.Add(pkcFormat.Key);
                }
            }
            else if (CertUtilConstants.CryptographicObjects[selectedItemObject] == CertUtilConstants.CryptographicObjectType.PrivateKey)
            {
                foreach (var pkFormat in CertUtilConstants.PrivateKeyFormats)
                {
                    this.comboBoxFormat.Items.Add(pkFormat.Key);
                }
            }

            this.comboBoxFormat.SelectedItem = this.comboBoxFormat.Items[0];
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            ExportAsync();
        }

        private async void ExportAsync()
        {
            try
            {
                if (!this.ValidateControls())
                {
                    UpdateStatusStrip("Please fill all required fields.");
                    return;
                }

                UpdateStatusStrip(string.Empty);

                ToggleControls(enabled: false);

                byte[] cryptographicObjectContent = null;

                var saveFileDialogFilter = string.Empty;
                var saveFileDialogFileName = Path.GetFileNameWithoutExtension(this.textBoxPath.Text);

                var selectedItemObject = (string)this.comboBoxObject.SelectedItem;
                var selectedItemFormat = (string)this.comboBoxFormat.SelectedItem;

                var selectedCryptographicObjectType = CertUtilConstants.CryptographicObjects[selectedItemObject];

                await Task.Run(() =>
                {
                    if (selectedCryptographicObjectType == CertUtilConstants.CryptographicObjectType.PublicKeyCertificate)
                    {
                        saveFileDialogFilter = string.Format("{0}|{1}", selectedItemFormat, CertUtilConstants.PublicKeyCertificatesFormats[selectedItemFormat]);
                        saveFileDialogFileName += CertUtilConstants.PublicKeyCertificatesFormats[selectedItemFormat].Trim('*');

                        if (selectedItemFormat.Contains("Base64"))
                        {
                            var cryptographicObjectText = CertificateUtils.ExportPublicKeyCertificateToPEM(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());
                            cryptographicObjectContent = System.Text.Encoding.ASCII.GetBytes(cryptographicObjectText);
                        }
                        else if (selectedItemFormat.Contains("Binary"))
                        {
                            cryptographicObjectContent = CertificateUtils.ExportPublicKeyCertificate(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }
                    else if (selectedCryptographicObjectType == CertUtilConstants.CryptographicObjectType.PrivateKey)
                    {
                        saveFileDialogFilter = string.Format("{0}|{1}", selectedItemFormat, CertUtilConstants.PrivateKeyFormats[selectedItemFormat]);
                        saveFileDialogFileName += CertUtilConstants.PrivateKeyFormats[selectedItemFormat].Trim('*');

                        if (selectedItemFormat.Contains("Base64"))
                        {
                            var cryptographicObjectText = CertificateUtils.ExportPrivateKeyToPEM(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());

                            if (cryptographicObjectText.IsNullOrEmpty())
                            {
                                throw new Exception("Certificate does not have a private key.");
                            }

                            cryptographicObjectContent = System.Text.Encoding.ASCII.GetBytes(cryptographicObjectText);
                        }
                        else if (selectedItemFormat.Contains("Binary"))
                        {
                            cryptographicObjectContent = CertificateUtils.ExportPrivateKey(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());

                            if (cryptographicObjectContent == null)
                            {
                                throw new Exception("Certificate does not have a private key.");
                            }
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                });

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Please choose a file name...";
                    saveFileDialog.Filter = saveFileDialogFilter;
                    saveFileDialog.FileName = saveFileDialogFileName;
                    saveFileDialog.CheckFileExists = false;
                    saveFileDialog.CheckPathExists = true;

                    if (DialogResult.OK == saveFileDialog.ShowDialog(this))
                    {
                        string fileName = saveFileDialog.FileName;

                        if (fileName.Length > 0)
                        {
                            File.WriteAllBytes(fileName, cryptographicObjectContent);

                            UpdateStatusStrip("File has been successfully saved.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.textBoxPath.Enabled = enabled;
            this.buttonBrowsePath.Enabled = enabled;

            this.textBoxPassword.Enabled = enabled;
            this.buttonToggleShowPassword.Enabled = enabled;

            this.comboBoxObject.Enabled = enabled;
            this.comboBoxFormat.Enabled = enabled;

            this.buttonExport.Enabled = enabled;
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
