using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Counter
{
    class Merger
    {
        public void MoveToEnd(ref int [] arr)
        {
            int j = arr.Length - 1;
            for (int i=arr.Length-1; i>=0; i--)
            {
                if (arr[i] != -1)
                {
                    arr[j] = arr[i];
                    j--;
                }
            }
            //Console.Write("j=" + j); // arr[j] = -1;
        }

        public void Merge(ref int[] a, int[] b, int n, int m)
        {
            int total = n + m;
            int index = 0, i = a.Length - n, j = 0;

            while (index < total-1)
            {
                if ( j == m || (i < total-1 && a[i] < b[j]))
                {
                    a[index] = a[i];
                    i++;
                }
                else
                {
                    a[index] = b[j];
                    j++;
                }
                index++;
            }
        }

        // merge two arrays
        //public int [] 
    }
}
