using LeetCode_C_.TopInterview150.BackTracking;
using System.Collections.Immutable;

namespace Tests.TopInterview150.BackTracking
{
    public class _140_WordBreakII_Test
    {
        private readonly _140_WordBreakII _algorithm;

        public _140_WordBreakII_Test()
        {
            _algorithm = new _140_WordBreakII();
        }

        [Theory]
        [InlineData("catsanddog", new string[] { "cat", "cats", "and", "sand", "dog" }, new string[] { "cats and dog", "cat sand dog" })]
        [InlineData("pineapplepenapple", new string[] { "apple", "pen", "applepen", "pine", "pineapple" }, new string[] { "pine apple pen apple", "pineapple pen apple", "pine applepen apple" })]
        [InlineData("catsandog", new string[] { "cats", "dog", "sand", "and", "cat" }, new string[] { })]
        public void WordBreakII_Test(string s, string[] wordDict, string[] expected)
        {
            // Act
            var result = _algorithm.WordBreak(s, wordDict);

            // Assert
            Assert.Equal(expected.Length, result.Count);
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.Contains(expected[i], result);
            }
        }
    }
}
