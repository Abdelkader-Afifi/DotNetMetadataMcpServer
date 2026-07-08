using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMetadataMcpServer.Tools
{
    public class AssemblyVersionExplorer
    {
        public string GetAssemblyVersion(string assemblyPath)
        {
            var assembly = Assembly.LoadFrom(assemblyPath);
            return assembly.GetName().Version.ToString();
        }
    }
}
