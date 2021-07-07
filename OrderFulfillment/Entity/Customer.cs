using System;
using SharedKernel;

namespace OrderFulfillment.Entity
{
    public class Customer : IEntity<Guid>
    {
        public Guid Id { get; set; }
    }
}
