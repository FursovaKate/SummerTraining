
namespace QueueImplementation
{
    public interface ISetIterator
    {
        int GetNext();
        int GetPrevious();
        int CountElements();
        void AddElement(int input);
        void RemoveElement(int elementPosition);
    }
}
