using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _169_MajorityElement_Test
    {
        private readonly _169_MajorityElement _algorithm;

        public _169_MajorityElement_Test()
        {
            _algorithm = new _169_MajorityElement();
        }

        [Theory]
        [InlineData(new int[] {3,2,3}, 3)]
        [InlineData(new int[] {2,2,1,1,1,2,2}, 2)]
        public void MajorityElement_Input_Returns(int[] nums, int expectedResult)
        {
            // Act
            var result = _algorithm.MajorityElement(nums);

            // Assert
            Assert.Equal(expectedResult, result);
        }

    }
}
