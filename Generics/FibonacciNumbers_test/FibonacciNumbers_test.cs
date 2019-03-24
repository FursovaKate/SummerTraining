using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciNumbers;

namespace FibonacciNumbers_test
{
    [TestClass]
    public class FibonacciNumbersTest
    {
        [TestMethod]
        public void ReturnFibonacciNumbersTest()
        {
            var input = 6;
            var fibonacciNumber = FibonacciNumbers.ReturnFibonacciNumbers(input);
            var actual = new List<int>(fibonacciNumber);
            var expected = new List<int>{0, 1, 1, 2, 3 ,5};
            CollectionAssert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
