
// Time complexity: O(n), Space complexity: O(1)
// Link: https://leetcode.com/problems/the-kth-factor-of-n/?envType=study-plan-v2&envId=amazon-spring-23-high-frequency

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _1492_TheKthFactorOfN
    {
        public int KthFactor(int n, int k)
        {
            int cnt = 0;

            for (int idx = 1; idx <= n / 2; ++idx)
            {
                if (n % idx == 0)
                {
                    cnt++;
                    if (cnt == k) return idx;
                }
            }
            cnt++;

            if (cnt == k) return n;
            return -1;
        }
    }
}
