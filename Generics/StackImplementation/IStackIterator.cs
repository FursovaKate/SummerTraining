
namespace StackImplementation
{
    public interface IStackIterator
    {
        int GetNext();
        int GetPrevious();
        int CountElements();
        void AddElement(int input);
        void RemoveElement(int elementPosition);
    }
}
