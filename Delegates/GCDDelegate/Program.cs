using System;
using System.Diagnostics;

namespace GCDDelegate
{
    class Program
    {
        public delegate int CalculationMethod();

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
                        var chooseCalculationMethod = new CalculationMethod(numbers.GetGreatestCommonDivisor);

                        var timer = Stopwatch.StartNew();

                        var result = chooseCalculationMethod.Invoke();

                        timer.Stop();
                        Console.WriteLine("Time taken: {0}ms", timer.Elapsed.TotalMilliseconds);
                        Console.WriteLine("Greatest common divisor is: " + result);
                        Console.ReadLine();
                        break;
                    }
                case "2":
                    {
                        var chooseCalculationMethod = new CalculationMethod(numbers.GetGreatestCommonDivisorBinary);
                        var timer = Stopwatch.StartNew();

                        var result = chooseCalculationMethod.Invoke();

                        timer.Stop();
                        Console.WriteLine("Time taken: {0}ms", timer.Elapsed.TotalMilliseconds);

                        Console.WriteLine("Greatest common divisor is: " + result);
                        Console.ReadLine();
                        break;
                    }
            }
        }
    }
}