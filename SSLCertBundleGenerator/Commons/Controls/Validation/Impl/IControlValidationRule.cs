using System.Windows.Forms;

namespace SSLCertBundleGenerator.Commons.Controls.Validation.Impl
{
    public interface IControlValidationRule
    {
        bool IsValid(Control control);
    }
}
