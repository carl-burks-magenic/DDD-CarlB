using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBlueprintContext
{
    public class PowerSupply: INoiseProducer
    {
        public FormFactor FormFactor {get;}
        public EfficiencyRating EfficiencyRating { get;  }
        public IPowerSupplyModularType ModularType { get;  }
        public int LowNoiseInDecibles { get;  }
        public int HighNoiseInDecibles { get;  }
        public IEnumerable<ConnectorT<PowerConnectorDetails>> Connections { get;  }
    }
}
