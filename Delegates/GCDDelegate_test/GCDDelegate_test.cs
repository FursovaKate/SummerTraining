using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCDDelegate;

namespace GCDDelegate_test
{
    [TestClass]
    public class FindGreatestCommonDivisorTest
    {
        [TestMethod]
        public void FindGreatestCommonDivisor_EucledianMethod()
        {
            int[] inputArray = { 3, 18, 21, 24 };
            int expected = 3;
            int actual = inputArray.GetGreatestCommonDivisor();
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }

    [TestClass]
    public class FindGreatestCommonDivisorBinaryTest
    {
        [TestMethod]
        public void FindGreatestCommonDivisor_SteinsMethod()
        {
            int[] inputArray = { 3, 18, 21, 24 };
            int expected = 3;
            int actual = inputArray.GetGreatestCommonDivisorBinary();
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
