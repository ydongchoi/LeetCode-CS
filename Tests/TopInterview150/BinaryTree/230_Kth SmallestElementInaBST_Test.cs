
using LeetCode_C_.TopInterview150.BinaryTree;

namespace Tests.TopInterview150.BinaryTree
{
    public class _230_Kth_SmallestElementInaBST_Test
    {
        private readonly _230_Kth_SmallestElementInaBST _algorithm;

        public _230_Kth_SmallestElementInaBST_Test()
        {
            _algorithm = new _230_Kth_SmallestElementInaBST();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void KthSmallest_Input_Returns(List<int?> trees, int k, int expectedResult)
        {
            // Arrange
            TreeNode root = TreeNode.GetTreeNode(trees);

            // Act
            var result = _algorithm.KthSmallest(root, k);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new List<int?> { 3, 1, 4, null, 2 }, 1, 1 };
            yield return new object[] { new List<int?> { 5, 3, 6, 2, 4, null, null, 1 }, 3, 3 };
        }

    }
}
