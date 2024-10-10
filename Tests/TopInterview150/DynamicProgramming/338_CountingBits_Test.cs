using LeetCode_C_.TopInterview150.DynamicProgramming;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _338_CountingBits_Test
    {
        private readonly _338_CountingBits _algorithm;

        public _338_CountingBits_Test()
        {
            _algorithm = new _338_CountingBits();
        }

        [Theory]
        [InlineData(2, new int[] {0,1,1})]
        [InlineData(5, new int[] {0,1,1,2,1,2 })]
        public void CountBits_Input_Returns(int n, int[] expected)
        {
            // Act
            var result = _algorithm.CountBits(n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
