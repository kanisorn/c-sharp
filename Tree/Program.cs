using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.BST;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);

            //tree.PrintInorder();
            tree.Add(5);

            //tree.PrintInorder();
            tree.Add(50);

            //tree.PrintInorder();
            tree.Add(14);

            tree.PrintInorder();

            Console.WriteLine(new BSTValidator().Check(tree.Root));
            Console.ReadLine();
        }
    }
}
