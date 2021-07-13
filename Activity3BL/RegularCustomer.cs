using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity3BL
{
    public class RegularCustomer : Customer
    {
        private double discountPercentage;

        public double DiscountPercentage
        {
            get
            {
                return discountPercentage;
            }
            set
            {
                discountPercentage = value;
            }

        }

        public RegularCustomer(string CustomerName, string Address, DateTime DateOfBirth, string EmailId, Gender Gender, string Password)
        {
            discountPercentage = 2;
            if (discountPercentage < 0)
            {
                throw (new FormatException("Discount has to be given to the customer"));
            }
        }
    }
}