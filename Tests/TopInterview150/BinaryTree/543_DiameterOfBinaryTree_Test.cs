using LeetCode_C_.TopInterview150.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.BinaryTree
{
    public class _543_DiameterOfBinaryTree_Test
    {
        private readonly _543_DiameterOfBinaryTree _algirthm;

        public _543_DiameterOfBinaryTree_Test()
        {
            _algirthm = new _543_DiameterOfBinaryTree();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void DiameterOfBinaryTree_Input_Returns(List<int?> trees, int expectedResult)
        {
            // Assign
            TreeNode root = TreeNode.GetTreeNode(trees);

            // Act
            var result = _algirthm.DiameterOfBinaryTree(root);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new List<int?> { 1, 2, 3, 4, 5 }, 3 };
            yield return new object[] { new List<int?> { 1, 2 }, 1 };
        }
    }
}
