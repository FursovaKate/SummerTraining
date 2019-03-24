using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose travesing type:\n 1- to preorder, 2 - to inorder, 3 - to postorder");
            var root = BinarySearchTree.CreateRootNode();
            var leftNode = BinarySearchTree.CreateLeftNode();
            var rightNode = BinarySearchTree.CreateRightNode();

            var preOrder = new PreOrder();
            var inOrder = new InOrder();
            var postOrder = new PostOrder();

            var method = IOHelper.ParseInput();
            if (method == 1)
            {
                var result = preOrder.Traverse(root, leftNode, rightNode);
                IOHelper.PrintGeneric(result);
            }

            if (method == 2)
            {
                var result = inOrder.Traverse(root, leftNode, rightNode);
                IOHelper.PrintGeneric(result);
            }

            if (method == 3)
            {
                var result = postOrder.Traverse(root, leftNode, rightNode);
                IOHelper.PrintGeneric(result);
            }
        }
    }
}
