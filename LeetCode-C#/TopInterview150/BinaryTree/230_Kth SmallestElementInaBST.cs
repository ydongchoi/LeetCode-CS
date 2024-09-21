
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/kth-smallest-element-in-a-bst/

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _230_Kth_SmallestElementInaBST
    {
        private int _order;
        private int _answer;

        public int KthSmallest(TreeNode root, int k)
        {
            _order = 0;

            InorderTraversal(root, k);

            return _answer;
        }

        public void InorderTraversal(TreeNode cur, int k)
        {
            if (cur is null) return;

            InorderTraversal(cur.left, k);
            ++_order;
            if (_order == k) _answer = cur.val;
            InorderTraversal(cur.right, k);
        }
    }
}
