using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerBlueprintContext
{
    public class Blueprint
    {
        public string Name { get; set; }

        public IEnumerable<Part> PartsList {
            get => _parts;
        }
        private List<Part> _parts;
        private readonly IEnumerable<IPartValidator> partValidators;

        public Blueprint(IEnumerable<IPartValidator> partValidators)
        {
            this.partValidators = partValidators;
        }
        public bool CanAddPart(Part part)
        {
            // New part valid?
            List<Part> parts = _parts.Union(new List<Part> { part }).ToList();
            return parts.All(p => p.Validate(parts, p));
        }
        public void AddPart(Part part)
        {

            //Should call CanAddPart First and then call AddPart
        }
    }
}
