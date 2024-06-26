using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _055_JumpGame_Test
    {
        private readonly _055_JumpGame _algorithm;

        public _055_JumpGame_Test()
        {
            _algorithm = new _055_JumpGame();
        }

        [Theory]
        [InlineData(new int[] {2,3,1,1,4}, true)]
        [InlineData(new int[] {3,2,1,0,4}, false)]
        public void CanJump_Input_Returns(int[] nums, bool expectedResult)
        {
            // Act
            var result = _algorithm.CanJump(nums);

            // Assert
            Assert.Equal(expectedResult, result);
        }

    }
}
