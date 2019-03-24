using System.Collections.Generic;

namespace BinarySearchTree
{
    public class PostOrder : ITraverseInterface
    {
        public IEnumerable<KeyValuePair<object, object>> Traverse(Dictionary<object, object> root, Dictionary<object, object> leftNode, Dictionary<object, object> rightNode)
        {
            foreach (var element in leftNode)
            {
                yield return element;
            }
            foreach (var element in rightNode)
            {
                yield return element;
            }
            foreach (var element in root)
            {
                yield return element;
            }
        }
    }
}
