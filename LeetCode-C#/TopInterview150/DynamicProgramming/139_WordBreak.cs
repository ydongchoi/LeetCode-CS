
// Time Complexity : O(2^N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/word-break/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _139_WordBreak
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            Dictionary<string, bool> memo = new Dictionary<string, bool>();
            HashSet<string> wordSet = new HashSet<string>(wordDict);

            return Dfs(s, wordSet, memo);
        }

        private bool Dfs(string s, HashSet<string> wordSet, Dictionary<string, bool> memo)
        {
            if (memo.ContainsKey(s)) return memo[s];
            if (wordSet.Contains(s)) return true;
            for (int i = 1; i < s.Length; i++)
            {
                string prefix = s.Substring(0, i);
                if (wordSet.Contains(prefix) && Dfs(s.Substring(i), wordSet, memo))
                {
                    memo[s] = true;
                    return true;
                }
            }
            memo[s] = false;
            return false;
        }
    }
}
