using System;
using System.Linq;
using System.Text;

namespace PolynomalCalculator
{
    public class PolynomialsCalculation
    {
        private double[] polynomialCoefficient;

        public PolynomialsCalculation(double[] polynomialCoefficient = default(double[]))
        {
            this.polynomialCoefficient = polynomialCoefficient;
        }

        public static PolynomialsCalculation operator +(PolynomialsCalculation firstPolynomialCoefficients, PolynomialsCalculation secondPolynomialCoefficients)
        {
            var polynomialsResult = new PolynomialsCalculation();

            polynomialsResult.polynomialCoefficient = firstPolynomialCoefficients.polynomialCoefficient.Select((x, index) => x + secondPolynomialCoefficients.polynomialCoefficient[index]).ToArray();
            return polynomialsResult;
        }

        public static PolynomialsCalculation operator -(PolynomialsCalculation firstPolynomialCoefficients, PolynomialsCalculation secondPolynomialCoefficients)
        {
            var polynomialsResult = new PolynomialsCalculation();
            polynomialsResult.polynomialCoefficient = (firstPolynomialCoefficients.polynomialCoefficient).Select((x, index) => x - (secondPolynomialCoefficients.polynomialCoefficient)[index]).ToArray();
            return polynomialsResult;
        }

        public static PolynomialsCalculation operator *(PolynomialsCalculation firstPolynomialCoefficients, PolynomialsCalculation secondPolynomialCoefficients)
        {
            var polynomialsResult = new PolynomialsCalculation();
            polynomialsResult.polynomialCoefficient = (firstPolynomialCoefficients.polynomialCoefficient).Select((x, index) => x * (secondPolynomialCoefficients.polynomialCoefficient)[index]).ToArray();
            return polynomialsResult;
        }

        public static PolynomialsCalculation operator /(PolynomialsCalculation firstPolynomialCoefficients, PolynomialsCalculation secondPolynomialCoefficients)
        {
            var polynomialsResult = new PolynomialsCalculation();
            polynomialsResult.polynomialCoefficient = (firstPolynomialCoefficients.polynomialCoefficient).Select((x, index) => x / (secondPolynomialCoefficients.polynomialCoefficient)[index]).ToArray();
            return polynomialsResult;
        }

        public override string ToString()
        {
            var outputPolynomial = new StringBuilder();
            for (int i = polynomialCoefficient.Length - 1; i >= 0; --i)
            {
                if (polynomialCoefficient[i] == 0)
                {
                    continue;
                }

                if (polynomialCoefficient[i] > 0 && outputPolynomial.Length > 0)
                {
                    outputPolynomial.Append('+');
                }

                if (polynomialCoefficient[i] < 0)
                {
                    outputPolynomial.Append('-');
                }
                if (Math.Abs(polynomialCoefficient[i]) != 1 || i == 0)
                {
                    outputPolynomial.Append(Math.Abs(polynomialCoefficient[i]));
                }

                if (i > 0)
                {
                    outputPolynomial.Append('x');
                }
                if (i > 1) outputPolynomial.Append('^').Append(i);
            }

            if (outputPolynomial.Length == 0)
            {
                throw new ArgumentException("Output is null");
            }
            return outputPolynomial.ToString();
        }
    }
}
