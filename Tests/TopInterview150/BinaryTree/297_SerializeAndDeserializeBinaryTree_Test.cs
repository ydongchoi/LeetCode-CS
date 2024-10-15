using LeetCode_C_.TopInterview150.BinaryTree;

namespace Tests.TopInterview150.BinaryTree
{
    public class _297_SerializeAndDeserializeBinaryTree_Test
    {
        private readonly _297_SerializeAndDeserializeBinaryTree _algorithm;

        public _297_SerializeAndDeserializeBinaryTree_Test()
        {
            _algorithm = new _297_SerializeAndDeserializeBinaryTree();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test1(List<int?> trees, List<int?> expected)
        {
            // Assign
            TreeNode root = TreeNode.GetTreeNode(trees);

            // Act
            string serialized = _algorithm.serialize(root);
            TreeNode deserialized = _algorithm.deserialize(serialized);

            // Assert
            Assert.Equal(expected, TreeNode.GetValues(deserialized));
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new List<int?> { 1, 2, 3, null, null, 4, 5 }, new List<int?> { 1, 2, 3, null, null, 4, 5 } };
        }

    }
}
