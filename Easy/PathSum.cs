using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            int res = targetSum - root.val;
            if (res == 0 && root.left == null && root.right == null) return true;
            if (HasPathSum(root.left, res))
                return true;
            if (HasPathSum(root.right, res))
                return true;

            return false;
        }
    }
}
