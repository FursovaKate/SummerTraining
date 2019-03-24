using System;

namespace DoubleConverter
{
    class Program
    {
        static void Main()
        {
            double input;
            bool successParse;
            do
            {
                successParse = double.TryParse(Console.ReadLine(), out input);
                if (!successParse)
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (!successParse);

            Console.WriteLine(input.ConvertToIEEE754());
            Console.ReadLine();
        }
    }
}