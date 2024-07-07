
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/maximum-depth-of-binary-tree/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.BinaryTree
{
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

        public static TreeNode GetTreeNode(List<int?> trees)
        {
            int idx = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = new TreeNode(trees[idx].Value);
            queue.Enqueue(root);

            while (queue.Count > 0 && idx < trees.Count - 1)
            {
                TreeNode node = queue.Dequeue();
                if(node is null) continue;

                node.left = trees[idx + 1] != null ? new TreeNode(trees[idx + 1].Value) : null;
                queue.Enqueue(node.left);
                node.right = trees[idx + 2] != null ? new TreeNode(trees[idx + 2].Value) : null;
                queue.Enqueue(node.right);
                idx++; idx++;
            }

            return root;
        }
    }

    public class _104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            return PreOrder(root, 0);
        }

        public int PreOrder(TreeNode cur, int depth)
        {
            if (cur is null) return depth;

            int left = PreOrder(cur.left, depth + 1);
            int right = PreOrder(cur.right, depth + 1);

            return left > right ? left : right;
        }
    }
}
