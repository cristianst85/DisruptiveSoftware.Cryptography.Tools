using DisruptiveSoftware.Cryptography.Extensions;
using SSLCertBundleGenerator.Commons.Controls.Validation.Impl;
using System.Drawing;
using System.Windows.Forms;

namespace SSLCertBundleGenerator.Commons.Controls.Validation
{
    public class RequiredValidationRule : IControlValidationRule
    {
        public virtual bool IsValid(Control control)
        {
            if (control.Text.IsNullOrEmpty())
            {
                InvalidateControl(control);
                return false;
            }
            else
            {
                ValidateControl(control);
                return true;
            }
        }

        protected virtual void InvalidateControl(Control control)
        {
            control.BackColor = Constants.Controls.InvalidControlColor;
        }

        protected virtual void ValidateControl(Control control)
        {
            control.BackColor = default(Color);
        }
    }
}
