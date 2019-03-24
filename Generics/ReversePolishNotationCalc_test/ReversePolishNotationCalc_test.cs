using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversePolishNotationCalc;

namespace ReversePolishNotationCalc_test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalculateTestResultPositive()
        {
            var input = "5 1 2 + 4 * + 3 -";
            var actual = Calculator.Calculate(input);
            var expected = 14;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void CalculateTestResultNegative()
        {
            var input = "20 50 -";
            var actual = Calculator.Calculate(input);
            var expected = -30;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
