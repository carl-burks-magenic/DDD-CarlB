using Common.SeedWork;
using System.Collections.Generic;

namespace DDDBicycleShopOrderManagementService.Order {
    public class Product: Entity {

        public class ProductPricing: ValueObject{

            public int ProductId { get; private set; }
            public decimal Price { get; private set; }

            public ProductPricing(decimal price){
                Price = price;
            }

            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return Price; 
            }
        }

    }
}
