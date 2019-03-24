using System;
using System.Numerics;

namespace SumBigNumbers
{
    public static class BigNumbersCalculation
    {
        public static string CalculateBigNumbers(string firstNumber, string secondNumber)
        {
            BigInteger firstNumberBigInt = 0;
            BigInteger secondNumberBigInt = 0;

            try
            {
                firstNumberBigInt = ParseInput(firstNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                secondNumberBigInt = ParseInput(firstNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            var sum = firstNumberBigInt + secondNumberBigInt;
            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("Sum is equal " + sum);
            return sum.ToString();
        }

        private static BigInteger ParseInput(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error("String is empty");
                throw new ArgumentNullException("String is empty");
            }
            return BigInteger.Parse(input);
        }
    }
}