using System;

namespace QueueImplementation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers to create set (press enter to stop) \n");
            var inputList = SetHelper.CreateList();

            Console.WriteLine("Enter element index \n");
            var position = IOHelper.ParseInput();

            Console.WriteLine("Choose choose method:\n 1 - get previous element, 2 - get next element, 3 - count elements, 4 - add element, 5 - delete element");
            var method = IOHelper.ParseInput();

            var client = new ClientClass();
            var iterator = client.GetIterator(inputList, position);
            var input = IOHelper.ParseInput();

            if (method == 1)
            {
                Console.WriteLine("Previous: " + iterator.GetPrevious());
            }

            if (method == 2)
            {
                Console.WriteLine("Next: " + iterator.GetNext());
            }

            if (method == 3)
            {
                Console.WriteLine("Total: " + iterator.CountElements());
            }

            if (method == 4)
            {
                Console.WriteLine("Enter number");
                iterator.AddElement(input);
                IOHelper.Print(inputList);
            }

            if (method == 5)
            {
                iterator.RemoveElement(position);
                IOHelper.Print(inputList);
            }
        }
    }
}
