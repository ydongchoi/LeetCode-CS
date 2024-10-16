
// Time Complexity: O(n), Space Complexity: O(n)
// Link : https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/?envType=problem-list-v2&envId=tree

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _108_ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode answer = null;

            return MakeTree(answer, 0, nums.Length - 1, nums);
        }

        private TreeNode MakeTree(TreeNode cur, int start, int end, int[] nums)
        {
            if (start > end) return null;

            int mid = (start + end) / 2;
            cur = new TreeNode(nums[mid]);

            cur.left = MakeTree(cur.left, start, mid - 1, nums);
            cur.right = MakeTree(cur.right, mid + 1, end, nums);

            return cur;
        }
    }
}
