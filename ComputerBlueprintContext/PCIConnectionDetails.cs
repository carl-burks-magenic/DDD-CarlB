namespace ComputerBlueprintContext
{
    public class PCIConnectionDetails : IConnectionDetails, ISpecificationRevision, IPinoutProvider
    {
        public string Revision { get; }

        public Pinout Pinout { get; }
    }
}