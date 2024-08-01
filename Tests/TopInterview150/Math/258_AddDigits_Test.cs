using LeetCode_C_.TopInterview150.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Math
{
    public class _258_AddDigits_Test
    {
        private readonly _258_AddDigits _algorithm;

        public _258_AddDigits_Test()
        {
            _algorithm = new _258_AddDigits();
        }

        [Theory]
        [InlineData(38, 2)]
        [InlineData(0, 0)]
        public void AddDigits_Input_Returns(int num, int expected)
        {
            // Act
            var actual = _algorithm.AddDigits(num);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
