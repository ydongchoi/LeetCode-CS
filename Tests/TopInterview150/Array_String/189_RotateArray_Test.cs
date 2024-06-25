using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _189_RotateArray_Test
    {
        private readonly _189_RotateArray _algorithm;

        public _189_RotateArray_Test()
        {
            _algorithm = new _189_RotateArray();
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4,5,6,7}, 3, new int[] {5,6,7,1,2,3,4})]
        [InlineData(new int[] {-1,-100,3,99}, 2, new int[] {3,99,-1,-100})]
        public void Rotate_Input_Returns(int[] nums, int k, int[] expectedResult)
        {
            // Act
            _algorithm.Rotate(nums, k);

            // Assert
            Assert.Equal(expectedResult, nums);
        }
    }
}
