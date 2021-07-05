using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerBlueprintEvents
{
    public class BlueprintPublishedEvent : IDomainEvent
    {
        public BlueprintPublishedEvent(string blueprintId)
        {
            BlueprintId = blueprintId;
        }

        public string BlueprintId { get; }
    }
}
