using SSLCertBundleGenerator.Commons.Controls.Validation.Impl;

namespace SSLCertBundleGenerator.Commons.Controls.Validation
{
    public static class ValidationRules
    {
        public static IControlValidationRule Required
        {
            get
            {
                return new TextRequiredValidationRule();
            }
        }

        public static IControlValidationRule DirectoryExists
        {
            get
            {
                return new DirectoryExistsValidationRule();
            }
        }
    }
}
