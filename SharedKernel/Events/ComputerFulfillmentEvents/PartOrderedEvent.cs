using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents {
    public class PartOrderedEvent : IDomainEvent
    {
        public PartOrderedEvent(string computerId, string documentId, string serialNumber, string shippingProvider, string shippingProviderTrackingId, string purchaserName)
        {
            ComputerId = computerId;
            DocumentId = documentId;
            SerialNumber = serialNumber;
            ShippingProvider = shippingProvider;
            ShippingProviderTrackingId = shippingProviderTrackingId;
            PurchaserName = purchaserName;
        }

        public string ComputerId { get; }
        public string DocumentId { get; }
        public string SerialNumber { get; }
        public string ShippingProvider { get; }
        public string ShippingProviderTrackingId { get; }
        public string PurchaserName { get; }
    }
}
