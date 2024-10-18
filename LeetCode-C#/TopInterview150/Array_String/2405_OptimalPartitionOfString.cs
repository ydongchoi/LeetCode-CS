
// Time Complexity: O(n), Space Complexity: O(N)
// Link : https://leetcode.com/problems/optimal-partition-of-string/description/?envType=study-plan-v2&envId=amazon-spring-23-high-frequency

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _2405_OptimalPartitionOfString
    {
        public int PartitionString(string s)
        {
            int answer = 1;
            HashSet<char> set = new HashSet<char>();

            for (int idx = 0; idx < s.Length; ++idx)
            {
                if (!set.Contains(s[idx]))
                {
                    set.Add(s[idx]);
                }
                else
                {
                    set.Clear(); set.Add(s[idx]);
                    answer = answer + 1;
                }
            }

            return answer;
        }
    }
}
