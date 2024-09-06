
// Time Complexity : O(N), Spacious Complexity : O(M)
// https://leetcode.com/problems/maximum-sum-of-almost-unique-subarray/description/

namespace LeetCode_C_.TopInterview150.SlidingWindow
{
    public class _2841_MaximumSumOfAlmostUniqueSubarray
    {
        public long MaxSum(IList<int> nums, int m, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            long tmpVal = 0;
            long answer = 0;

            for (int idx = 0; idx < k; ++idx)
            {
                if (dic.TryGetValue(nums[idx], out int val))
                {
                    dic[nums[idx]]++;
                }
                else
                {
                    dic.Add(nums[idx], 1);
                }
                tmpVal += nums[idx];
            }

            if (dic.Count >= m) answer = tmpVal;

            for (int idx = k; idx < nums.Count; ++idx)
            {
                tmpVal = tmpVal - nums[idx - k] + nums[idx];

                if (dic[nums[idx - k]] > 1)
                {
                    dic[nums[idx - k]]--;
                }
                else
                {
                    dic.Remove(nums[idx - k]);
                }

                if (dic.ContainsKey(nums[idx])) dic[nums[idx]]++;
                else dic.Add(nums[idx], 1);

                if (dic.Count >= m) answer = answer > tmpVal ? answer : tmpVal;
            }

            return answer;
        }
    }
}
