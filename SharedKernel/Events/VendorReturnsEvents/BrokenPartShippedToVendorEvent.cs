using SharedKernel;

namespace Events
{
    public class BrokenPartShippedToVendorEvent : IDomainEvent
    {
        public BrokenPartShippedToVendorEvent(string partId, string vendorId, string vendorIncidentTrackingCode, string shippingTrackingCode, string notes)
        {
            PartId = partId;
            VendorId = vendorId;
            VendorIncidentTrackingCode = vendorIncidentTrackingCode;
            ShippingTrackingCode = shippingTrackingCode;
            Notes = notes;
        }

        public string PartId { get; }
        public string VendorId { get; }
        public string VendorIncidentTrackingCode { get; }
        public string ShippingTrackingCode { get; }
        public string Notes { get; }
    }
}