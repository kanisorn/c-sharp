using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.BT
{
    class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        
        public bool FindPath(Node<T> parent, Stack<T> path, T target)
        {
            if (parent == null)
                return false;

            path.Push(parent.Data);
           // Console.WriteLine(string.Join(",", path.ToArray()));

            if (parent.Data.CompareTo(target) == 0)
                return true;

            if ((parent.Left != null && FindPath(parent.Left, path, target)) ||
                parent.Right != null && FindPath(parent.Right, path, target))
                return true;

            path.Pop();
            //Console.WriteLine(string.Join(",", path));
            return false;
        }

        public T FindLCS(T n1, T n2)
        {
            Stack<T> p1=new Stack<T>(), 
                     p2=new Stack<T>();
            if (FindPath(this.Root, p1, n1) && FindPath(this.Root, p2, n2))
            {
                T[] arr1 = p1.ToArray(), arr2 = p2.ToArray();
                Array.Reverse(arr1);
                Array.Reverse(arr2);
                Console.WriteLine(string.Join(",", arr1));
                Console.WriteLine(string.Join(",", arr2));
                int i = 0;
                for (i=0; i<arr1.Length && i<arr2.Length; i++)
                {
                    if (arr1[i].CompareTo(arr2[i]) != 0)
                        break;
                }
                if (i != 0)
                    return arr1[i - 1];
            }

            return default(T);
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
