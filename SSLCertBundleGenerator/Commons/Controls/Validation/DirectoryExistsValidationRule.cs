using System.IO;
using System.Windows.Forms;

namespace SSLCertBundleGenerator.Commons.Controls.Validation
{
    public class DirectoryExistsValidationRule : RequiredValidationRule
    {
        public override bool IsValid(Control control)
        {
            if (base.IsValid(control))
            {
                if (Directory.Exists(control.Text))
                {
                    return true;
                }
                else
                {
                    InvalidateControl(control);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
