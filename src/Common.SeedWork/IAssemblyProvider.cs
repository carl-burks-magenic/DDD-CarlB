using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Common.SeedWork
{
    public interface IAssemblyProvider
    {
        public IEnumerable<Assembly> Assemblies { get; }
    }
}
