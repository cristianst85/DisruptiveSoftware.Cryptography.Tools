using SSLCertBundleGenerator.Commons;
using System.Diagnostics;
using System.Windows.Forms;

namespace SSLCertBundleGenerator
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            var version = AssemblyUtils.GetProductVersion();

            this.labelVersion.Text = this.labelVersion.Text.Replace("{version}", version);
            this.richTextBoxCopyright.Text = this.richTextBoxCopyright.Text.Replace("{bouncyCastleCryptographyLibVersion}", AssemblyUtils.GetVersion("BouncyCastle.Cryptography").ToString());
            this.richTextBoxCopyright.Text = this.richTextBoxCopyright.Text.Replace("{disruptiveSoftwareCryptographyLibVersion}", AssemblyUtils.GetVersion("DisruptiveSoftware.Cryptography").ToString());

            this.KeyDown += new KeyEventHandler(FormAbout_KeyPress);

            this.richTextBoxCopyright.LinkClicked += new LinkClickedEventHandler(RichTextBoxCopyright_LinkClicked);
            this.linkLabelContact.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabelContact_LinkClicked);
            this.linkLabelSource.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabelSource_LinkClicked);
        }

        private void FormAbout_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void RichTextBoxCopyright_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void LinkLabelContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(string.Format("mailto:{0}?subject=About {1} v{2}", this.linkLabelContact.Text, Properties.Resources.Title, AssemblyUtils.GetVersion()));
        }

        private void LinkLabelSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/cristianst85/DisruptiveSoftware.Cryptography.Tools");
        }
    }
}