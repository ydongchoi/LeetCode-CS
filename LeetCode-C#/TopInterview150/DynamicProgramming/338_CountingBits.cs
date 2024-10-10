
// Time: O(n), Space: O(n)
// Link: https://leetcode.com/problems/counting-bits/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _338_CountingBits
    {
        public int[] CountBits(int n)
        {
            if (n == 0) return new int[] { 0 };

            int[] memo = new int[n + 1];
            memo[0] = 0; memo[1] = 1;

            for (int num = 2; num <= n; ++num)
            {
                int division = num / 2;
                int remain = num % 2;

                memo[num] = memo[division] + memo[remain];
            }

            return memo;
        }
    }
}
