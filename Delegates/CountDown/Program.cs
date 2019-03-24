using System;

namespace CountDown
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Set the timer");
            bool successParse;
            int userInput;
            do
            {
                successParse = int.TryParse(Console.ReadLine(), out userInput);
                if (!successParse)
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (!successParse);

            var broadcaster = new Broadcaster();
            broadcaster.OnCountDown += EventListener.PrintMessage;
            broadcaster.CountDown(userInput);

            Console.ReadKey();
        }
    }
}
