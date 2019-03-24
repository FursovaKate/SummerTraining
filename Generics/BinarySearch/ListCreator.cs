using System;
using System.Collections.Generic;

namespace BinarySearch
{
    public static class ListCreator
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
                    IOHelper.Notify();
                }
                else
                {
                    try
                    {
                        CheckIfInt(numberToAdd);
                        inputList.Add(numberToAdd);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
            return inputList;
        }

        private static void CheckIfInt(int input)
        {
            if (input != (int)input)
            {
                Console.WriteLine("Argument is not integer");
            }
        }
    }
}
