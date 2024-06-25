using LeetCode_C_.TopInterview150.SlidingWindow;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.SlidingWindow
{
    public class _209_MinimumSizeSubarraySum_Test
    {
        private readonly _209_MinimumSizeSubarraySum _algorithm;

        public _209_MinimumSizeSubarraySum_Test()
        {
            _algorithm = new _209_MinimumSizeSubarraySum();
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3, 1, 2, 4, 3 }, 2)]
        [InlineData(4, new int[] { 1, 4, 4 }, 1)]
        [InlineData(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
        public void MinSubArrayLen_Input_Returns(int target, int[] nums, int expectedResult)
        {
            // Act
            var result = _algorithm.MinSubArrayLen(target, nums);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
