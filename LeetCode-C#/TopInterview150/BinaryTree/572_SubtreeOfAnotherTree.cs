using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _572_SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root is null) return false;

            if(root.val == subRoot.val)
            {
                if (IsSameTree(root, subRoot))
                {
                    return true;
                }
            }

            bool left = IsSubtree(root.left, subRoot);
            bool right = IsSubtree(root.right, subRoot);

            return left || right;                 
        }

        public bool IsSameTree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot is null)
            {
                if (root is null) return true;
                else return false;
            }

            if (root.val == subRoot.val)
            {
                bool left = IsSameTree(root.left, subRoot.left);
                bool right = IsSameTree(root.right, subRoot.right);

                return left && right;
            }
            else
            {
                return false;
            }
        }
    }
}
