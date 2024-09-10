
// Time Complexity : O(N), Spacious Complexity : O(1)
// https://leetcode.com/problems/score-of-a-string/

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _3110_ScoreOfAString
    {
        public int ScoreOfString(string s)
        {
            int answer = 0;

            for (int idx = 0; idx < s.Length - 1; ++idx)
            {
                answer += System.Math.Abs(s[idx] - s[idx + 1]);
            }

            return answer;
        }
    }
}
