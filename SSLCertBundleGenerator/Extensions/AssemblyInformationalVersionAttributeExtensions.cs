using System.Reflection;

namespace SSLCertBundleGenerator.Extensions
{
    public static class AssemblyInformationalVersionAttributeExtensions
    {
        public static string GetInformationalVersion(this AssemblyInformationalVersionAttribute attribute, bool truncate = false)
        {
            if (truncate)
            {
                var offset = attribute.InformationalVersion.IndexOf('+');

                if (offset > 0)
                {
                    return attribute.InformationalVersion.Substring(0, offset + 8);
                }
            }

            return attribute.InformationalVersion;
        }
    }
}
