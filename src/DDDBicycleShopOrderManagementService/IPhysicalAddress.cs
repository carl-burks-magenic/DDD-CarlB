namespace DDDBicycleShopOrderManagementService
{
    public interface IPhysicalAddress
    {
        string City { get; }
        string CountryCode { get; }
        string Postal { get; }
        string State { get; }
        string Street { get; }
        string StreetAdditional { get; }
    }
}