
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/longest-substring-without-repeating-characters/

namespace LeetCode_C_.TopInterview150.SlidingWindow
{
    public class _3_Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int answer = 0;
            int tmpSubString = 0; int start = 0;

            for (int idx = 0; idx < s.Length; ++idx)
            {
                char elem = s[idx];

                if (dic.TryGetValue(elem, out int val))
                {
                    answer = answer > tmpSubString ? answer : tmpSubString;
                    dic.Clear();

                    tmpSubString = 0;
                    for (int i = val + 1; i <= idx; ++i)
                    {
                        if (!dic.ContainsKey(s[i]))
                        {
                            dic.Add(s[i], i); tmpSubString++;
                        }
                    }

                    start = val + 1;

                    continue;
                }

                dic.Add(elem, idx);
                tmpSubString++;
            }

            answer = answer > tmpSubString ? answer : tmpSubString;

            return answer;
        }
    }
}
