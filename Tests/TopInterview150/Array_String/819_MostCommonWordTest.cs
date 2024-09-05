using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _819_MostCommonWordTest
    {
        private readonly _819_MostCommonWord _algorithm;

        public _819_MostCommonWordTest()
        {
            _algorithm = new _819_MostCommonWord();
        }

        [Theory]
        [InlineData("Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" }, "ball")]
        [InlineData("a, a, a, a, b,b,b,c, c", new[] { "a" }, "b")]
        public void MostCommonWordTest(string paragraph, string[] banned, string expected)
        {
            var result = _algorithm.MostCommonWord(paragraph, banned);
            Assert.Equal(expected, result);
        }
    }
}
