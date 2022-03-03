using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    /**
     * 1980. Find Unique Binary String
     * 
     * Runtime: 92 ms, faster than 96.77% of C# online submissions for Find Unique Binary String.
     * Memory Usage: 40 MB, less than 25.81% of C# online submissions for Find Unique Binary String.
     * 
     * Constraints:
     * n == nums.length
     * 1 <= n <= 16
     * nums[i].length == n
     * nums[i] is either '0' or '1'.
     * All the strings of nums are unique.
     * 
     */
    class FindUniBinStr
    {
        public string FindDifferentBinaryString(string[] nums)
        {
            int n = nums.Length;
            double topN = Math.Pow(2, n);
            for (int i = 0; i < topN; i++)
            {
                var target = Convert.ToString(i, 2).PadLeft(n, '0');
                if (!isAppeared(nums, target)) return target;
            }
            return "";
        }

        private bool isAppeared(string[] nums, string target)
        {
            foreach (string element in nums)
            {
                if (element == target) return true;
            }
            return false;
        }
    }
}
