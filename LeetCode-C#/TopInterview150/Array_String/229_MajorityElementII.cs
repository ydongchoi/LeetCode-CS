
// Time Complexity : O(N), Spacious Complexity : O(N)
// https://leetcode.com/problems/majority-element-ii/description/

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _229_MajorityElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            int appeared = nums.Length / 3;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> answer = new List<int>();

            for (int idx = 0; idx < nums.Length; idx++)
            {
                if (dic.ContainsKey(nums[idx]))
                {
                    dic[nums[idx]]++;
                }
                else
                {
                    dic.Add(nums[idx], 1);
                }
            }

            foreach (var elem in dic)
            {
                if (elem.Value > appeared)
                {
                    answer.Add(elem.Key);
                }
            }

            return answer;
        }
    }
}
