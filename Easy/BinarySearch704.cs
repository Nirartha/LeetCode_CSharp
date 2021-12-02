using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class BinarySearch704
    {
        public int Search(int[] nums, int target)
        {
            return BinarySearch(nums, target, 0, nums.Length - 1);
        }

        private int BinarySearch(int[] nums, int target, int start, int end)
        {
            int mid = (start + end) / 2;
            if (nums[mid] == target) return mid;
            if (start >= end) return -1;
            if (target > nums[mid]) return BinarySearch(nums, target, mid + 1, end);
            else return BinarySearch(nums, target, start, mid);
        }
    }
}
