using Common.SeedWork;
using MediatR;

namespace  DDDBicycleShopOrderManagementService.Customer {
    public class Customer: Entity, IAggregateRoot {
        public string Name { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public Company Company { get; private set; }
        public EmailAddress PrimaryEmailAddress { get; private set; }
        public PhysicalAddress PrimaryBillingAddress { get; private set; }
        public PhysicalAddress PrimaryShippingAddress { get; private set; }

        #region Events

        public class CustomerAddedDomainEvent : INotification
        {
            public CustomerAddedDomainEvent(int id, string name){
                this.CustomerId = id;
                this.Name =name;
             }
            public string Name { get; private set; }
            public int CustomerId { get; private set; }
        }
        public class CustomerPhoneChangedDomainEvent : INotification
        {
            public CustomerPhoneChangedDomainEvent(int id, string name, PhoneNumber phoneNumber)
            {
                this.CustomerId = id;
                this.Name = name;
                PhoneNumber = phoneNumber;
            }
            public string Name { get; private set; }
            public PhoneNumber PhoneNumber { get; }
            public int CustomerId { get; private set; }
        }

        public class CustomerNewPrimaryEmailAddressAddedDomainEvent : INotification
        {
            public CustomerNewPrimaryEmailAddressAddedDomainEvent(string name, EmailAddress emailAddress)
            {
                this.Name = name;
                this.PrimaryEmailAddress = emailAddress;
            }
            public string Name { get; private set; }
            public EmailAddress PrimaryEmailAddress { get; private set; }
        }
        public class CustomerNewShippingAddressAddedDomainEvent : INotification
        {
            public CustomerNewShippingAddressAddedDomainEvent(string name, PhysicalAddress address)
            {
                this.Name = name;
                this.PrimaryShippingAddress = address;
            }
            public string Name { get; private set; }
            public PhysicalAddress PrimaryShippingAddress { get; private set; }
        }
        public class CustomerNewBillingAddressAddedDomainEvent : INotification
        {
            public CustomerNewBillingAddressAddedDomainEvent(string name, PhysicalAddress address)
            {
                this.Name = name;
                this.PrimaryBillingAddress = address;
            }
            public string Name { get; private set; }
            public PhysicalAddress PrimaryBillingAddress { get; private set; }
        }
        
        public class CustomerCompanyChangedEvent : INotification
        {
            public CustomerCompanyChangedEvent(string name, Company company)
            {
                this.Name = name;
                this.Company = company;
            }
            public string Name { get; private set; }
            public Company Company { get; private set; }
        }

        #endregion
        public Customer(int id, string name, Company company, PhoneNumber phoneNumber, EmailAddress emailaddress, PhysicalAddress shippingAddress, PhysicalAddress billingAddress){
            //Skipping implementation
            Id = id;
            Name = name;
            Company = company;
            PhoneNumber = phoneNumber;
            PrimaryEmailAddress = emailaddress;
            PrimaryBillingAddress = billingAddress;
            PrimaryShippingAddress = shippingAddress;

            AddDomainEvent(new CustomerAddedDomainEvent(id,name));
            AddDomainEvent(new CustomerNewPrimaryEmailAddressAddedDomainEvent(name, emailaddress));
            AddDomainEvent(new CustomerNewShippingAddressAddedDomainEvent(name,shippingAddress));
            AddDomainEvent(new CustomerNewBillingAddressAddedDomainEvent(name,billingAddress));

        }


        public PhysicalAddress AddBillingAddress(string street, string streetAdditional, string countryCode, string state, string city, string postal)
        {
            PhysicalAddress address = new PhysicalAddress(street, streetAdditional, countryCode, state, city, postal);
            this.PrimaryBillingAddress = address;
            AddDomainEvent(new CustomerNewBillingAddressAddedDomainEvent(this.Name, address));
            return address;
        }

        public PhysicalAddress AddShippingAddress(string street, string streetAdditional, string countryCode, string state, string city, string postal)
        {
            PhysicalAddress address = new PhysicalAddress(street, streetAdditional, countryCode, state, city, postal);
            this.PrimaryShippingAddress = address;
            AddDomainEvent(new CustomerNewShippingAddressAddedDomainEvent(this.Name, address));
            return address;
        }

        public EmailAddress AddEmailAddress(EmailAddress address)
        {
            this.PrimaryEmailAddress = address;
            AddDomainEvent(new CustomerNewPrimaryEmailAddressAddedDomainEvent(this.Name, address));
            return address;
        }

        public Company ChangeCompany(Company company)
        {
            this.Company = company;
            AddDomainEvent(new CustomerCompanyChangedEvent(this.Name, company));
            return company;
        }
        public PhoneNumber ChangePhoneNumber(PhoneNumber phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            AddDomainEvent(new CustomerPhoneChangedDomainEvent(this.Id, this.Name, phoneNumber));
            return phoneNumber;
        }
    }
}
