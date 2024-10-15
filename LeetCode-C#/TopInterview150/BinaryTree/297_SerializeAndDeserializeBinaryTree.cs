
// Time Complexity: O(n), Spacing Complexity: O(n)
// Link : https://leetcode.com/problems/serialize-and-deserialize-binary-tree/

using System.Text;

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _297_SerializeAndDeserializeBinaryTree
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root is null) return "";

            StringBuilder sb = new StringBuilder();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode cur = queue.Dequeue();

                if (cur is null)
                {
                    sb.Append(" _");
                    continue;
                }
                sb.Append(cur.val.ToString() + "_");

                queue.Enqueue(cur.left);
                queue.Enqueue(cur.right);
            }

            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (data.Length == 0) return null;

            string[] numbers = data.Split("_");
            int idx = 0;

            TreeNode root = new TreeNode(Int32.Parse(numbers[idx++]));
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode cur = queue.Dequeue();

                if (cur is null) continue;

                string left = numbers[idx++];
                if (left.Equals(" "))
                {
                    cur.left = null;
                }
                else
                {
                    cur.left = new TreeNode(Int32.Parse(left));
                }
                queue.Enqueue(cur.left);

                string right = numbers[idx++];
                if (right.Equals(" "))
                {
                    cur.right = null;
                }
                else
                {
                    cur.right = new TreeNode(Int32.Parse(right));
                }
                queue.Enqueue(cur.right);
            }

            return root;
        }

    }
}
