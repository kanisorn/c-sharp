using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.BST;
using Tree.BT;


namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySearchTree<int> tree = new BinarySearchTree<int>();
            //tree.Add(5);

            //tree.PrintInorder();
            //tree.Add(5);

            //tree.PrintInorder();
            //tree.Add(50);

            //tree.PrintInorder();
            // tree.Add(14);
            //tree.Add(4);

            //tree.PrintInorder();

            //Console.WriteLine();

            // Console.WriteLine(tree.FindLowestCommonAncesterLoop(tree.Root, 0, 100).Data);
            //Console.WriteLine(tree.DoesNodeExist(50));
            //Console.WriteLine(new BSTValidator().Check(tree.Root));

            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new BinaryTree<int>.Node<int>(null, null, 10);
            tree.Root.Left = new BinaryTree<int>.Node<int>(null, null, 100);
            tree.Root.Right = new BinaryTree<int>.Node<int>(null, null, 50);
            tree.Root.Left.Right = new BinaryTree<int>.Node<int>(null, null, 2);
            Console.WriteLine(tree.FindLCS(2, 100));
            //Stack<int> path = new Stack<int>();
            //bool hasItem = tree.FindPath(tree.Root, path, 2);

            //Console.WriteLine(hasItem + string.Join(",", path.ToArray()));
            Console.ReadLine();
        }



    }
}
