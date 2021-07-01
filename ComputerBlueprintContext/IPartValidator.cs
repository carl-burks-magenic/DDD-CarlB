using System.Collections.Generic;

namespace ComputerBlueprintContext
{
    public interface IPartValidator
    {
        public bool Validate(IEnumerable<Part> parts, Part partToAdd);
    }
}