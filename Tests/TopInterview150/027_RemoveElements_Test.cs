using LeetCode_C_.TopInterview150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150
{
    public class _027_RemoveElements_Test
    {
        private readonly _027_RemoveElement _algorithm;

        public _027_RemoveElements_Test()
        {
            _algorithm = new _027_RemoveElement();
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void RemoveElement_Input_Return(int[] nums, int val, int expectedResult)
        {
            // Act
            var result = _algorithm.RemoveElement(nums, val);

            // Assert
            Assert.Equal(expectedResult, result);
        }

    }
}
