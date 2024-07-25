using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _2391_MinimumAmoutOfTimeToCollectGarbage_Test
    {
        private readonly _2391_MinimumAmoutOfTimeToCollectGarbage _algorithm;

        public _2391_MinimumAmoutOfTimeToCollectGarbage_Test()
        {
            _algorithm = new _2391_MinimumAmoutOfTimeToCollectGarbage();
        }

        [Theory]
        [InlineData(new string[] { "G", "P", "GP", "GG" }, new int[] { 2, 4, 3 }, 21)]
        [InlineData(new string[] { "MMM", "PGM", "GP" }, new int[] { 3, 10 }, 37)]
        public void GarbageCollection_Input_Returns(string[] garbage, int[] travel, int expected)
        {
            // Act
            var actual = _algorithm.GarbageCollection(garbage, travel);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
