using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _080_RemoveDuplicatesFromSortedArrayII_Test
    {
        private readonly _080_RemoveDuplicatesFromSortedArrayII _algorithm;

        public _080_RemoveDuplicatesFromSortedArrayII_Test()
        {
            _algorithm = new _080_RemoveDuplicatesFromSortedArrayII();
        }

        [Theory]
        [InlineData(new int[] {1,1,1,2,2,3}, 5, new int[]{1,1,2,2,3})]
        [InlineData(new int[] {0,0,1,1,1,1,2,3,3,}, 7, new int[]{0,0,1,1,2,3,3})]
        public void RemoveDuplicates_Input_Returns(int[] nums, int k, int[] expectedNums)
        {
            // Act
            var result = _algorithm.RemoveDuplicates(nums);

            // Assert
            Assert.Equal(k, result);
            Assert.Equal(expectedNums[0..k], nums[0..k]);
        }
    }
}
