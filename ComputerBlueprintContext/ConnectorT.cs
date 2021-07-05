using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBlueprintContext
{
    public class ConnectorT<TConnectionDetails> : IConnectorT<TConnectionDetails> where TConnectionDetails: IConnectionDetails
    {
        public string Name { get; }
        public TConnectionDetails ConnectionDetails { get; }
    }
}
