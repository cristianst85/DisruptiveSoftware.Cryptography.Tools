using CertUtil.Commons.Controls.Validation.Impl;
using System.ComponentModel;
using System.Windows.Forms;

namespace CertUtil.Commons.Controls
{
    public static class Extensions
    {
        public static bool IsValid(this Control control, IControlValidationRule rule)
        {
            return rule.IsValid(control);
        }

        public static void ToogleUseSystemPasswordChar(this TextBox control)
        {
            control.UseSystemPasswordChar = !control.UseSystemPasswordChar;
        }

        public static void InvokeIfRequired(this Control control, MethodInvoker action)
        {
            ((ISynchronizeInvoke)control).InvokeIfRequired(action);
        }

        public static void InvokeIfRequired(this ISynchronizeInvoke obj, MethodInvoker action)
        {
            if (obj.InvokeRequired)
            {
                obj.Invoke(action, new object[0]);
            }
            else
            {
                action();
            }
        }
    }
}
