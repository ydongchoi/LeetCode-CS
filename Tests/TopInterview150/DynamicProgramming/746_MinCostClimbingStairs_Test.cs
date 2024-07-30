using LeetCode_C_.TopInterview150.DynamicProgramming;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _746_MinCostClimbingStairs_Test
    {
        private readonly _746_MinCostClimbingStairs _algorithm;

        public _746_MinCostClimbingStairs_Test()
        {
            _algorithm = new _746_MinCostClimbingStairs();
        }

        [Theory]
        [InlineData(new int[] { 10, 15, 20 }, 15)]
        [InlineData(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
        public void MinCostClimbingStairs_Input_Returns(int[] cost, int expected)
        {
            var result = _algorithm.MinCostClimbingStairs(cost);
            Assert.Equal(expected, result);
        }
    }
}
