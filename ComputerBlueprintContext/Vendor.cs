using SharedKernel;
using System;

namespace ComputerBlueprintContext
{
    public class Vendor: IEntity<Guid>
    {
        public System.Guid Id { get;  }
        public string Name { get;  }
    }
}