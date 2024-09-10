using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _3110_ScoreOfAString_Test
    {
        private readonly _3110_ScoreOfAString _algorithm;

        public _3110_ScoreOfAString_Test()
        {
            _algorithm = new _3110_ScoreOfAString();
        }

        [Theory]
        [InlineData("hello", 13)]
        [InlineData("zaz", 50)]
        public void ScoreOfString_Test(string s, int expected)
        {
            // Arrange

            // Act
            var actual = _algorithm.ScoreOfString(s);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
