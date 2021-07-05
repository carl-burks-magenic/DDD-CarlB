using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBlueprintContext
{
    public interface IConnectorT<TConnectionDetails> where TConnectionDetails:IConnectionDetails  
    {
        public string Name { get; }
        public TConnectionDetails ConnectionDetails { get; }
    }
}
