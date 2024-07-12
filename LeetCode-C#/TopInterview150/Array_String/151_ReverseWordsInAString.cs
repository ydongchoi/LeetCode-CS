using System.Text;


// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/reverse-words-in-a-string/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _151_ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            StringBuilder answer = new StringBuilder();
            StringBuilder word = new StringBuilder();

            for (int idx = 0; idx < s.Length; idx++)
            {
                if (s[idx] == ' ')
                {
                    if (word.Length != 0)
                    {
                        answer.Insert(0, word);
                        answer.Insert(0, ' ');
                    }

                    word.Clear();
                    continue;
                }
                else
                {
                    word.Append(s[idx]);
                }
            }

            answer.Insert(0, word);
            answer.Insert(0, ' ');

            return answer.ToString().Trim();
        }
    }
}
