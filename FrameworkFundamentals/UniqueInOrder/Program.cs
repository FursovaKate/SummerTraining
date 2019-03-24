using System;
using System.Linq;

namespace UniqueInOrder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter any sequence");
            var input = Console.ReadLine();

            var inputArray = input.ToArray();

            var result = UniqueItem.UniqueInOrder(inputArray);

            foreach (var val in result)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}
