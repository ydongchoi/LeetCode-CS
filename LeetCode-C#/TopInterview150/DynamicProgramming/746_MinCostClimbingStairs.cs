
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/min-cost-climbing-stairs/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _746_MinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int top = cost.Length;
            int[] memo = new int[top + 1];

            for (int idx = 2; idx <= cost.Length; ++idx)
            {
                int first = memo[idx - 1] + cost[idx - 1];
                int second = memo[idx - 2] + cost[idx - 2];

                memo[idx] = Math.Min(first, second);
            }

            return memo[top];
        }
    }
}
