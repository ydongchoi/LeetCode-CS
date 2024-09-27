
using LeetCode_C_.TopInterview150.DynamicProgramming;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _139_WordBreak_Test
    {
        private readonly _139_WordBreak _algorithm;

        public _139_WordBreak_Test()
        {
            _algorithm = new _139_WordBreak();
        }

        [Theory]
        [InlineData("leetcode", new string[] {"leet", "code"}, true)]
        [InlineData("applepenapple", new string[] {"apple", "pen"}, true)]
        [InlineData("catsandog", new string[] {"cats", "dog", "sand", "and", "cat"}, false)]
        public void WordBreak_Input_Returns(string input1, string[] input2, bool expectedResult)
        {
            // Arrange

            // Act
            var result = _algorithm.WordBreak(input1, input2);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
