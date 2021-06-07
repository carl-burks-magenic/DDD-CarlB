using Common.SeedWork;
using System.Collections.Generic;
using System.Reflection;

namespace ApiApplication
{
    /// <summary>
    /// Locates all the assemblies we want to expose
    /// </summary>
    public class HardCodedAssemblyProvider : IAssemblyProvider
    {
        public IEnumerable<Assembly> Assemblies => new []{typeof(OrderManagementService.HeartbeatService).Assembly };
    }
}
