using SharedKernel;
using System.Collections.Generic;

namespace Events.ComputerFulfilmentEvents
{
    public class VendorRefundedBrokenPartEvent : IDomainEvent
    {
        public VendorRefundedBrokenPartEvent(IEnumerable<string> DocumentationReferenceId)
        {
            this.DocumentationReferenceId = DocumentationReferenceId;
        }

        public IEnumerable<string> DocumentationReferenceId { get; }
    }
}