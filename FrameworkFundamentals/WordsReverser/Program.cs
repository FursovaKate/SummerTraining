using System;
using System.Linq;
using NLog;

namespace WordsReverser
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string to reverse");
            var input = Console.ReadLine();

            var result = WordsReverser.ReverseWords(input);
            var logger = LogManager.GetCurrentClassLogger();

            if (result == input)
            {
                logger.Info("Only one word was entered");
            }
            logger.Info("Word sequence was reversed");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public static class WordsReverser
    {
        public static string ReverseWords(string input)
        {
            try
            {
                CheckInput(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }

            return string.Join(" ", input.Split(' ').Reverse());
        }

        private static void CheckInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error("String is empty");
                Console.WriteLine("String is empty");
            }
        }
    }
}
