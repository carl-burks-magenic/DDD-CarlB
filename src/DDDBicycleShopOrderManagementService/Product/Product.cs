using Common.SeedWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDBicycleShopOrderManagementService.Order {
    public class Product : Entity {

        public Product(int id, string name, decimal price)
        {
            this.Id = id;
            Name = name;
            ProductPricing productPricing = new ProductPricing(price);
            productPricingHistories = new List<ProductPricing>() { productPricing };
            AddDomainEvent(new ProductPriceChangedEvent(id, name, productPricing));
        }

        public class ProductPriceChangedEvent: INotification
        {
            public ProductPriceChangedEvent(int id, string name, ProductPricing productPricing)
            {
                Id = id;
                Name = name;
                ProductPricing = productPricing;
            }

            public int Id { get; }
            public string Name { get; }
            public ProductPricing ProductPricing { get; }
        }
        public string Name { get; private set; }
        public decimal Price { get => productPricingHistories.Last().Price; }
        public IOrderedEnumerable<ProductPricing> PricingHistory { get => (IOrderedEnumerable<ProductPricing>)productPricingHistories; }

        private List<ProductPricing> productPricingHistories;
        public ProductPricing UpdatePrice(decimal price)
        {
            ProductPricing pp = new ProductPricing(price);
            productPricingHistories.Add(pp);
            AddDomainEvent(new ProductPriceChangedEvent(this.Id, this.Name,pp));
            return pp;
        }

        public class ProductPricing: ValueObject{

            public int ProductId { get; private set; }
            public decimal Price { get; private set; }
            public DateTime Datetime { get; private set; }
            public ProductPricing(decimal price){
                Price = price;
                Datetime = DateTime.Now;
            }

            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return Price;
                yield return Datetime;
            }
        }

    }
}
