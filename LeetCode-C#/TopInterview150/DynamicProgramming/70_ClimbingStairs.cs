
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/climbing-stairs/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _70_ClimbingStairs
    {
        int[] memo;

        public int ClimbStairs(int n)
        {
            memo = new int[50];

            return DynamicProgramming(0, n);
        }

        public int DynamicProgramming(int cur, int n)
        {
            if (cur == n)
            {
                return 1;
            }
            else if (cur > n)
            {
                return 0;
            }

            memo[cur] = memo[cur] != 0 ? memo[cur] : (DynamicProgramming(cur + 1, n) + DynamicProgramming(cur + 2, n));

            return memo[cur];
        }
    }
}
