using SSLCertBundleGenerator.Commons.Controls.Validation.Impl;
using System.Windows.Forms;

namespace SSLCertBundleGenerator.Commons.Controls
{
    public static class Extensions
    {
        public static ToolTip SetToolTip(this Control control, string caption)
        {
            var toolTip = new ToolTip();

            toolTip.SetToolTip(control, caption);

            return toolTip;
        }

        public static bool IsValid(this Control control, IControlValidationRule rule)
        {
            return rule.IsValid(control);
        }

        public static void ToogleUseSystemPasswordChar(this TextBox control)
        {
            control.UseSystemPasswordChar = !control.UseSystemPasswordChar;
        }
    }
}
