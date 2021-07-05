using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents
{
    class PartShippingInformationAvailableEvent : IDomainEvent
    {
        public PartShippingInformationAvailableEvent(string computerId, string partId, string shippingProvider, string shippingProviderTrackingId)
        {
            ComputerId = ComputerId;
            PartId = partId;
            ShippingProvider = shippingProvider;
            ShippingProviderTrackingId = shippingProviderTrackingId;
        }

        public string computerId { get;  }
        public string PartId { get;  }
        public string ComputerId { get; }
        public string ShippingProvider { get; }
        public string ShippingProviderTrackingId { get; }
    }
}
