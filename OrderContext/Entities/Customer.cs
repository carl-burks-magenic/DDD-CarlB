using System;
using OrderContext.Values;
using SharedKernel;

namespace OrderContext.Model
{
    /// <summary>
    /// Contact information of the entity that created the order
    /// </summary>
    public class Customer : IEntity
    {
        public Guid Id { get; private set; }

        public Customer(Guid id)
        {
            Id = id;
        }

        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public string Name { get; set; }
    }
}
