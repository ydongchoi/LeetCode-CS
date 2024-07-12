using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _151_ReverseWordsInAString_Test
    {
        private readonly _151_ReverseWordsInAString _algorithm;

        public _151_ReverseWordsInAString_Test()
        {
            _algorithm = new _151_ReverseWordsInAString();
        }

        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world  ", "world hello")]
        [InlineData("a good   example", "example good a")]
        public void ReverseWords_Input_Returns(string s, string expected)
        {
            // Act
            var result = _algorithm.ReverseWords(s);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
