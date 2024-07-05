using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _058_LengthOfLastWord_Test
    {
        private readonly _058_LengthOfLastWord _algorithm;

        public _058_LengthOfLastWord_Test()
        {
            _algorithm = new _058_LengthOfLastWord();
        }

        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        public void LengthOfLastWord_InputString_Returns(string s, int expectedResult)
        {
            // Act
            var result = _algorithm.LengthOfLastWord(s);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
