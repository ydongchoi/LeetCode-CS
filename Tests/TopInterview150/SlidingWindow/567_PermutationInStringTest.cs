using LeetCode_C_.TopInterview150.SlidingWindow;

namespace Tests.TopInterview150.SlidingWindow
{
    public class _567_PermutationInStringTest
    {
        private readonly _567_PermutationInString _algorithm;

        public _567_PermutationInStringTest()
        {
         
            _algorithm = new _567_PermutationInString();
        }

        [Theory]
        [InlineData("ab", "eidbaooo", true)]
        [InlineData("ab", "eidboaoo", false)]
        public void CheckInclusion_Input_Returns(string s1, string s2, bool expected)
        {
            var result = _algorithm.CheckInclusion(s1, s2);
            Assert.Equal(expected, result);
        }
    }
}
