using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;
            int curIndex = 1;
            int curNum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > curNum)
                {
                    nums[curIndex] = nums[i];
                    curNum = nums[i];
                    curIndex++;
                }
            }
            return curIndex;
        }
    }
}
