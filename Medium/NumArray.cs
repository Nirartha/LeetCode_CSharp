using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class NumArray
    {
        int[] nums;
        public NumArray(int[] nums)
        {
            this.nums = nums;
        }

        public void Update(int index, int val)
        {
            this.nums[index] = val;
        }

        public int SumRange(int left, int right)
        {
            int result = 0;
            for (int i = left; i <= right; i++)
            {
                result += nums[i];
            }
            return result;
        }
    }

    /**
     * Runtime: 1373 ms, faster than 25.70% of C# online submissions for Range Sum Query - Mutable.
     * Memory Usage: 96.8 MB, less than 26.39% of C# online submissions for Range Sum Query - Mutable.
     */
    class NumArray_SegmentTree
    {
        int[] nums;
        SegmentTreeNode root;
        public NumArray_SegmentTree(int[] nums)
        {
            this.nums = nums;
            this.root = buildTree(0, nums.Length - 1, nums);
        }

        public void Update(int index, int val)
        {
            setValue(this.root, index, val);
            this.nums[index] = val;
        }

        public int SumRange(int left, int right)
        {
            return sumValue(this.root, left, right);
        }

        public SegmentTreeNode buildTree(int start, int end, int[] vals)
        {
            // mention: both start and end value can not out of the int[] length
            if (vals == null || start >= vals.Length || end >= vals.Length || end < start) return null;

            SegmentTreeNode segmentTreeNode = new SegmentTreeNode() { start = start, end = end };
            if (start == end) 
            {
                segmentTreeNode.val = vals[start];
            }
            else
            {
                int mid = (start + end) / 2;
                segmentTreeNode.left = buildTree(start, mid, vals);
                segmentTreeNode.right = buildTree(mid + 1, end, vals);
                segmentTreeNode.val = segmentTreeNode.left.val + segmentTreeNode.right.val;
            }
            return segmentTreeNode;
        }

        public int setValue(SegmentTreeNode root, int index, int val)
        {
            if (root == null || index < root.start || index > root.end) return 0;

            if (index == root.start && index == root.end)
            {
                root.val = val;
                return val;
            }

            int mid = (root.start + root.end) / 2;

            //left
            if (index >= root.start && index <= mid)
            {
                //no node
                if (root.left == null)
                {
                    root.left = new SegmentTreeNode() { start = root.start, end = mid };
                }
                setValue(root.left, index, val);
            }
            else //right
            {
                //no node
                if (root.right == null)
                {
                    root.right = new SegmentTreeNode() { start = mid + 1, end = root.end };
                }
                setValue(root.right, index, val);
            }

            root.val = (root.left != null ? root.left.val : 0) + (root.right != null ? root.right.val : 0);
            return root.val;
        }

        public int sumValue(SegmentTreeNode root, int start, int end)
        {
            if (root == null || end < root.start || start > root.end) return 0;
            if (start <= root.start && end >= root.end) return root.val;

            return sumValue(root.left, start, end) + sumValue(root.right, start, end);
        }
    }

    public class SegmentTreeNode
    {
        public int val;
        public int start;
        public int end;
        public SegmentTreeNode left;
        public SegmentTreeNode right;
    }
}
