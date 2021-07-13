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
    public class RegularCustomerTests
    {
        [TestMethod()]
        public void RegularCustomerTest()
        {
            DateTime dt1 = new DateTime(1990, 07, 22);
            RegularCustomer reg1 = new RegularCustomer("simran", "patna", dt1, "s@ltts.com", Gender.Female, "star98");

            DateTime dt2 = new DateTime(1999, 07, 07);
            RegularCustomer reg2 = new RegularCustomer("priya", "kochi", dt2, "p@ltts.com", Gender.Female, "sun67");

            Assert.AreNotSame(reg1, reg2);

        }
    }
}