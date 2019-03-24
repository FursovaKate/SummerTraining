using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCases;

namespace StringCases_test
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void ConvertToStringCaseTest()
        {
            
            string inputString = "a clash of KINGS";
            string exceptionalWords = "a an the of";
            string actual = StringHelper.ConvertToStringCase(inputString, exceptionalWords);
            string expected = "A Clash of Kings";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
