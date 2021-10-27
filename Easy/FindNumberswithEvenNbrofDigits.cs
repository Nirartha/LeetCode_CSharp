using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    class FindNumberswithEvenNbrofDigits
    {
        public int FindNumbers(int[] nums)
        {
            return nums.Where(x => x.ToString().Length % 2 == 0).Count(); //Or nums.Count(x => x.ToString().Length % 2 == 0)
        }
    }
}
