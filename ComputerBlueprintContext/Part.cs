using System.Collections.Generic;
using System.Linq;

namespace ComputerBlueprintContext
{
    public class Part
    {
        public string Name { get;  }
        public string Type { get;  }
        public string VendorIdentifier { get;  }
        public Vendor Vendor { get;  }
        public bool Validate(IEnumerable<Part> parts, Part partToAdd)
        {
            return !(parts.Count(x => x.Type == "RAM") > 1 && partToAdd.Type == "RAM");
        }
    }
}