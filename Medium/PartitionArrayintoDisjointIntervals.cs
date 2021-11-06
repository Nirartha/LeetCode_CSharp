using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class PartitionArrayintoDisjointIntervals
    {
        public int PartitionDisjoint(int[] nums)
        {
            int leftIndex = 0, curMax = nums[0], leftMax = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < leftMax)
                {
                    leftIndex = i;
                    leftMax = curMax;
                }
                curMax = Math.Max(curMax, nums[i]);
            }
            return leftIndex + 1;
        }
    }
}
