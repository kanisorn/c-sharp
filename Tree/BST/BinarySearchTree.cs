using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.BST
{
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public BinarySearchTree()
        {
            
        }

        public Node<T> FindLowestCommonAncester(Node<T> root, int n1, int n2)
        {
            if (root == null)
                return null;

            if (root.Data.CompareTo(n1)<0 && root.Data.CompareTo(n2) <0)
                return FindLowestCommonAncester(root.Right, n1, n2);

            if (root.Data.CompareTo(n1) >0  && root.Data.CompareTo(n2) >0)
                return FindLowestCommonAncester(root.Left, n1, n2);

            return root;
        }
        public Node<T> FindLowestCommonAncesterLoop(Node<T> root, int n1, int n2)
        {
            while (root != null)
            {
                if (root.Data.CompareTo(n1) < 0 && root.Data.CompareTo(n2) < 0)
                    root = root.Right;

                else if (root.Data.CompareTo(n1) > 0 && root.Data.CompareTo(n2) > 0)
                    root = root.Left;

                else
                    break;
            }

            return root;
        }

        public bool DoesNodeExist(T data)
        {
            bool found = false;
            Node<T> walker = Root;
            while(walker!=null)
            {
                if (walker.Data.CompareTo(data) == 0)
                {
                    found = true;
                    break;
                }
                else if (walker.Data.CompareTo(data) < 0)
                {
                    walker = walker.Right;
                }
                else
                {
                    walker = walker.Left;
                }

            }

            return found;
        }

        public void Add(T data)
        {
            Node<T> tmp = new Node<T>(null, null, data);
            Node<T> parent = null;
            Node<T> current = Root;

            while(current !=null)
            {
                int result = current.Data.CompareTo(data);
                if (result == 0)
                {
                    Console.WriteLine("duplicate");
                    return;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    parent = current;
                    current = current.Left;
                }
            }

            if (parent == null)
            {
                Root = tmp;
            }
            else
            {
                int result = parent.Data.CompareTo(data);
                if (result < 0)
                    parent.Right = tmp;
                else
                    parent.Left = tmp;
                    
            }
        }

        public void PrintInorder()
        {
            PrintInorder(Root);
        }
        private void PrintInorder(Node<T> current)
        {
            if (current != null)
            {
                PrintInorder(current.Left);

                Console.WriteLine(current.Data + " ");

                PrintInorder(current.Right);
                
            }
        }

        public class Node<T>
        {
            public Node<T> Left { get; set; } 
            public Node<T> Right { get; set; }
            public T Data { get; set; }

            public Node(Node<T> left, Node<T> right, T data)
            {
                Left = left;
                Right = right;
                Data = data;
            }
        }
    }
}
