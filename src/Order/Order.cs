public namespace Order {
    public class Order: BaseAggregateRoot<int> {
        private Id id;
        public Order(int id, Customer customer){
            //Skipping implementation
            // creating an order address will come from the customer
            // rehydrating an old order will use the address from the time of ordering
        }
        
        public int GetId(){
            
        }

        public AddItemToOrder(Product product, int quantity){

        }
        public IEnumerable<OrderItem> GetOrderDetails(){

        }
        public void DeactivateOrder(){
            //If we have shipped this probably shouldn't be allowed.
        }
        public class OrderItem: ValueObject{
            public OrderItem(int productId, int quantity, decimal price){

            }
        }

    }
}
