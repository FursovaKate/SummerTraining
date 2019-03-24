using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using UniqueInOrder;

namespace UniqueInOrder_test
{
    [TestClass]
    public class UniqueItemTest
    {
        [TestMethod]
        public void UniqueInStringOrderTest()
        {
            var input = "AAAABBBCCDAABBB";
            char[] inputArray = input.ToCharArray();
            var actual = UniqueItem.UniqueInOrder(inputArray);
            var expected = "ABCDAB";
            CollectionAssert.AreEquivalent(expected.ToList(), actual.ToList());
        }

        [TestMethod]
        public void UniqueInListOrderTest()
        {
            var input = new List<double> { 1.1, 2.2, 2.2, 3.3 };
            var actual = UniqueItem.UniqueInOrder(input);
            var expected = new List<double> { 1.1, 2.2, 3.3 };
            CollectionAssert.AreEquivalent(expected.ToList(), actual.ToList());
        }
    }
}
