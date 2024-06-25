using LeetCode_C_.TopInterview150.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.SlidingWindow
{
    public class _643_MaximumAverageSubarrayI_Test
    {
        private readonly _643_MaximumAverageSubarrayI _algorithm;

        public _643_MaximumAverageSubarrayI_Test()
        {
            _algorithm = new _643_MaximumAverageSubarrayI();
        }

        [Theory]
        [InlineData(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000)]
        [InlineData(new int[] { 5 }, 1, 5.00000)]
        public void FindMaxAverage(int[] nums, int k, double expectedResult)
        {
            // Act
            var result = _algorithm.FindMaxAverage(nums, k);

            // Assert
            Assert.Equal(expectedResult, result);

        }
    }
}
