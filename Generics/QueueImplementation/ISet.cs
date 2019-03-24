using System.Collections.Generic;

namespace QueueImplementation
{
    public interface ISet
    {
        ISetIterator GetIterator(List<int> inputQueue, int inputPosition);
    }
}
