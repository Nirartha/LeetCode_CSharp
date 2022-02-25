using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePractice
{
    /** 1985. Find the Kth Largest Integer in the Array
     * 
     * Constraints:
     * A. 1 <= k <= nums.length <= 104
     * B. 1 <= nums[i].length <= 100
     * C. nums[i] consists of only digits.
     * D. nums[i] will not have any leading zeros.
     */
    class FindKthLargestInt
    {
        public string KthLargestNumber(string[] nums, int k)
        {
            //Method I Array.Sort
            Array.Sort(nums, (a, b) =>
            {
                if (a.Length == b.Length) return b.CompareTo(a);
                return b.Length.CompareTo(a.Length);
            });

            return nums[k - 1];

            //Method II: Linq
            //return nums.OrderBy(x => x.Length).ThenBy(x => x).ElementAt(nums.Length - k);
        }

        private string[] sortStrArr(string[] nums)
        {
            for (int  i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    /* Time Limit Exceeded
                    if (nums[i].Length == nums[j].Length)
                    {
                        if (nums[j].CompareTo(nums[i]) == 1)
                        {
                            string temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                    else
                    {
                        if (nums[j].Length.CompareTo(nums[i].Length) == 1)
                        {
                            string temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                    */
                    /* Unhandled exception. System.OverflowException: Value was either too large or too small for an Int64.
                    if (nums[j].Length > nums[i].Length || (nums[j].Length == nums[i].Length && long.Parse(nums[j].Substring(0, 1)) > long.Parse(nums[i].Substring(0, 1))))
                    {
                        string temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                    
                    if (long.Parse(nums[j]) > long.Parse(nums[i]))
                    {
                        string temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                    */
                }
            }
            return nums;
        }
    }
}
