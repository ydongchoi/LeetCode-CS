
// Time Complexity : O(NM), Spacious Complexity : O(N + M)
// Link : https://leetcode.com/problems/subtree-of-another-tree/

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _572_SubtreeOfAnotherTree_BFS
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            Queue<TreeNode> rQueue = new Queue<TreeNode>();
            rQueue.Enqueue(root);

            while (rQueue.Count != 0)
            {
                TreeNode rCur = rQueue.Dequeue();

                if (rCur.val == subRoot.val)
                {
                    if (IsSameTree(rCur, subRoot)) return true;
                }

                if (rCur.left is not null) rQueue.Enqueue(rCur.left);
                if (rCur.right is not null) rQueue.Enqueue(rCur.right);
            }

            return false;
        }

        public bool IsSameTree(TreeNode root, TreeNode subRoot)
        {
            Queue<TreeNode> rQueue = new Queue<TreeNode>();
            Queue<TreeNode> sQueue = new Queue<TreeNode>();
            rQueue.Enqueue(root); sQueue.Enqueue(subRoot);

            while (rQueue.Count != 0 && sQueue.Count != 0)
            {
                TreeNode rCur = rQueue.Dequeue(); TreeNode sCur = sQueue.Dequeue();

                if (rCur is not null && sCur is null) return false;
                if (rCur is null && sCur is not null) return false;
                if (rCur is null && sCur is null) continue;
                if (rCur.val != sCur.val) return false;

                rQueue.Enqueue(rCur.left);
                rQueue.Enqueue(rCur.right);

                sQueue.Enqueue(sCur.left);
                sQueue.Enqueue(sCur.right);
            }

            if (rQueue.Count != sQueue.Count) return false;
            else return true;
        }
    }
}
