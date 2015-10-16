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
    
        static void Main(string[] args)
        {
            int[] src = { 2, 2, 6, 3, 2, 1};
            IntegerCounter counter = new IntegerCounter();
            counter.FindFrequency(ref src);



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
