using System;

namespace SharedKernel.Events.OrderEvents
{
    public class OrderCreated : IDomainEvent
    {
        public Guid OrderId { get; private set; }
        public OrderCreated(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
