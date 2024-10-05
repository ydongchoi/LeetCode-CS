using System.Text;

// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/longest-common-prefix/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _917_ReverseOnlyLetters
    {
        public string ReverseOnlyLetters(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            List<char> memo = new List<char>();

            for (int idx = s.Length - 1; idx >= 0; idx--)
            {
                if (isAlphabet(s[idx]))
                {
                    memo.Add(s[idx]);
                }
            }

            int start = 0;
            for (int idx = 0; idx < s.Length; ++idx)
            {
                if (isAlphabet(s[idx]))
                {
                    sb[idx] = memo[start++];
                }
            }

            return sb.ToString();
        }

        private bool isAlphabet(char elem)
        {
            return 'a' <= elem && elem <= 'z' || 'A' <= elem && elem <= 'Z';
        }
    }
}
