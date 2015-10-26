using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Reverse
{
    class StringReverse
    {
        public string Reverse(string input)
        {
            if (input.Length == 0) return string.Empty;

            string output = "";
            //int index = 0;
            string temp = "";

            for (int i=0; i<input.Length; i++)
            {
                if (input[i]!=' ')
                {
                    temp += input[i];
                }
                else
                {
                    output = " " + temp + output;
                    temp = "";
                }
            }
            return temp + output;
        }
    }
}
