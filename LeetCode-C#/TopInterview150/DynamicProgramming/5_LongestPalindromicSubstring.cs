
// Time Complexity: O(n^2), Space Complexity: O(n^2)
// Link: https://leetcode.com/problems/longest-palindromic-substring/description/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _5_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            // 2D - DP
            int sLen = s.Length;
            bool[,] memo = new bool[sLen, sLen];
            int allStart = 0; int maxLen = 1;

            // Initialization when Length is 1 or 2
            for (int idx = 0; idx < sLen; ++idx)
            {
                memo[idx, idx] = true;

                if (idx != sLen - 1 && s[idx] == s[idx + 1])
                {
                    memo[idx, idx + 1] = true;
                    allStart = idx; maxLen = 2;
                }
            }

            // Another Palindrome
            for (int len = 2; len < sLen; ++len)
            {
                for (int start = 0; start < sLen - len; ++start)
                {
                    int end = start + len;

                    if (s[start] == s[end] && memo[start + 1, end - 1])
                    {
                        memo[start, end] = true;
                        allStart = start;
                        maxLen = end - start + 1;
                    }
                }
            }

            return s.Substring(allStart, maxLen);
        }
    }
}
