using System;
using System.Collections.Generic;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            var input = IOHelper.ParseInput();
            var fibonacciNumber = FibonacciNumbers.ReturnFibonacciNumbers(input);
            var fibonacciNumbersList = new List<int>(fibonacciNumber);
            IOHelper.Print(fibonacciNumbersList);
        }
    }
}
