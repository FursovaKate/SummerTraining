using System;
using System.Collections.Generic;

namespace StackImplementation
{
    public static class IOHelper
    {
        public static int ParseInput()
        {
            bool successParse;
            int input;
            do
            {
                successParse = int.TryParse(Console.ReadLine(), out input);
                if (!successParse)
                {
                   Console.WriteLine();
                }
            } while (!successParse);

            return input;
        }

        public static void Print(List<int> resultList)
        {
            foreach (var element in resultList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
