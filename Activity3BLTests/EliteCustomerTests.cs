using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity3BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3BL.Tests
{
    [TestClass()]
    public class EliteCustomerTests
    {
        [TestMethod()]
        public void EliteCustomerTest()
        {
 

            DateTime dt1 = new DateTime(2021, 07, 04);
            EliteCustomer ec1 = new EliteCustomer("simran", "patna", dt1, "s@ltts.com", Gender.Female, "star", 2);

            DateTime dt2 = new DateTime(2021, 07, 07);
            EliteCustomer ec2 = new EliteCustomer("simran", "patna", dt2, "s@ltts.com", Gender.Female, "star", 2);

            Assert.AreNotSame(ec1, ec2);
        }
    }
}