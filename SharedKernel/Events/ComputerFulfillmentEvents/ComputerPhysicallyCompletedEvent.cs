using SharedKernel;

namespace Events.ComputerFulfilmentEvents
{
    internal class ComputerPhysicallyCompletedEvent : IDomainEvent
    {
        public ComputerPhysicallyCompletedEvent(string computerId)
        {

        }
        public string ComputerId { get;  }

    }
}