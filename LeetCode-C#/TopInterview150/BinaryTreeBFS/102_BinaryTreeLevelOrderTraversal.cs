using LeetCode_C_.TopInterview150.BinaryTree;

// Time Complexity : O(NM), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/binary-tree-level-order-traversal/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.BinaryTreeBFS
{
    public class _102_BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> answer = new List<IList<int>>();
            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 1));

            while (queue.Count > 0)
            {
                var curData = queue.Dequeue();
                TreeNode cur = curData.Item1; int depth = curData.Item2;
                if (cur is null) continue;

                if (answer.Count < depth)
                {
                    answer.Add(new List<int>());
                    answer[depth - 1].Add(cur.val);
                }
                else answer[depth - 1].Add(cur.val);

                if (cur.left is not null) queue.Enqueue((cur.left, depth + 1));
                if (cur.right is not null) queue.Enqueue((cur.right, depth + 1));
            }

            return answer;
        }
    }
}
