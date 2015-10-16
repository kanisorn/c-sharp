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
