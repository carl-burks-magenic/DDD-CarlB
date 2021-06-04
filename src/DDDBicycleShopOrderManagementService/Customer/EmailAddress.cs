using Common.SeedWork;
using System;
using System.Collections.Generic;

namespace DDDBicycleShopOrderManagementService.Customer {
    public class EmailAddress : ValueObject {
        public EmailAddress(string address) {
            Address = address;
        }
        public String Address {get; private set;}

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Address;
        }
    }
}
