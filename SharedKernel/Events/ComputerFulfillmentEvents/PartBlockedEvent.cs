using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents
{
    class PartBlockedEvent : IDomainEvent
    {
        public PartBlockedEvent(string setBlockedBy, DateTime blockedOnDate, string computerId, string partId,  string notes)
        {

        }
        public string ComputerId { get;  }
        public string PartId { get; }
        public string BlockedBy { get; }
        public DateTime BlockedOnDate { get; }
        public string Notes { get; }
    }
}
