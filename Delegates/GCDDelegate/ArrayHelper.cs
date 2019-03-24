using System;
using System.Collections.Generic;

namespace GCDDelegate
{
    public static class ArrayHelper
    {
        public static int[] CreateNumberList()
        {
            var numbers = new List<int>();

            var addNumber = 1;
            while (true)
            {
                Console.WriteLine("\nEnter your numbers (press enter to stop input): ");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }

                var successParse = int.TryParse(input.KeyChar.ToString(), out addNumber);

                if (!successParse)
                {
                    Console.WriteLine("\nIncorrect input");
                }
                else
                {
                    numbers.Add(addNumber);
                }
            }
            return numbers.ToArray();
        }

        public static void PrintNumberArray(int[] numbers)
        {
            Console.Write("Array: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
