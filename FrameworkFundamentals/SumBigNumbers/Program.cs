using System;

namespace SumBigNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Enter second number");
            var secondNumber = Console.ReadLine();
            var result = BigNumbersCalculation.CalculateBigNumbers(firstNumber, secondNumber);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
