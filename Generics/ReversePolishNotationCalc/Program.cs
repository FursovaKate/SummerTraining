using System;

namespace ReversePolishNotationCalc
{
    class Program
    {
        static void Main()
        {
            var input = "5 1 2 + 4 * + 3 -";
            var result = Calculator.Calculate(input);
            Console.WriteLine("Result : " + result);
            Console.ReadKey();
        }
    }
}
