using SharedKernel;

namespace Events.ComputerFulfilmentEvents
{
    public class ReplacementPartInstalledEvent : IDomainEvent
    {
        public ReplacementPartInstalledEvent(string computerId, string badPartId, string newPartId)
        {

        }
        public string computerId { get;  }
        public string BadPart { get;  }
        public string NewPart { get;  }
    }
}