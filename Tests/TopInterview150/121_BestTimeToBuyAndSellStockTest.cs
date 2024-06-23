using LeetCode_C_.TopInterview150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150
{
    public class _121_BestTimeToBuyAndSellStockTest
    {
        private readonly _121_BestTimeToBuyAndSellStock _algorithm;

        public _121_BestTimeToBuyAndSellStockTest()
        {
            _algorithm = new _121_BestTimeToBuyAndSellStock();
        }

        [Theory]
        [InlineData(new int[] {7,1,5,3,6,4}, 5)]
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
