using CertUtil.Extensions;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace CertUtil.Commons
{
    public static class AssemblyUtils
    {
        public static string GetApplicationPath()
        {
            return new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase).LocalPath;
        }

        public static string GetApplicationDirPath()
        {
            return Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase).LocalPath);
        }

        public static string GetProductVersion()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        }

        public static string GetProductVersion(string assemblyName)
        {
            var attributes = Assembly.Load(assemblyName).GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);
            return attributes.Length == 0 ? GetVersion(assemblyName).ToString() : ((AssemblyInformationalVersionAttribute)attributes[0]).GetInformationalVersion(true);
        }

        public static Version GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version;
        }

        public static Version GetVersion(string assemblyName)
        {
            return Assembly.Load(assemblyName).GetName().Version;
        }

        public static Assembly AssemblyResolver(object sender, ResolveEventArgs args)
        {
            string resourceName = args.Name.EndsWith(".dll") ? args.Name : new AssemblyName(args.Name).Name + ".dll";
            string resource = Array.Find(Assembly.GetExecutingAssembly().GetManifestResourceNames(), element => element.EndsWith(resourceName));

            if (resource != null)
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    byte[] assemblyData = new byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }

            return null;
        }
    }
}
