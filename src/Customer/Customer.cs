public namespace Customer {
    public class Customer: BaseAggregateRoot<int> {
        private Id id;
        public Customer(int id){
            //Skipping implementation
        }
        
        public int GetCustomerId(){
            
        }

        public Address GetPrimaryMailingAddress(){

        }
        public Address GetPrimaryShippingAddress(){

        }
        public Company GetCompany(){
        }

        public void ChangeCompany(Company company){
        }
        public void ChangePrimaryMailingAddress(Address newAddress){
        }
        public void ChangeShippingMailingAddress(Address newAddress){
        }

    }
}
