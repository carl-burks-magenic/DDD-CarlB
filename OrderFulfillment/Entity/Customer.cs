using System;
using SharedKernel;

namespace OrderFulfillment.Entity
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
    }
}
