using System;

namespace BinarySearch
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
                    Console.WriteLine("Incorrect input");

                }
            } while (!successParse);

            return input;
        }

        public static void Notify()
        {
            Console.WriteLine("Incorrect input");
        }
    }
}
