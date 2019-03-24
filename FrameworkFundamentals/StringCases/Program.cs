using System;
using NLog;

namespace StringCases
{
    public class Program
    {
        public static void Main()
        {
            string inputString;
            do
            {
                Console.WriteLine("Enter string to case convert");

                inputString = Console.ReadLine();
                if (string.IsNullOrEmpty(inputString))
                {
                    var logger = LogManager.GetCurrentClassLogger();
                    logger.Error("String is empty");
                }
            } while (string.IsNullOrEmpty(inputString));

            Console.WriteLine("Enter exceptional words");
            var exceptionalWords = Console.ReadLine();

            var resultString = StringHelper.ConvertToStringCase(inputString, exceptionalWords);
            Console.WriteLine(resultString);
            Console.ReadLine();
        }
    }
}