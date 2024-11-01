using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _283_MoveZeroes_Test
    {
        private readonly _283_MoveZeroes _algorithm;

        public _283_MoveZeroes_Test()
        {
            _algorithm = new _283_MoveZeroes();
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
        [InlineData(new[] { 0 }, new[] { 0 })]
        public void MoveZeroes_Test(int[] nums, int[] expected)
        {
            // Act
            _algorithm.MoveZeroes(nums);
            
            // Assert
            Assert.Equal(expected, nums);
        }
    }
}
