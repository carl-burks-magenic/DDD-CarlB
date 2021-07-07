using System;
using System.Collections.Generic;
using System.Linq;
using SharedKernel;

namespace OrderContext.Model
{
    /// <summary>
    /// An order should maybe be a collection of something more generic like an item insated of parts.
    /// We may want to sell redbulls in the future.
    /// </summary>
    public class Order : IEntity<Guid>
    {
        public Guid Id => throw new NotImplementedException();
        public Customer Customer { get; private set; }
        public OrderState OrderState { get; private set; }
        public List<Product> Parts { get; private set; }

        public Order(Customer customer, List<Product> parts)
        {
            Customer = customer;
            Parts = parts;
        }

        public void UpdateOrderState(OrderState orderState)
        {
            //Validate that the order can be moved into this state.
            OrderState = orderState;
        }

        public double GetOrderCost() => Parts.Sum(p => p.Cost);

        public void AddPart(Product part) => Parts.Add(part);

        public void RemovePart(Product part) => Parts.Remove(part);
    }
}
