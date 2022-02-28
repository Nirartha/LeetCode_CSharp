using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class MinDis2TargetElement
    {
        public int GetMinDistance(int[] nums, int target, int start)
        {
            if (nums[start] == target) return 0;
            else
            {
                int result = 0;
                int leftDis = 0;
                int rightDis = 0;
                int index = 1;
                while (result == 0)
                {
                    if (start - index >= 0)
                    {
                        leftDis++;
                        if (nums[start - index] == target) result = leftDis;
                    }

                    if (start + index < nums.Length)
                    {
                        rightDis++;
                        if (nums[start + index] == target) result = rightDis;
                    }
                    index++;
                }
                return result;
            }
        }
    }
}
