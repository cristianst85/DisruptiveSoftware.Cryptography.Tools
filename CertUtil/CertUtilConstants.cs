using System.Collections.Generic;

namespace CertUtil
{
    public static class CertUtilConstants
    {
        public enum CryptographicObjectType
        {
            PublicKeyCertificate,

            PrivateKey
        };

        // Public Key Certificate Formats.
        public static readonly Dictionary<string, string> PublicKeyCertificatesFormats = new Dictionary<string, string>()
        {
            { "Base64 DER encoded (*.pem)", "*.pem" },
            { "Binary DER encoded (*.crt)", "*.crt" }
        };

        // Private Key Formats.
        public static readonly Dictionary<string, string> PrivateKeyFormats = new Dictionary<string, string>()
        {
            { "Base64 DER encoded (*.key)", "*.key" },
            { "Binary DER encoded (*.key)", "*.key" }
        };

        // Object Formats.
        public static readonly Dictionary<string, CryptographicObjectType> CryptographicObjects = new Dictionary<string, CryptographicObjectType>()
        {
            { "Public Key Certificate", CryptographicObjectType.PublicKeyCertificate },
            { "Private Key (no password)", CryptographicObjectType.PrivateKey }
        };
    }
}