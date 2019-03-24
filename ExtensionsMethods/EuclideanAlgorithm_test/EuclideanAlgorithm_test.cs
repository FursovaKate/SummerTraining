using EuclideanAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EuclideanAlgorithm_test
{
    [TestClass]
    public class FindGreatestCommonDivisorTest
    {
        [TestMethod]
        public void FindGreatestCommonDivisorForNumbers_2_4_8_16_expected2()
        {
            int[] inputArray = { 2, 4, 8, 16 };
            int expected = 2;
            int actual = inputArray.GetGreatestCommonDivisor();
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }

    [TestClass]
    public class FindGreatestCommonDivisorBinaryTest
    {
        [TestMethod]
        public void FindGreatestCommonDivisorBinaryForNumbers_2_4_8_16_expected2()
        {
            int[] inputArray = { 2, 4, 8, 16 };
            int expected = 2;
            int actual = inputArray.GetGreatestCommonDivisorBinary();
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
