
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/minimum-size-subarray-sum/description/https://leetcode.com/problems/minimum-size-subarray-sum/description/

namespace LeetCode_C_.TopInterview150
{
    public class _209_MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int l = 0;
            int answer = int.MaxValue;
            int sum = 0;

            for (int idx = 0; idx < nums.Length; idx++)
            {
                sum += nums[idx];

                while (sum >= target)
                {
                    answer = Math.Min(answer, idx - l + 1);
                    sum -= nums[l];
                    l++;
                }
            }

            return answer != int.MaxValue ? answer : 0;
        }
    }
}
