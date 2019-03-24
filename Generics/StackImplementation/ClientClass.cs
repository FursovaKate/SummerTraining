using System.Collections.Generic;

namespace StackImplementation
{
    public class ClientClass : IStack
    {
        public IStackIterator GetIterator(List<int> inputStack, int inputPosition)
        {
            return new Iterator(inputStack, inputPosition);
        }
    }
}
