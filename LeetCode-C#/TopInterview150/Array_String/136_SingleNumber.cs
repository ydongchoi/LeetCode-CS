
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/single-number/

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _136_SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var answer = 0;

            for (int idx = 0; idx < nums.Length; ++idx)
            {
                answer ^= nums[idx];
            }

            return answer;
        }
    }
}
