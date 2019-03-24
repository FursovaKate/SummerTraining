using System.Collections.Generic;

namespace BinarySearchTree
{
    public interface ITraverseInterface
    {
        IEnumerable<KeyValuePair<object, object>> Traverse(Dictionary<object, object> root, Dictionary<object, object> leftNode, Dictionary<object, object> rightNode);
    }
}
