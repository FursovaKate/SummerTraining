using System;

namespace ShapesHierarchy
{
    public static class ShapeHelper
    {
        public static double ParseInput()
        {
            bool successParse;
            double input;
            do
            {
                successParse = double.TryParse(Console.ReadLine(), out input);
                if (!successParse)
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (!successParse);

            return input;
        }

        public static void PrintResult(double area, double perimiter)
        {
            Console.WriteLine("\nArea: "+ area);
            Console.WriteLine("\nPerimiter: " + perimiter);
        }
    }
}
