using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity3BL;
using static Activity3BL.Gender;
using static Activity3BL.CustomerCardType;


namespace Activity3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(1990, 07, 22);

            EliteCustomer ec1 = new EliteCustomer("simran", "patna", dt1, "s@ltts.com", Gender.Female, "star", 2);
            Console.WriteLine(ec1.OwnedCoupons);

            PrivilegedCustomer priv1 = new PrivilegedCustomer("simran", "patna", dt1, "s@ltts.com", Gender.Female, "star", CustomerCardType.Platinum);
            Console.WriteLine(priv1.CardType);

            
            RegularCustomer reg1 = new RegularCustomer("simran", "patna", dt1, "s@ltts.com", Gender.Female, "star98");
            Console.WriteLine(reg1.DiscountPercentage);
        }
    }
}
