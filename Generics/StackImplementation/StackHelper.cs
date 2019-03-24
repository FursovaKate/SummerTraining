using System;
using System.Collections.Generic;

namespace StackImplementation
{
    public static class StackHelper
    {
        public static List<int> CreateStack()
        {
            var inputStack = new List<int>();
            while (true)
            {
                Console.WriteLine();
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
                var successParse = int.TryParse(input.KeyChar.ToString(), out int numberToAdd);
                if (!successParse)
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    inputStack.Add(numberToAdd);
                }
            }
            return inputStack;
        }

        public static void CheckIfInt(int input)
        {
            if (input!=(int)input)
            {
                Console.WriteLine("Argument is not integer");
            }
        }
    }
}
