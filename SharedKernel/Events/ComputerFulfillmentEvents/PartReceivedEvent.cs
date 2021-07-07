using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents
{
    public class PartReceivedEvent : IDomainEvent
    {

        public PartReceivedEvent(string computerId, string partId, string documentId, ILocation location)
        {
            ComputerId = computerId;
            PartId = partId;
            DocumentId = documentId;
            Location=location.LocationDescription;
        }

        public string ComputerId { get; }
        public string PartId { get; }
        public string DocumentId { get; }
        public string Location { get; }
    }
}
