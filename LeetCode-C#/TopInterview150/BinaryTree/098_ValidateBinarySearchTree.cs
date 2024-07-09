
// Link : https://leetcode.com/problems/validate-binary-search-tree/description/

namespace LeetCode_C_.TopInterview150.BinaryTree
{
    public class _098_ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            // Make Queue
            List<int> list = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode cur = queue.Dequeue();
                list.Add(cur.val);

                if (cur.left is not null) queue.Enqueue(cur.left);
                if (cur.right is not null) queue.Enqueue(cur.right);
            }

            // Make BST using list
            TreeNode bstTree = new TreeNode(list[0]);
            for (int idx = 1; idx < list.Count; idx++)
            {
                bool isValid = MakeBstTree(root, bstTree, list[idx]);
                if (isValid == false) return false;
            }

            return true;
        }

        public bool MakeBstTree(TreeNode root, TreeNode bstRoot, int value)
        {

            if (value < bstRoot.val)
            {

                if (bstRoot.left is null)
                {
                    Console.WriteLine($"left : {value}");

                    if (root.left is null || root.left.val != value)
                    {
                        return false;
                    }
                    bstRoot.left = new TreeNode(value);

                    return true;
                }

                return MakeBstTree(root.left, bstRoot.left, value);
            }
            else if (bstRoot.val < value)
            {
                Console.WriteLine($"right : {value}");

                if (bstRoot.right is null)
                {
                    if (root.right is null || root.right.val != value) return false;
                    bstRoot.right = new TreeNode(value);
                    return true;
                }

                return MakeBstTree(root.right, bstRoot.right, value);
            }

            return false;
        }
    }
}
