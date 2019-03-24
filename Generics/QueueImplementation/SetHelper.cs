using System;
using System.Collections.Generic;

namespace QueueImplementation
{
    public static class SetHelper
    {
        public static List<int> CreateList()
        {
            var inputList = new List<int>();
            while (true)
            {
                Console.WriteLine();
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
                var successParse = int.TryParse(input.KeyChar.ToString(), out var numberToAdd);
                if (!successParse)
                {
                    Console.WriteLine("Incorrect input");
                }

                if (successParse)
                {
                        inputList.Add(numberToAdd);
                }
          
            }
            return inputList;
        }

        public static void CheckUnique(int input, List<int> inputList)
        {
            if (inputList.Contains(input))
            {
                Console.WriteLine("Number is already in array");
            }
        }

        public static void CheckIfInt(int input)
        {
            if (input != (int)input)
            {
                Console.WriteLine("Argument is not integer");
            }
        }
    }
}
