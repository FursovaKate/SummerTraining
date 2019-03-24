using System;

namespace MatrixSorterDelegate
{
    public static class InputHelper
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
    }
}
