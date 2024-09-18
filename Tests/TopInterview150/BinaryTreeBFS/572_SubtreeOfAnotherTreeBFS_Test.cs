using LeetCode_C_.TopInterview150.BinaryTree;

namespace Tests.TopInterview150.BinaryTreeBFS
{
    public class _572_SubtreeOfAnotherTreeBFS_Test
    {
        private readonly _572_SubtreeOfAnotherTree_BFS _algorithm;

        public _572_SubtreeOfAnotherTreeBFS_Test()
        {
            _algorithm = new _572_SubtreeOfAnotherTree_BFS();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void IsSubtree_Input_Returns(List<int?> trees, List<int?> subTrees, bool expectedResult)
        {
            // Assign
            TreeNode root = TreeNode.GetTreeNode(trees);
            TreeNode subRoot = TreeNode.GetTreeNode(subTrees);

            // Act
            var result = _algorithm.IsSubtree(root, subRoot);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new List<int?> { 3, 4, 5, 1, 2 }, new List<int?> { 4, 1, 2 }, true };
        }
    }
}

