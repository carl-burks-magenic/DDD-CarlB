using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComputerBlueprintContext
{
    class ATXMotherboard: Part
    {
        public IEnumerable<IPartValidator> Validators { get; }
        private List<IPartValidator> _validators;

    }

    class TwoSticksOfRamValidator : IPartValidator
    {
        public bool Validate(IEnumerable<Part> parts, Part partToAdd)
        {
            return !(parts.Count(x => x.Type == "RAM") > 1 && partToAdd.Type == "RAM");
        }
    }
    class FooATXMotherboard : ATXMotherboard
    {
        public FooATXMotherboard()
        {
            _validators = new List<IPartValidator>();
            _validators.Add(new TwoSticksOfRamValidator());
        }
        private List<IPartValidator> _validators;

    }

}
