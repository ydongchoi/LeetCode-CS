using System;
using System.Collections.Generic;

// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/diameter-of-binary-tree/

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _543_DiameterOfBinaryTree
    {
        private int _answer;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            _answer = 0;
            GetMaxDepth(root);

            return _answer;
        }

        public int GetMaxDepth(TreeNode cur)
        {
            if (cur is null)
            {
                return -1;
            }

            int left = GetMaxDepth(cur.left) + 1;
            int right = GetMaxDepth(cur.right) + 1;

            int merge = left + right;

            _answer = _answer >= merge ? _answer : merge;

            return left > right ? left : right;
        }
    }
}
