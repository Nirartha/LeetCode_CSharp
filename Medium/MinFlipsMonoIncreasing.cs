using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    class MinFlipsMonoIncreasing
    {
        public int MinFlipsMonoIncr(string s)
        {
            int leftOne = 0;
            int rightZero = s.Count(c => c == '0');
            int min = s.Length - rightZero;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1') 
                {
                    min = Math.Min(min, leftOne + rightZero);
                    leftOne++;
                }
                else rightZero--;
            }
            return min;
        }
    }
}
