
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/flatten-binary-tree-to-linked-list/

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public  class _114_FlattenBinaryTreeLinkedList
    {
        private List<int> copied;

        public void Flatten(TreeNode root)
        {
            if (root is null) return;

            copied = new List<int>();

            PreorderTraversal(root);

            TreeNode prev = root;
            TreeNode cur = root;

            foreach (var elem in copied)
            {
                if (cur is not null)
                {
                    cur.val = elem;
                }
                else
                {
                    cur = new TreeNode(elem);
                    prev.right = cur;
                }

                prev = cur;
                cur.left = null;
                cur = cur.right;
            }
        }

        public void PreorderTraversal(TreeNode cur)
        {
            if (cur is null) return;

            copied.Add(cur.val);
            PreorderTraversal(cur.left);
            PreorderTraversal(cur.right);
        }
    }
}
