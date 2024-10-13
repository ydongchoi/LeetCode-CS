using LeetCode_C_.TopInterview150.BinaryTree;

namespace Tests.TopInterview150.BinaryTree
{
    public class _235_LowestCommonAncestorOfABinarySearchTree_Test
    {
        private readonly _235_LowestCommonAncestorOfABinarySearchTree _algorithm;

        public _235_LowestCommonAncestorOfABinarySearchTree_Test()
        {
            _algorithm = new _235_LowestCommonAncestorOfABinarySearchTree();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void LowestCommonAncestor_Input_Returns(List<int?> trees, int p, int q, int expected)
        {
            // Arrange
            TreeNode root = TreeNode.GetTreeNode(trees);

            // Act
            var result = _algorithm.LowestCommonAncestor(root, new TreeNode(p), new TreeNode(q));

            // Assert
            Assert.Equal(expected, result.val);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new List<int?> { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }, 2, 8, 6 };
            yield return new object[] { new List<int?> { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }, 2, 4, 2 };
        }
    }
}
