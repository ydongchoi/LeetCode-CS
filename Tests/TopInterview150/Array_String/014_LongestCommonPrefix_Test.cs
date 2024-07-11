using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _014_LongestCommonPrefix_Test
    {
        private readonly _014_LongestCommonPrefix _algorithm;

        public _014_LongestCommonPrefix_Test()
        {
            _algorithm = new _014_LongestCommonPrefix();
        }

        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "ab", "a" }, "a")]
        public void LongestCommonPrefix_InputStringArray_Returns(string[] strs, string expectedResult)
        {
            // Act
            var result = _algorithm.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
