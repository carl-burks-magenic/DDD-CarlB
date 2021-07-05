using SharedKernel;
using System.Collections.Generic;

namespace Events.VendorReturnsEvents
{
    public class VendorClaimsPartNotDefectiveEvent : IDomainEvent
    {
        public VendorClaimsPartNotDefectiveEvent(string PartId, IEnumerable<string> DocumentationReferenceId)
        {
            this.PartId = PartId;
            this.DocumentationReferenceId = DocumentationReferenceId;
        }

        public string PartId { get; }
        public IEnumerable<string> DocumentationReferenceId { get; }
    }
}