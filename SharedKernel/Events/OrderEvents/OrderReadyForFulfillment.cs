using System;

namespace SharedKernel.Events.OrderEvents
{
    public class  OrderReadyForFulfillment : IDomainEvent
    {
        public Guid OrderId { get; private set; }
        public OrderReadyForFulfillment(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
