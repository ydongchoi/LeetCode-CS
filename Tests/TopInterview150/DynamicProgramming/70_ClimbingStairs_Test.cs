using LeetCode_C_.TopInterview150.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _70_ClimbingStairs_Test
    {
        private readonly _70_ClimbingStairs _algorithm;

        public _70_ClimbingStairs_Test()
        {
            _algorithm = new _70_ClimbingStairs();
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void ClimbStairs_Input_Returns(int n, int expected)
        {
            var result = _algorithm.ClimbStairs(n);
            Assert.Equal(expected, result);
        }
    }
}
