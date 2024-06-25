// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

namespace LeetCode_C_.TopInterview150.SlidingWindow
{
    public class _121_BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int buy, sell;
            buy = sell = prices[0];
            int profit = 0;

            for (int idx = 0; idx < prices.Length; ++idx)
            {

                if (buy > prices[idx])
                {
                    buy = prices[idx];
                    sell = 0;
                }

                if (sell < prices[idx])
                {
                    sell = prices[idx];
                }

                int tmp = sell - buy;
                profit = profit > tmp ? profit : tmp;
            }

            return profit;
        }
    }
}
