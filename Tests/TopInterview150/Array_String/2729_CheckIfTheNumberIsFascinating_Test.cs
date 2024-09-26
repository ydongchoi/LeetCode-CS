using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _2729_CheckIfTheNumberIsFascinating_Test
    {
        private readonly _2729_CheckIfTheNumberIsFascinating _algorithm;

        public _2729_CheckIfTheNumberIsFascinating_Test()
        {
            _algorithm = new _2729_CheckIfTheNumberIsFascinating();
        }

        [Theory]
        [InlineData(192, true)]
        [InlineData(100, false)]
        public void IsFascinating_Input_Returns(int input, bool expectedResult)
        {
            // Arrange

            // Act
            var result = _algorithm.IsFascinating(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
