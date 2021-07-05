using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents{ 
    class PartInstalledEvent : IDomainEvent
    {
        public PartInstalledEvent(string installedBy, DateTime installedDate, string computerId, string partId,  string notes)
        {
            InstalledBy = installedBy;
            InstalledDate = installedDate;
            ComputerId = computerId;
            PartId = partId;
            Notes = notes;
        }
        public string InstalledBy { get; }
        public DateTime InstalledDate { get; }
        public string ComputerId { get; }
        public string PartId { get; }
        public string Notes { get; }
    }
}
