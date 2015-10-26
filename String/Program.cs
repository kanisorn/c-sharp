using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String.Palindrome;
using String.Reverse;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome.Palindrome p = new Palindrome.Palindrome();
            // Console.WriteLine(p.IsPlalindromeByLoop("a"));
            Console.WriteLine(new StringReverse().Reverse("I am a Boy"));
            Console.ReadLine();
        }
    }
}
