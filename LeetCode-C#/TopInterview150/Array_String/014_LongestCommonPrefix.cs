
// Time Complexity : O(NM), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/longest-common-prefix/?envType=study-plan-v2&envId=top-interview-150

using System.Text;

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder commonPrefix = new StringBuilder();
            int idx = 0;

            while (true)
            {
                foreach(var str in strs)
                {
                    if (idx >= str.Length || str[idx] != strs[0][idx])
                    {
                        return commonPrefix.ToString();
                    }
                }

                commonPrefix.Append(strs[0][idx++]);
            }
        }
    }
}
