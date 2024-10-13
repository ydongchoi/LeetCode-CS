
// Time Complexity : O(N), Space Complexity : O(N)
// Link : https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _235_LowestCommonAncestorOfABinarySearchTree
    {
        private List<TreeNode> _pList;
        private List<TreeNode> _qList;

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            int pVal = p.val; int qVal = q.val;
            TreeNode answer = null;

            _pList = Preorder(root, pVal, new List<TreeNode>());
            _qList = Preorder(root, qVal, new List<TreeNode>());

            int pCount = _pList.Count(); int qCount = _qList.Count();
            int cnt = pCount > qCount ? qCount : pCount;

            for (int idx = 0; idx < cnt; ++idx)
            {
                if (_pList[idx].val == _qList[idx].val)
                {
                    answer = _pList[idx];
                }
            }

            return answer;
        }

        private List<TreeNode> Preorder(TreeNode root, int val, List<TreeNode> path)
        {
            path.Add(root);

            if (val == root.val)
            {
                return path;
            }

            if (val < root.val) return Preorder(root.left, val, path);
            else return Preorder(root.right, val, path);
        }
    }
}
