using LeetCode_C_.TopInterview150.BinaryTree;

namespace Tests.TopInterview150.BinaryTree
{
    public class _098_ValidateBinarySearchTree_Test
    {
        private readonly _098_ValidateBinarySearchTree _algorithm;

        public _098_ValidateBinarySearchTree_Test()
        {
            _algorithm = new _098_ValidateBinarySearchTree();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void IsValidBST_Test(TreeNode root, bool expected)
        {
            // Act
            var result = _algorithm.IsValidBST(root);
            
            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { TreeNode.GetTreeNode(new List<int?> { 2, 1, 3 }), true };
            yield return new object[] { TreeNode.GetTreeNode(new List<int?> { 5, 1, 4, null, null, 3, 6 }), false };
        }

    }
}
