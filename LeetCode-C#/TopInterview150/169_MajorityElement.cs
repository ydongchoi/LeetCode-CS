
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/majority-element/description/?envType=study-plan-v2&envId=top-interview-150

using System.Security.Cryptography;

namespace LeetCode_C_.TopInterview150
{
    public class _169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int answer = 0; int maxCnt = 0;

            for(int idx = 0; idx < nums.Length; idx++)
            {
                if (!dic.ContainsKey(nums[idx]))
                {
                    dic.Add(nums[idx], 1);
                    maxCnt = maxCnt > 1 ? maxCnt : 1;
                    answer = maxCnt > 1 ? answer : nums[idx];
                }
                else
                {
                    dic[nums[idx]]++;
                    maxCnt = maxCnt > dic[nums[idx]] ? maxCnt : dic[nums[idx]];
                    answer = maxCnt > dic[nums[idx]] ? answer : nums[idx];
                }
            }

            return answer;
        }
    }
}
