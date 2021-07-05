using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerBlueprintEvents
{
    public class BlueprintReviewedEvent: IDomainEvent
    {

        public BlueprintReviewedEvent(string blueprintId, string Reviewer, DateTime ReviewDate)
        {

        }
        string BlueprintId { get; }
        string Reviewer { get; }
        string ReviewDate { get; }
    }
}
