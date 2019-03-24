using System;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nEnter numbers to fill list (press enter to stop):\n");
            var inputList = ListCreator.CreateList();
            inputList = BinarySearcher.SortList(inputList);
            Console.WriteLine("\nEnter number to seach\n");
            var numberToSearch = IOHelper.ParseInput();
            var result = BinarySearcher.BinarySearch(inputList, numberToSearch);
            if (result > 0)
            {
                Console.WriteLine("Element found " + result);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
