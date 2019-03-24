using System;
using System.Diagnostics;

namespace EuclideanAlgorithm
{
    public class Program
    {
        static void Main()
        {
            var numbers = ArrayHelper.CreateNumberList();
            ArrayHelper.PrintNumberArray(numbers);
            Console.WriteLine("Choose method (1 - for Euclidian, 2 for Binary):");
            var method = Console.ReadLine();
            switch (method)
            {
                case "1":
                    {
                        Stopwatch timer = Stopwatch.StartNew();
                        var greatestCommonDivisor = numbers.GetGreatestCommonDivisor();
                        timer.Stop();
                        Console.WriteLine("Time taken: {0}ms", timer.Elapsed.TotalMilliseconds);
                        Console.WriteLine(greatestCommonDivisor);
                        break;
                    }
                case "2":
                    {
                        var timer = Stopwatch.StartNew();
                        var greatestCommonDivisor = numbers.GetGreatestCommonDivisorBinary();
                        timer.Stop();
                        Console.WriteLine("Time taken: {0}ms", timer.Elapsed.TotalMilliseconds);
                        Console.WriteLine(greatestCommonDivisor);
                        break;
                    }
            }
        }
    }
}
