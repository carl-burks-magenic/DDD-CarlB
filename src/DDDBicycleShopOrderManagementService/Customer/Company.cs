using Common.SeedWork;
using System;
using System.Collections.Generic;

namespace DDDBicycleShopOrderManagementService.Customer {
    public class Company : ValueObject {
        public Company(string name) {
            Name = name;
        }
        public String Name {get; private set;}

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}
