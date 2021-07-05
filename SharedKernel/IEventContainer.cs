using System;

namespace SharedKernel
{
    public interface IEventContainer
    {
        public void AddDomainEvent(IDomainEvent domainEvent);
        public void PublishEvents();
    }
}
