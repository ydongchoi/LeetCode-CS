
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/maximum-average-subarray-i/description/

namespace LeetCode_C_.TopInterview150
{
    public class _643_MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double answer = 0;
            double tmpSum = 0;

            for (int idx = 0; idx < k; ++idx)
            {
                tmpSum += nums[idx];
            }
            answer = tmpSum;

            for (int idx = k; idx < nums.Length; ++idx)
            {
                tmpSum = tmpSum - nums[idx - k];
                tmpSum = tmpSum + nums[idx];

                answer = answer > tmpSum ? answer : tmpSum;
            }

            return answer / k;
        }
    }
}
