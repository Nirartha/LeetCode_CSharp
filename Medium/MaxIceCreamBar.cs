using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    /*
     * 1833. Maximum Ice Cream Bars
     * Runtime: 332 ms, faster than 72.73% of C# online submissions for Maximum Ice Cream Bars.
     * Memory Usage: 49.7 MB, less than 54.55% of C# online submissions for Maximum Ice Cream Bars.
     * 
     */
    class MaxIceCreamBar
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            int result = 0;
            var newCosts = costs.OrderBy(x => x).ToList();
            foreach (int ele in newCosts)
            {
                if (coins - ele < 0) break;
                coins -= ele;
                result++;
            }

            return result;
        }
    }
}
