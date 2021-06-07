using Common.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDBicycleShopOrderManagementService.Customer
{
    public class PhysicalAddress : ValueObject, IPhysicalAddress
    {
        public String Street { get; private set; }
        public String StreetAdditional { get; private set; }
        public String CountryCode { get; private set; }
        public String State { get; private set; }
        public String City { get; private set; }
        public String Postal { get; private set; }
        public PhysicalAddress(string street, string streetAdditional, string countryCode, string state, string city, string postal)
        {
            Street = street;
            StreetAdditional = streetAdditional;
            CountryCode = countryCode;
            State = state;
            City = city;
            Postal = postal;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return StreetAdditional;
            yield return CountryCode;
            yield return State;
            yield return City;
            yield return Postal;
        }
    }
}
