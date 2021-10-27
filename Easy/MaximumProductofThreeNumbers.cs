using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class MaximumProductofThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            return Math.Max(nums[0] * nums[1] * nums[nums.Length - 1], nums[nums.Length - 3] * nums[nums.Length - 2] * nums[nums.Length - 1]);
        }
    }
}
