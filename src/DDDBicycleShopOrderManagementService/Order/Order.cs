using Common.SeedWork;
using MediatR;
using System.Collections.Generic;

namespace DDDBicycleShopOrderManagementService.Order {
    public class Order : Entity
    {
        protected Order(int customerId, string customerName, IPhysicalAddress physicalAddress)
        {
            _items = new List<OrderItem>();
            CustomerId = customerId;
            CustomerName = customerName;
            PhysicalAddress = physicalAddress;
            AddDomainEvent(new OrderCreatedEvent(this));
        }
        private List<OrderItem> _items;
        private bool finalized;

        public IReadOnlyCollection<OrderItem> OrderItems => _items;

        public bool Finalized { get => finalized;}
        public int CustomerId { get; }
        public string CustomerName { get; }
        public IPhysicalAddress PhysicalAddress { get; }

        public Order FinalizeOrder()
        {
            if (finalized)
            {
                return this;
            }
            finalized = true;
            AddDomainEvent(new OrderFinalizedDomainEvent(this));
            return this;
        }
        public OrderItem AddProductToOrder(int productId, int quantity, string productName, decimal productPrice)
        {
            //if the order has been finalized we shouldn't be able to add to it
            if (finalized)
            {
                return null;
            }

            OrderItem result = new OrderItem(productId, productName, quantity, productPrice);
            _items.Add(result);
            AddDomainEvent(new ProductAddedToOrderDomainEvent(this, result));
            return result;
        }
        public class OrderFinalizedDomainEvent: INotification
        {
            public OrderFinalizedDomainEvent(Order order)
            {
                Order = order;
            }

            public Order Order { get; }
        }
        public class ProductAddedToOrderDomainEvent : INotification
        {
            public ProductAddedToOrderDomainEvent(Order order, OrderItem orderItem)
            {
                Order = order;
                OrderItem = orderItem;
            }

            public Order Order { get; }
            public OrderItem OrderItem { get; }
        }
        public class OrderCreatedEvent : INotification
        {
            public OrderCreatedEvent(Order order)
            {
                Order = order;
            }

            public Order Order { get; }
        }
        public class OrderItem : ValueObject
        {
            public int ProductId { get; private set; }
            public string ProductName { get; private set; }
            public int Quantity { get; private set; }
            public decimal Price { get; private set; }
            public OrderItem(int productId, string productName, int quantity, decimal price)
            {
                ProductId = productId;
                ProductName = productName;
                Quantity = quantity;
                Price = price;
            }

            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return ProductId;
                yield return Quantity;
                yield return Price;
            }
        }

    }
}
