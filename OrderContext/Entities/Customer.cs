using System;
using SharedKernel;

namespace OrderContext.Model
{
    /// <summary>
    /// Contact information of the entity that created the order
    /// </summary>
    public class Customer : IEntity<Guid>
    {
        public Guid Id { get; private set; }

        public Customer(Guid id)
        {
            Id = id;
        }

        public Address BillingAddress { get; set; }
        public string Name { get; set; }
    }
}
