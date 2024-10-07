using LeetCode_C_.TopInterview150.DynamicProgramming;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _322_CoinChange_Test
    {
        private readonly _322_CoinChange _algorithm;

        public _322_CoinChange_Test()
        {
            _algorithm = new _322_CoinChange();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 5 }, 11, 3)]
        [InlineData(new int[] { 2 }, 3, -1)]
        [InlineData(new int[] { 1 }, 0, 0)]
        [InlineData(new int[] { 1 }, 1, 1)]
        public void CoinChange_Input_Returns(int[] coins, int amount, int expected)
        {
            // Act
            var result = _algorithm.CoinChange(coins, amount);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}
