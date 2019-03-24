using System;

namespace StackImplementation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers to create stack (press enter to stop) \n");
            var inputStack = StackHelper.CreateStack();

            Console.WriteLine("Enter element index \n");
            var position = IOHelper.ParseInput();

            Console.WriteLine("Choose choose method:\n 1 - get previous element, 2 - get next element, 3 - count elements, 4 - add element, 5 - remove element");
            var method = IOHelper.ParseInput();

            var client = new ClientClass();
            var iterator = client.GetIterator(inputStack, position);
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
                IOHelper.Print(inputStack);
            }

            if (method == 5)
            {
                iterator.RemoveElement(position);
                IOHelper.Print(inputStack);
            }
        }
    }
}
