
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/length-of-last-word/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _058_LengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            int len = s.Length - 1;
            int lastWordLen = 0;

            for (int idx = len; idx >= 0; idx--)
            {
                if (s[idx] != ' ')
                {
                    lastWordLen++;
                }
                if (s[idx] == ' ' && lastWordLen != 0) break;
            }

            return lastWordLen;
        }
    }
}
