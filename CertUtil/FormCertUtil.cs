using CertUtil.Commons;
using CertUtil.Commons.Controls;
using CertUtil.Commons.Controls.Validation;
using DisruptiveSoftware.Cryptography.Extensions;
using DisruptiveSoftware.Cryptography.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace CertUtil
{
    public partial class FormCertUtil : Form
    {
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

        private void ButtonToogleShowPassword_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.ToogleUseSystemPasswordChar();
        }

        private void ComboBoxObject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.comboBoxFormat.Items.Clear();

            var selectedItemObject = this.comboBoxObject.SelectedItem.ToString();

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
            try
            {
                if (!this.ValidateControls())
                {
                    this.toolStripStatusLabel.Text = "Please fill all required fields.";
                    this.statusStrip.Update();
                    return;
                }

                this.toolStripStatusLabel.Text = string.Empty;
                this.statusStrip.Update();

                byte[] certificateContent = null;

                var saveFileDialogFilter = string.Empty;
                var saveFileDialogFileName = Path.GetFileNameWithoutExtension(this.textBoxPath.Text);

                var selectedItemObject = this.comboBoxObject.SelectedItem.ToString();

                if (CertUtilConstants.CryptographicObjects[selectedItemObject] == CertUtilConstants.CryptographicObjectType.PublicKeyCertificate)
                {
                    var selectedItemFormat = this.comboBoxFormat.SelectedItem.ToString();

                    saveFileDialogFilter = string.Format("{0}|{1}", selectedItemFormat, CertUtilConstants.PublicKeyCertificatesFormats[selectedItemFormat]);
                    saveFileDialogFileName += CertUtilConstants.PublicKeyCertificatesFormats[selectedItemFormat].Trim('*');

                    if (selectedItemFormat.Contains("Base64"))
                    {
                        var certificateText = CertificateUtils.ExportPublicKeyCertificateToPEM(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());
                        certificateContent = System.Text.Encoding.ASCII.GetBytes(certificateText);
                    }
                    else if (selectedItemFormat.Contains("Binary"))
                    {
                        certificateContent = CertificateUtils.ExportPublicKeyCertificate(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());
                    }
                }
                else if (CertUtilConstants.CryptographicObjects[selectedItemObject] == CertUtilConstants.CryptographicObjectType.PrivateKey)
                {
                    var selectedItemFormat = this.comboBoxFormat.SelectedItem.ToString();

                    saveFileDialogFilter = string.Format("{0}|{1}", selectedItemFormat, CertUtilConstants.PrivateKeyFormats[selectedItemFormat]);
                    saveFileDialogFileName += CertUtilConstants.PrivateKeyFormats[selectedItemFormat].Trim('*');

                    if (selectedItemFormat.Contains("Base64"))
                    {
                        var certificateText = CertificateUtils.ExportPrivateKeyToPEM(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());
                        certificateContent = System.Text.Encoding.ASCII.GetBytes(certificateText);
                    }
                    else if (selectedItemFormat.Contains("Binary"))
                    {
                        certificateContent = CertificateUtils.ExportPrivateKey(File.ReadAllBytes(this.textBoxPath.Text), this.textBoxPassword.Text.ToSecureString());
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }

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
                            File.WriteAllBytes(fileName, certificateContent);

                            this.toolStripStatusLabel.Text = "File has been successfully saved.";
                            this.statusStrip.Update();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
