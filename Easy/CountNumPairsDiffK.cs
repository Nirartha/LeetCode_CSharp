using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class CountNumPairsDiffK
    {
        /**
         * 2006. Count Number of Pairs With Absolute Difference K
         * 
         * Constraints:
         * A. 1 <= nums.length <= 200
         * B. 1 <= nums[i] <= 100
         * c. 1 <= k <= 99
         */
        public int CountKDifference(int[] nums, int k)
        {
            if (nums.Length < 2) return 0;
            int result = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k) result++;
                }
            }

            return result;
        }
    }
}
