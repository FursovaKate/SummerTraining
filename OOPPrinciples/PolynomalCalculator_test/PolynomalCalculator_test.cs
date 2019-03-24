using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolynomalCalculator;

namespace PolynomalCalculator_test
{
    [TestClass]
    public class PolynomialsCalculationTest
    {
        [TestMethod]
        public void PolynomialsCalculationTestOverloadingAddition()
        {
            double[] firstPolynomial = { 1, 2, 3 };
            double[] secondPolynomial = { 4, 5, 6 };
            PolynomialsCalculation firstPolynomToCalculate = new PolynomialsCalculation(firstPolynomial);
            PolynomialsCalculation secondPolynomToCalculate = new PolynomialsCalculation(secondPolynomial);
            PolynomialsCalculation polynomialSum = firstPolynomToCalculate + secondPolynomToCalculate;
            string actual = polynomialSum.ToString();
            string expected = "9x^2+7x+5";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void PolynomialsCalculationTestOverloadingSubstraction()
        {
            double[] firstPolynomial = { 6, 5, 4 };
            double[] secondPolynomial = { 3, 2, 1 };
            PolynomialsCalculation firstPolynomToCalculate = new PolynomialsCalculation(firstPolynomial);
            PolynomialsCalculation secondPolynomToCalculate = new PolynomialsCalculation(secondPolynomial);
            PolynomialsCalculation polynomialSum = firstPolynomToCalculate - secondPolynomToCalculate;
            string actual = polynomialSum.ToString();
            string expected = "3x^2+3x+3";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void PolynomialsCalculationTestOverloadingMultiplication()
        {
            double[] firstPolynomial = { 1, 2, 3 };
            double[] secondPolynomial = { 4, 5, 6 };
            PolynomialsCalculation firstPolynomToCalculate = new PolynomialsCalculation(firstPolynomial);
            PolynomialsCalculation secondPolynomToCalculate = new PolynomialsCalculation(secondPolynomial);
            PolynomialsCalculation polynomialSum = firstPolynomToCalculate * secondPolynomToCalculate;
            string actual = polynomialSum.ToString();
            string expected = "18x^2+10x+4";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void PolynomialsCalculationTestOverloadingDivision()
        {
            double[] firstPolynomial = { 4, 10, 18 };
            double[] secondPolynomial = { 4, 5, 6 };
            PolynomialsCalculation firstPolynomToCalculate = new PolynomialsCalculation(firstPolynomial);
            PolynomialsCalculation secondPolynomToCalculate = new PolynomialsCalculation(secondPolynomial);
            PolynomialsCalculation polynomialSum = firstPolynomToCalculate / secondPolynomToCalculate;
            string actual = polynomialSum.ToString();
            string expected = "3x^2+2x+1";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
