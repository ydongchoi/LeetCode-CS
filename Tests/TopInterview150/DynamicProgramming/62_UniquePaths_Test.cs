using LeetCode_C_.TopInterview150.DynamicProgramming;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _62_UniquePaths_Test
    {
        private readonly _62_UniquePaths _algorithm;

        public _62_UniquePaths_Test()
        {
            _algorithm = new _62_UniquePaths();
        }

        [Theory]
        [InlineData(3, 7, 28)]
        [InlineData(3, 2, 3)]
        [InlineData(7, 3, 28)]
        public void UniquePaths_Input_Returns(int m, int n, int expected)
        {
            // Act
            var result = _algorithm.UniquePaths(m, n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
