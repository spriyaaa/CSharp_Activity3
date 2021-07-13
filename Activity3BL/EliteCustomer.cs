using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Activity3BL.CustomerCardType;

namespace Activity3BL
{
    public class EliteCustomer: Customer
    {
        private int ownedCoupons;

        public int OwnedCoupons
        {
            get
            {
                return ownedCoupons;
            }

            set
            {
                ownedCoupons = value;
            }
        }

        public EliteCustomer(string CustomerName, string Address, DateTime DateOfBirth, string EmailId, Gender Gender, string Password,int ownedCoupons)
        {
            /*            try
                        {
                            if (ownedCoupons < 0)
                            {
                                return false;
                            }

                        }
                        catch (IndexOutOfRangeException e)
                        {

                            //throw("Can't proceed...Invalid input");
                            Console.WriteLine(e.Message);
                            // Set IndexOutOfRangeException to the new exception's InnerException.
                            throw new ArgumentOutOfRangeException("Atleast one coupon should be owned by the customer", e);
                        }

                        finally
                        {

                        }
                        return true;*/

            if (ownedCoupons < 0)
            {
                throw (new FormatException("Atleast one coupon should be owned by the customer"));
            }

        }
    }
}