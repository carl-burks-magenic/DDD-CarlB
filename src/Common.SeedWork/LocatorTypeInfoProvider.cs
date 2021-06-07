using Common.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Common.SeedWork
{
    public class LocatorTypeInfoProvider
    {
        private readonly IAssemblyProvider assemblyProvider;
        private Type type;
        private TypeInfo[] typeInfos = null;
        public LocatorTypeInfoProvider(IAssemblyProvider assemblyProvider)
        {
            type = typeof(Common.SeedWork.Handler);
            this.assemblyProvider = assemblyProvider;
        }
        //For All of the assemblies grab the classes with the Handler Attribute and return the typeinfo
        public IEnumerable<TypeInfo> GetTypeInfos(){
            if (null == typeInfos)
            {
                typeInfos = assemblyProvider.Assemblies.SelectMany(
                x => x.GetTypes().Where(y => Attribute.IsDefined(y, type)).Select(z => z.GetTypeInfo())).ToArray();
            }
            return typeInfos;
        }
    }
}
