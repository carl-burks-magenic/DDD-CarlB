namespace ComputerBlueprintContext
{
    public class PowerConnectorDetails : IConnectionDetails, IPinoutProvider
    {
        public Pinout Pinout { get; }
    }
}