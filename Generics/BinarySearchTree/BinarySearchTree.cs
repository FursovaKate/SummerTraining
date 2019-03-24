using System.Collections.Generic;

namespace BinarySearchTree
{
    public static class BinarySearchTree
    {
        public static Dictionary<object, object> CreateRootNode()
        {
            var root = new Dictionary<object, object>();
            root.Add(8, 0);
            return root;
        }

        public static Dictionary<object, object> CreateLeftNode()
        {
            var leftNode = new Dictionary<object, object>();
            leftNode.Add(3, 1);
            leftNode.Add(1, 2);
            leftNode.Add(6, 2);
            leftNode.Add(4, 3);
            leftNode.Add(7, 3);
            return leftNode;
        }

        public static Dictionary<object, object> CreateRightNode()
        {
            var rightNode = new Dictionary<object, object>();
            rightNode.Add(10, 1);
            rightNode.Add(14, 2);
            rightNode.Add(13, 3);
            return rightNode;
        }
    }
}
