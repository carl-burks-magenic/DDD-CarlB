using Common.SeedWork;
using System.Collections.Generic;

namespace DDDBicycleShopOrderManagementService.Order {
    public class Order: Entity {
        //private Id id;
        //public Order(int id, Customer customer){
        //    //Skipping implementation
        //    // creating an order address will come from the customer
        //    // rehydrating an old order will use the address from the time of ordering
        //}

        //public int GetId(){

        //}

        //public AddItemToOrder(Product product, int quantity){

        //}
        //public IEnumerable<OrderItem> GetOrderDetails(){

        //}
        //public void DeactivateOrder(){
        //    //If we have shipped this probably shouldn't be allowed.
        //}
        protected Order()
        {
            _items = new List<OrderItem>();
        }
        private List<OrderItem> _items;

        public IReadOnlyCollection<OrderItem> OrderItems => _items;

        public class OrderItem : ValueObject {
            public int ProductId {get;private set;}
            public int Quantity { get; private set; }
            public decimal Price { get; private set; }
            public OrderItem(int productId, int quantity, decimal price){
                ProductId = productId;
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
