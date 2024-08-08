using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _3033_ModifyTheMatrix_Test
    {
        private readonly _3033_ModifyTheMatrix _algorithm;

        public _3033_ModifyTheMatrix_Test()
        {
            _algorithm = new _3033_ModifyTheMatrix();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ModifiedMatrix_Input_Returns(int[][] matrix, int[][] expected)
        {
            // Arrange

            // Act
            var actual = _algorithm.ModifiedMatrix(matrix);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                    new int[][] { new int[] { 1, 2, -1 }, new int[] { 4, -1, 6 }, new int[] { 7, 8, 9 } },
                    new int[][] { new int[] { 1, 2, 9 }, new int[] { 4, 8, 6 }, new int[] { 7, 8, 9 } }
            };
            yield return new object[]
            {
                    new int[][] { new int[] { 3, -1 }, new int[] { 5, 2 } },
                    new int[][] { new int[] { 3, 2 }, new int[] { 5, 2 } }
            };
        }

    }
}
