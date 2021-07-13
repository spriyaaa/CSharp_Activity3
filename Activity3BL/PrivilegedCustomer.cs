using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Activity3BL.CustomerCardType;

namespace Activity3BL
{
    public class PrivilegedCustomer : Customer
    {
        private CustomerCardType cardType;
        public CustomerCardType CardType
        {
            get
            {
                return cardType;
            }
            set
            {
                cardType = value;
            }

        }


        public PrivilegedCustomer(string CustomerName, string Address, DateTime DateOfBirth, string EmailId, Gender Gender, string Password,CustomerCardType cardType)
        {
            


        }
    }
}
