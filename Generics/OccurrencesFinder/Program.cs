using System;

namespace OccurrencesFinder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter word to find");
            var wordToFind = Console.ReadLine();
            var inputList = FileReader.ReadFile();
            var result = OccurrencesFinder.FindOccurences(inputList, wordToFind);
            if (result > 0)
            {
                Console.WriteLine(result + " occurences were found");
            }
            else
            {
                Console.WriteLine("No occurences were found");
            }
        }
    }
}
