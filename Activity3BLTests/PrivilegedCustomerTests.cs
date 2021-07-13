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
    public class PrivilegedCustomerTests
    {
        [TestMethod()]
        public void PrivilegedCustomerTest()
        {
            DateTime dt1 = new DateTime(1990, 07, 04);
            PrivilegedCustomer priv1 = new PrivilegedCustomer("simran", "patna", dt1, "s@ltts.com", Gender.Female, "star", CustomerCardType.Platinum);

            DateTime dt2 = new DateTime(1991, 07, 07);
            PrivilegedCustomer priv2 = new PrivilegedCustomer("priya", "kochi", dt2, "p@ltts.com", Gender.Female, "star", CustomerCardType.Silver);

            Assert.AreNotSame(priv1, priv2);

        }
    }
}