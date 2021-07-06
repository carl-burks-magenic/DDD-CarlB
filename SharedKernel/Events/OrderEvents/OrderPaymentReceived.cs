using System;

namespace SharedKernel.Events.OrderEvents
{
    public class OrderPaymentReceived : IDomainEvent
    {
        public Guid OrderId { get; private set; }
        public OrderPaymentReceived(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
