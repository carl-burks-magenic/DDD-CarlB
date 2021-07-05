using SharedKernel;

namespace Events.ComputerFulfilmentEvents
{
    public class ComputerPassedDiagnosticsEvent : IDomainEvent
    {
        public ComputerPassedDiagnosticsEvent(string computerId)
        {

        }
        public string ComputerId { get;  }
    }
}