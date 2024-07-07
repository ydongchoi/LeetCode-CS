using LeetCode_C_.TopInterview150.BinaryTree;

namespace Tests.TopInterview150.BinaryTree
{
    public class _104_MaximumDepthOfBinaryTree_Test
    {
        private readonly _104_MaximumDepthOfBinaryTree _algorithm;

        public _104_MaximumDepthOfBinaryTree_Test()
        {
            _algorithm = new _104_MaximumDepthOfBinaryTree();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void MaxDepth_Input_Returns(List<int?> trees, int expectedResult)
        {
            // Assign
            TreeNode root = TreeNode.GetTreeNode(trees);

            // Act
            var result = _algorithm.MaxDepth(root);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new List<int?> { 3, 9, 20, null, null, 15, 7 }, 3 };
            yield return new object[] { new List<int?> { 1, null, 2 }, 2 };        
        }

    }
}
