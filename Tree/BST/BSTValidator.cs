using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tree.BST
{
    class BSTValidator
    {
        public bool Check(BinarySearchTree<int>.Node<int> root)
        {
            if (root == null)
                return true;

            return Check(root.Left, int.MinValue, root.Data) && Check(root.Right, root.Data, int.MaxValue);
        }

        private bool Check(BinarySearchTree<int>.Node<int> current, int min, int max)
        {
            if (current == null)
                return true;

            if (current.Data > max || current.Data < min)
                return false;

            return Check(current.Left, min, current.Data - 1) &&
                Check(current.Right, current.Data + 1, max);
        }
    }
}
