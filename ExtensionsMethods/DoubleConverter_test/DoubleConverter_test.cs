using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoubleConverter;

namespace DoubleConverter_test
{
    [TestClass]
    public class DoubleConverterTest
    {
        [TestMethod]
        public void ConverterTestPositiveValue()
        {
            double inputNumber = 255.255;
            string actual = inputNumber.ConvertToIEEE754();
            string expected = "0100000001101111111010000010100011110101110000101000111101011100";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ConverterTestNegativeValue()
        {
            double inputNumber = -255.255;
            string actual = inputNumber.ConvertToIEEE754();
            string expected = "1100000001101111111010000010100011110101110000101000111101011100";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ConverterTestMinValue()
        {
            double inputNumber = double.MinValue;
            string actual = inputNumber.ConvertToIEEE754();
            string expected = "1111111111101111111111111111111111111111111111111111111111111111";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ConverterTestNaN()
        {
            double inputNumber = double.NaN;
            string actual = inputNumber.ConvertToIEEE754();
            string expected = "1111111111111000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
