using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class ClimbingStairs 
    {
        public int ClimbStairs(int n)
        {
            //Dynamic Programming
            if (n < 2) return 1;
            int result = 0;
            int firstStep = 1;
            int secondStep = 1;

            for (int i = 2; i <= n; i++)
            {
                result = firstStep + secondStep;
                firstStep = secondStep;
                secondStep = result;
            }

            return result;
        }
    }
}
