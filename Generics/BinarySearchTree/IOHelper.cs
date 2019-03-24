using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class IOHelper
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
                    Notify();
                }
            } while (!successParse);

            return input;
        }

        public static void Notify()
        {
            Console.WriteLine("Incorrect input");
        }

        public static void PrintGeneric(IEnumerable<KeyValuePair<object, object>> result)
        {
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }
    }
}
