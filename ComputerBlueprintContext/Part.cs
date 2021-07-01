namespace ComputerBlueprintContext
{
    public class Part
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string VendorIdentifier { get; set; }
        public Vendor Vendor { get; set; }
        public bool Validate(IEnumerable<Part> parts, Part partToAdd)
        {
            return !(parts.Count(x => x.Type == "RAM") > 1 && partToAdd.Type == "RAM");
        }
    }
}