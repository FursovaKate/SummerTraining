using System.Collections.Generic;

namespace QueueImplementation
{
    public class ClientClass : ISet
    {
        public ISetIterator GetIterator(List<int> inputSet, int inputPosition)
        {
            return new Iterator(inputSet, inputPosition);
        }
    }
}
