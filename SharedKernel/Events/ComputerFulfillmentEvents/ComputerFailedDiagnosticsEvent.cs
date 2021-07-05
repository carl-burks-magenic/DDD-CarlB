using SharedKernel;

namespace Events.ComputerFulfilmentEvents
{
    public class ComputerFailedDiagnosticsEvent : IDomainEvent
    {
        public ComputerFailedDiagnosticsEvent(string computerId)
        {
            ComputerId = computerId;
        }

        public string ComputerId { get; }
    }
}