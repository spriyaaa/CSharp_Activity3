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
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {

        }

        [TestMethod()]
        public void CustomerTest1()
        {
            DateTime dt1 = new DateTime(2021, 07, 04);
            Customer c1 = new Customer("simran", "patna", dt1, "s@ltts.com", Gender.Female, "star");

            DateTime dt2 = new DateTime(2021, 07, 07);
            Customer c2 = new Customer("krishna", "kochi", dt2, "k@ltts.com", Gender.Male, "sun");

            Assert.AreNotSame(c1, c2);

        }
    }
}