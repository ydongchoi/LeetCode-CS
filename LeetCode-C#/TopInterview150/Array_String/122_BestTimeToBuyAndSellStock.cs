
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _122_BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;

            for(int idx = 1; idx < prices.Length; ++idx)
            {
                if (prices[idx - 1] < prices[idx])
                {
                    int priceGap = prices[idx] - prices[idx - 1];
                    profit += priceGap;
                }
            }

            return profit;
        }
    }
}
