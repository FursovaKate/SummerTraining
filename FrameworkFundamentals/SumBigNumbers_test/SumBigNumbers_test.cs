using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumBigNumbers;

namespace SumBigNumbers_test
{
    [TestClass]
    public class BigNumbersCalculationTest
    {
        [TestMethod]
        public void CalculateBigNumbersTest()
        {
            var firstNumber = "91389681247993671255432112000000";
            var secondNumber = "90315837410896312071002088037140000";
            var actual = BigNumbersCalculation.CalculateBigNumbers(firstNumber, secondNumber);
            var expected = "182779362495987342510864224000000";

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
