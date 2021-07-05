namespace ComputerFulfilment
{
    public enum PartStatus
    {
        NotStarted, //nothing has been done
        Ordered, // item ordered from vendor 
        ShippingInformationReceived, // shipping provider information has been provided
        Arrived, // item has arrived physically
        Tested, // item has been bench tested
        Blocked, // item has a problem and needs human intervention
        Installed // item has been installed into the computer
    }
}