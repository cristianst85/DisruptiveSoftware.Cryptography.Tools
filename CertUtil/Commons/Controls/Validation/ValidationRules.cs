using CertUtil.Commons.Controls.Validation.Impl;

namespace CertUtil.Commons.Controls.Validation
{
    public static class ValidationRules
    {
        public static IControlValidationRule Required
        {
            get
            {
                return new RequiredValidationRule();
            }
        }

        public static IControlValidationRule DirectoryExists
        {
            get
            {
                return new DirectoryExistsValidationRule();
            }
        }

        public static IControlValidationRule FileExists
        {
            get
            {
                return new FileExistsValidationRule();
            }
        }
    }
}
