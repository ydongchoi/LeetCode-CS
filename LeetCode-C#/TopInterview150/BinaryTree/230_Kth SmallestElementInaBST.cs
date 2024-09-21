
// Time Complexity : O(NLogN), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/kth-smallest-element-in-a-bst/

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _230_Kth_SmallestElementInaBST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            List<int> nodes = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode cur = queue.Dequeue();
                nodes.Add(cur.val);

                if (cur.left is not null) queue.Enqueue(cur.left);
                if (cur.right is not null) queue.Enqueue(cur.right);
            }

            nodes.Sort();

            return nodes[k - 1];
        }
    }
}
