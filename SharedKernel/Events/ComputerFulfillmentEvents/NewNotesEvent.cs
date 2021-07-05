using SharedKernel;

namespace Events.ComputerFulfilmentEvents
{
    public class NewNotesEvent : IDomainEvent
    {
        public NewNotesEvent(string computerId, string notes)
        {
            ComputerId = computerId;
            Notes = notes;
        }

        public string ComputerId { get; }
        public string Notes { get; }
    }
}