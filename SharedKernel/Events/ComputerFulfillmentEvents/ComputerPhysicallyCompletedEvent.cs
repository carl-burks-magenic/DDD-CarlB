using SharedKernel;

namespace Events.ComputerFulfilmentEvents
{
    public class ComputerPhysicallyCompletedEvent : IDomainEvent
    {
        public ComputerPhysicallyCompletedEvent(string computerId)
        {

        }
        public string ComputerId { get;  }

    }
}