using SharedKernel;

namespace Events.ComputerBlueprintContext
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
