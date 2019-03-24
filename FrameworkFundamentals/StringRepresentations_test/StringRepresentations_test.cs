using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringRepresentations;

namespace StringRepresentations_test
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void GetNameTest()
        {
            var customer = new Customer();
            customer.Name = "Jeffrey Richter";
            var actual = customer.Name;
            var expected = "Jeffrey Richter";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void GetContactPhoneTest()
        {
            var customer = new Customer();
            customer.ContactPhone = "+1 (425) 555-0100";
            var actual = customer.ContactPhone;
            var expected = "+1 (425) 555-0100";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void GetRevenueTest()
        {
            var customer = new Customer();
            customer.Revenue = 1000000;
            var actual = customer.GetRevenue();
            var expected = "$1,000,000";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ReceiveFullInfoTest()
        {
            var customer = new Customer();
            customer.Name = "Jeffrey Richter";
            customer.ContactPhone = "+1 (425) 555-0100";
            customer.Revenue = 1000000;

            var actual = customer.ReceiveFullInfo();
            var expected = "Jeffrey Richter, +1 (425) 555-0100, $1,000,000";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ReceiveNameAndRevenueTest()
        {
            var customer = new Customer();
            customer.Name = "Jeffrey Richter";
            customer.Revenue = 1000000;

            var actual = customer.ReceiveNameAndRevenue();
            var expected = "Jeffrey Richter, $1,000,000";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ReceiveNameAndPhoneTest()
        {
            var customer = new Customer();
            customer.Name = "Jeffrey Richter";
            customer.ContactPhone = "+1 (425) 555-0100";

            var actual = customer.ReceiveNameAndPhone();
            var expected = "Jeffrey Richter, +1 (425) 555-0100";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}

