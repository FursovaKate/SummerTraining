using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearch;

namespace BinarySearch_test
{
    [TestClass]
    public class BinarySearcherTest
    {
        [TestMethod]
        public void BinarySearchTest()
        {
            var inputList = new List<int>{1,2,3,4,5};
            inputList = BinarySearcher.SortList(inputList);
            var numberToSearch = 3;
            var actual = BinarySearcher.BinarySearch(inputList, numberToSearch);
            var expected = 3;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
