using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _1023_CamelcaseMatching_Test
    {
        private readonly _1023_CamelcaseMatching _algorithm;

        public _1023_CamelcaseMatching_Test()
        {
            _algorithm = new _1023_CamelcaseMatching();
        }

        [Theory]
        [InlineData(new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" }, "FB", new bool[] { true, false, true, true, false })]
        [InlineData(new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" }, "FoBa", new bool[] { true, false, true, false, false })]
        [InlineData(new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" }, "FoBaT", new bool[] { false, true, false, false, false })]
        public void CamelMatch_Test(string[] queries, string pattern, bool[] expected)
        {
            // Arrange

            // Act  
            var result = _algorithm.CamelMatch(queries, pattern);
            
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
