using LeetCode_C_.TopInterview150.BinaryTree;
using LeetCode_C_.TopInterview150.BinaryTreeBFS;


namespace Tests.TopInterview150.BinaryTreeBFS
{
    public class _102_BinaryTreeLevelOrderTraversal_Test
    {
        private readonly _102_BinaryTreeLevelOrderTraversal _algorithm;

        public _102_BinaryTreeLevelOrderTraversal_Test()
        {
            _algorithm = new _102_BinaryTreeLevelOrderTraversal();
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void LevelOrder_Test(TreeNode root, IList<IList<int>> expected)
        {
            var result = _algorithm.LevelOrder(root);

            Assert.Equal(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { TreeNode.GetTreeNode(new List<int?> { 3, 9, 20, null, null, 15, 7 }), new List<IList<int>> { new List<int> { 3 }, new List<int> { 9, 20 }, new List<int> { 15, 7 } } };
            yield return new object[] { TreeNode.GetTreeNode(new List<int?> { 1 }), new List<IList<int>> { new List<int> { 1 } } };
            yield return new object[] { TreeNode.GetTreeNode(new List<int?> { 1, 2, 3, 4, 5, 6, 7 }), new List<IList<int>> { new List<int> { 1 }, new List<int> { 2, 3 }, new List<int> { 4, 5, 6, 7 } } };
        }
    }
}
