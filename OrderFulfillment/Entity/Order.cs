using System;
using OrderFulfillment.Value;
using SharedKernel;

namespace OrderFulfillment.Entity
{
    public class Order : IEntity<Guid>
    {
        public OrderState OrderState { get; set; }

        public Guid Id { get; set; }

        public Customer Customer { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
