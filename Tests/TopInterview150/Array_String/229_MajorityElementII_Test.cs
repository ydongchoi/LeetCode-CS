using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _229_MajorityElementII_Test
    {
        private readonly _229_MajorityElementII _algorithm;

        public _229_MajorityElementII_Test()
        {
            _algorithm = new _229_MajorityElementII();
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 3 }, new int[] { 3 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void MajorityElement_Test(int[] nums, int[] expected)
        {
            // Arrange

            // Act
            var actual = _algorithm.MajorityElement(nums);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
