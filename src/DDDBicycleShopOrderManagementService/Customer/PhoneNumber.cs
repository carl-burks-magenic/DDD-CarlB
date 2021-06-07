using System;
using System.Collections.Generic;
using System.Text;

namespace DDDBicycleShopOrderManagementService.Customer
{
    public class PhoneNumber
    {
        public PhoneNumber(string number)
        {
            if(number.Length > 15)
            {
                throw new ArgumentOutOfRangeException("Phone numbers must be equal to or less than 15 characters");
            }
            if (number.Length < 5)
            {
                throw new ArgumentOutOfRangeException("Phone numbers must be longer than five characters");
            }
            this.Number = number;
        }
        public string Number {get; private set;}
    }
}
