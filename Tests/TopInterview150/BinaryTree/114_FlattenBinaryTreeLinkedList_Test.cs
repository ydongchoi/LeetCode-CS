using LeetCode_C_.TopInterview150.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.BinaryTree
{
    public class _114_FlattenBinaryTreeLinkedList_Test
    {
        private readonly _114_FlattenBinaryTreeLinkedList _algorithm;

        public _114_FlattenBinaryTreeLinkedList_Test()
        {
            _algorithm = new _114_FlattenBinaryTreeLinkedList();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Flatten_Input_Returns(List<int?> trees, List<int?> expectedResult)
        {
            // Arrange
            TreeNode root = TreeNode.GetTreeNode(trees);

            // Act
            _algorithm.Flatten(root);

            // Assert
            TreeNode cur = root;
            for(int idx  = 0; idx < expectedResult.Count; idx++)
            {
                Assert.Equal(cur.val, expectedResult[idx++]);
                Assert.Equal(cur.left, null);

                cur = cur.right;
            }
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new List<int?> { 1, 2, 5, 3, 4, null, 6 }, new List<int?> {1, null, 2, null, 3, null, 4, null, 5, null, 6} };
        }
    }
}
