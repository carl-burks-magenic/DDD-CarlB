using SharedKernel;

namespace Events.ComputerBlueprintEvents
{
    public class BlueprintPublishFailureEvent : IDomainEvent
    {
        public BlueprintPublishFailureEvent(string blueprintId)
        {
            BlueprintId = blueprintId;
        }

        public string BlueprintId { get; }
    }
}
