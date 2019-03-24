using System;

namespace PolynomalCalculator
{
    class Program
    {
        public enum CalculationMethod
        {
            Addition = 1,
            Substraction,
            Multiplication,
            Division
        }

        static void Main()
        {
            var firstPolynomial = PolynomialsHelper.CreatePolynomialByUserInput();
            var secondPolynomial = PolynomialsHelper.CreatePolynomialByUserInput();

            var firstPolynomToCalculate = new PolynomialsCalculation(firstPolynomial);
            var secondPolynomToCalculate = new PolynomialsCalculation(secondPolynomial);

            Console.WriteLine("Choose calculation method: \n 1 - for addition \n 2 - for substraction \n 3 - for multiplication \n 4 - for division");
            int.TryParse(Console.ReadLine(), out int method);
            if (!Enum.IsDefined(typeof(CalculationMethod), method))
            {
                Console.WriteLine("Incorrect input");
            }

            var calculationMethod = (CalculationMethod)method;
            PolynomialsCalculation polynomialResult = null;
            switch (calculationMethod)
            {
                case CalculationMethod.Addition:
                    polynomialResult = firstPolynomToCalculate + secondPolynomToCalculate;
                    break;
                case CalculationMethod.Substraction:
                    polynomialResult = firstPolynomToCalculate - secondPolynomToCalculate;
                    break;
                case CalculationMethod.Multiplication:
                    polynomialResult = firstPolynomToCalculate * secondPolynomToCalculate;
                    break;
                case CalculationMethod.Division:
                    polynomialResult = firstPolynomToCalculate / secondPolynomToCalculate;
                    break;
            }
            if (polynomialResult != null)
            {
                try
                {
                    Console.WriteLine(polynomialResult.ToString());
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
