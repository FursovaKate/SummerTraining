using System;
using System.Collections.Generic;

namespace PolynomalCalculator
{
    public static class PolynomialsHelper
    {
        public static double[] CreatePolynomialByUserInput()
        {
            var polynomialCoefficients = new List<double>();
            Console.WriteLine("\nEnter coefficients for the polynomial (press enter to stop):\n");
            while (true)
            {
                Console.WriteLine();
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }

                var successParse = double.TryParse(input.KeyChar.ToString(), out double firstPolynomialCoefficient);

                if (!successParse)
                {
                    Console.WriteLine("\nIncorrect input");
                }
                else
                {
                    polynomialCoefficients.Add(firstPolynomialCoefficient);

                }
            }
            return polynomialCoefficients.ToArray();
        }
    }
}
