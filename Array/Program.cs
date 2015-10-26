using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Counter;
namespace Array
{
    class Program
    {
        void MoveToTheEnd(ref int[] arr)
        {
            int currentIndex = arr.Length - 1;
            for (int i = currentIndex; i >= 0; i--)
            {
                if (arr[i] != -1)
                {
                    arr[currentIndex] = arr[i];
                    currentIndex--;
                }
            }
        }
        // merge
        void Merger(ref int[] larger, int[] smaller, int sizeOfL, int sizeOfS)
        {
            int total = sizeOfL + sizeOfS;
            int index = 0, indexL = total - sizeOfL, indexS = 0;

            while (index < total)
            {
                if (indexL == total || (indexS < sizeOfS && smaller[indexS] <= larger[indexL]))
                {
                    larger[index] = smaller[indexS];
                    indexS++;
                }
                else
                {
                    larger[index] = larger[indexL];
                    indexL++;
                }
                index++;
            }
        }

        static void Main(string[] args)
        {
            int[] larger = { 10, 20, -1,-1, 60, 80, 90, -1, -1, 100};
            int[] smaller = { 30, -600, -800, -900 };
            //IntegerCounter counter = new IntegerCounter();
            //counter.FindFrequency(ref src);
            //new Merger().MoveToEnd(ref larger);
            //new Merger().Merge(ref larger, smaller, 6, 4);

            new Program().MoveToTheEnd(ref  larger);
            new Program().Merger(ref larger, smaller, 6, 4);
            Console.WriteLine(string.Join(",", larger));


            Console.ReadLine();
        }
    }
    class A
    {
        public A()
        {
            Console.Write("a");

        }
    }
    class B : A
    {
        public B()
        {
            Console.Write("b");
        }
    }
}
