using System;
using System.Collections.Generic;

namespace FibonacciNumbers
{
    public static class FibonacciNumbers
    {
        public static IEnumerable<int> ReturnFibonacciNumbers(int input)
        {
            try
            {
                CheckIfInt(input);
            }
            catch (Exception e)
            {
                throw e;
            }

            var prev = -1;
            var next = 1;
            for (var i = 0; i < input; i++)
            {
                var sum = prev + next;
                prev = next;
                next = sum;
                yield return sum;
            }
        }

        private static void CheckIfInt(int input)
        {
            if (input != (int) input)
            {
                Console.WriteLine("Argument is not integer");
            }
        }
    }
}
