using System;

namespace NullAbleIdentifier
{
    class Program
    {
        static void Main()
        {
            int? inputNullable = 345;
            bool c = inputNullable.IsNull();
            Console.WriteLine(c.ToString());
        }
    }
}
