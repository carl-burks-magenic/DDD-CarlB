using Common.SeedWork;

namespace  DDDBicycleShopOrderManagementService.Customer {
    public class Customer: Entity, IAggregateRoot {
        public string Name { get; private set; }
        public Company Company { get; private set; }
        public EmailAddress PrimaryEmailAddress { get; private set; }
        public PhysicalAddress PrimaryBillingAddress { get; private set; }
        public Customer(int id, string name, string company, string emailaddress){
            //Skipping implementation
            Id = id;
            Name = name;
            Company = new Company(company);
            
        }
        //TODO:
        //public PhysicalAddress VerifyOrAddBillingAddress(string street, string streetAdditional, string countryCode, string state, string city, string postal)
        //{
        //}
        //public PhysicalAddress VerifyOrAddShippingAddress(string street, string streetAdditional, string countryCode, string state, string city, string postal)
        //{
        //}

        //public int GetCustomerId(){

        //}

        //public Address GetPrimaryMailingAddress(){

        //}
        //public Address GetPrimaryShippingAddress(){

        //}
        //public Company GetCompany(){
        //}

        //public void ChangeCompany(Company company){
        //}
        //public void ChangePrimaryMailingAddress(Address newAddress){
        //}
        //public void ChangeShippingMailingAddress(Address newAddress){
        //}

    }
}
