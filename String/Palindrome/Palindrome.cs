using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Palindrome
{
    class Palindrome
    {
        public bool IsPalindromeByArray(string str)
        {
            if (str.Length == 0)
                return false;

            char[] arr1 = str.ToArray();
            Array.Reverse(arr1);

            string target = string.Join("", arr1);
            if (target.Equals(str, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
        public bool IsPlalindromeByLoop(string str)
        {
            if (str.Length == 0)
                return false;

            int min = 0, max = str.Length - 1;
            str = str.ToLower();
            while(min < max)
            {
                if (!str[min].Equals(str[max]))
                    return false;

                min++; max--;
            }

            return true;
        }
    }
}
