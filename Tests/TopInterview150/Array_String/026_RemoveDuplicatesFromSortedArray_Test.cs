using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _026_RemoveDuplicatesFromSortedArray_Test
    {
        private readonly _026_RemoveDuplicatesFromSortedArray _algorithm;

        public _026_RemoveDuplicatesFromSortedArray_Test()
        {
            _algorithm = new _026_RemoveDuplicatesFromSortedArray();
        }

        [Theory]
        [InlineData(new int[] {1,1,2}, 2, new int[] {1,2})]
        [InlineData(new int[] {0,0,1,1,1,2,2,3,3,4}, 5, new int[] {0,1,2,3,4})]
        public void RemoveDuplicatesFromSortedArray_Input_Returns(int[] nums, int expectedResult1, int[] expectedResult2)
        {
            // Act
            var result = _algorithm.RemoveDuplicates(nums);

            // Assert
            Assert.Equal(expectedResult1, result);
            Assert.Equal(nums[0..result], expectedResult2);
        }
    }
}
