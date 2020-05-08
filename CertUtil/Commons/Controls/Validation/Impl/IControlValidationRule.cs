using System.Windows.Forms;

namespace CertUtil.Commons.Controls.Validation.Impl
{
    public interface IControlValidationRule
    {
        bool IsValid(Control control);
    }
}
