using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _238_ProductOfArrayExceptSelf_Test
    {
        private readonly _238_ProductOfArrayExceptSelf _algorithm;

        public _238_ProductOfArrayExceptSelf_Test()
        {
            _algorithm = new _238_ProductOfArrayExceptSelf();
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4}, new int[] {24,12,8,6})]
        [InlineData(new int[] {-1,1,0,-3,3}, new int[] {0,0,9,0,0})]
        public void ProductExceptSelf_Input_Returns(int[] nums, int[] expectedResult)
        {
            // Act
            var result = _algorithm.ProductExceptSelf(nums);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
