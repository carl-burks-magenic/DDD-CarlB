using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents
{
    class PartReceivedEvent : IDomainEvent
    {

        public PartReceivedEvent(string computerId, string partId, string documentId, string aisle, int shelfNumber)
        {
            ComputerId = computerId;
            PartId = partId;
            DocumentId = documentId;
            Aisle = aisle;
            ShelfNumber = shelfNumber;
        }

        public string ComputerId { get; }
        public string PartId { get; }
        public string DocumentId { get; }
        public string Aisle { get; }
        public int ShelfNumber { get; }
    }
}
