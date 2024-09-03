using LeetCode_C_.TopInterview150.SlidingWindow;

namespace Tests.TopInterview150.SlidingWindow
{
    public class _3_Longest_Substring_Without_Repeating_CharactersTest
    {
        private readonly _3_Longest_Substring_Without_Repeating_Characters _algorithm;

        public _3_Longest_Substring_Without_Repeating_CharactersTest()
        {
            _algorithm = new _3_Longest_Substring_Without_Repeating_Characters();
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LengthOfLongestSubstring_Input_Returns(string s, int expected)
        {
            var result = _algorithm.LengthOfLongestSubstring(s);
            Assert.Equal(expected, result);
        }
    }
}
