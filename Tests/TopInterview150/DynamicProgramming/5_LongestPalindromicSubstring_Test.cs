using LeetCode_C_.TopInterview150.DynamicProgramming;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _5_LongestPalindromicSubstring_Test
    {
        private readonly _5_LongestPalindromicSubstring _algorithm;

        public _5_LongestPalindromicSubstring_Test()
        {
            _algorithm = new _5_LongestPalindromicSubstring();
        }

        [Theory]
        [InlineData("babad", "aba")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        public void LongestPalindrome_Input_Returns(string s, string expected)
        {
            // Act
            var result = _algorithm.LongestPalindrome(s);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
