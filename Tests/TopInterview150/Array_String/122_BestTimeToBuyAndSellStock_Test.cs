using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _122_BestTimeToBuyAndSellStock_Test
    {
        private readonly _122_BestTimeToBuyAndSellStock _algorithm;

        public _122_BestTimeToBuyAndSellStock_Test()
        {
            _algorithm = new _122_BestTimeToBuyAndSellStock();
        }

        [Theory]
        [InlineData(new int[] {7,1,5,3,6,4}, 7)]
        [InlineData(new int[] {1,2,3,4,5}, 4)]
        [InlineData(new int[] {7,6,4,3,1}, 0)]
        public void MaxProfit_Input_Returns(int[] prices, int expectedResult)
        {
            // Act
            var result = _algorithm.MaxProfit(prices);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
