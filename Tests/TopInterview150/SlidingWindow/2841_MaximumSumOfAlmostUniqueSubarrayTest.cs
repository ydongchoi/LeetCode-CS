using LeetCode_C_.TopInterview150.SlidingWindow;

namespace Tests.TopInterview150.SlidingWindow
{
    public class _2841_MaximumSumOfAlmostUniqueSubarrayTest
    {
        private readonly _2841_MaximumSumOfAlmostUniqueSubarray _algortihm;

        public _2841_MaximumSumOfAlmostUniqueSubarrayTest()
        {
            _algortihm = new _2841_MaximumSumOfAlmostUniqueSubarray();
        }

        [Theory]
        [InlineData(new[] { 2, 6, 7, 3, 1, 7 }, 3, 4, 18)]
        [InlineData(new[] { 5, 9, 9, 2, 4, 5, 4 }, 1, 3, 23)]
        public void MaxSumTest_Input_Returns(int[] nums, int m, int k, long expected)
        {
            var result = _algortihm.MaxSum(nums, m, k);
            Assert.Equal(expected, result);
        }
    }
}
