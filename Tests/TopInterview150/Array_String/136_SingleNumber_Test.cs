using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _136_SingleNumber_Test
    {
        private readonly _136_SingleNumber _algorithm;

        public _136_SingleNumber_Test()
        {
            _algorithm = new _136_SingleNumber();
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 1 }, 1)]
        public void SingleNumber_Test(int[] nums, int expected)
        {
            var result = _algorithm.SingleNumber(nums);
            Assert.Equal(expected, result);
        }
    }
}
