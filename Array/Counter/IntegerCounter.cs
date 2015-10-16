using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Counter
{
    class IntegerCounter
    {
        public void FindFrequency(ref int[] arr)
        {
            int i = 0;
            while(i<arr.Length)
            {
                PrintArray(arr);
                if (arr[i] <= 0)
                {
                    i++;
                    continue;
                }
                int elementIndex = arr[i] - 1;
                if (arr[elementIndex] >0)
                {
                    arr[i] = arr[elementIndex];
                    arr[elementIndex] = -1;
                }
                else
                {
                    arr[elementIndex]--;
                    arr[i] = 0;
                    i++;
                }

            }
        }
        public void PrintArray(int [] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
