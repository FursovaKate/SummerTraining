using System.Collections.Generic;

namespace StackImplementation
{
    public interface IStack
    {
        IStackIterator GetIterator(List<int> inputStack, int inputPosition);
    }
}
