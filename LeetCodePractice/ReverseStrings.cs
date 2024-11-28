using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class ReverseStrings
    {
        
            public void ReverseString(char[] s)
            {

                int first = 0;
                int last = s.Length - 1;

                while (first < last)
                {
                    char revrsString = s[first];
                    s[first] = s[last];
                    s[last] = revrsString;
                    first++;
                    last--;
                }
            }
        
    }
}
