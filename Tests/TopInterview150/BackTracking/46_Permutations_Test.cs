using LeetCode_C_.TopInterview150.BackTracking;

namespace Tests.TopInterview150.BackTracking
{
    public class _46_Permutations_Test
    {
        private readonly _46_Permutations _algorithm;

        public _46_Permutations_Test()
        {
            _algorithm = new _46_Permutations();
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 3, 2 }, new[] { 2, 1, 3 }, new[] { 2, 3, 1 }, new[] { 3, 1, 2 }, new[] { 3, 2, 1 })]
        [InlineData(new[] { 0, 1 }, new[] { 0, 1 }, new[] { 1, 0 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        public void Permute_Input_Returns(int[] nums, params int[][] expected)
        {
            // Act
            var result = _algorithm.Permute(nums);

            // Assert
            Assert.Equal(expected.Length, result.Count);

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}
