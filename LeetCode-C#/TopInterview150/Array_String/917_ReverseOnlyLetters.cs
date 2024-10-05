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
            int start = 0; int end = s.Length - 1;

            while (start < end)
            {
                bool sA = isAlphabet(s[start]);
                bool eA = isAlphabet(s[end]);

                if (sA && eA)
                {
                    char tmp = sb[start];
                    sb[start] = sb[end];
                    sb[end] = tmp;
                    start++; end--;
                }
                else if (sA == true && eA == false)
                {
                    end--;
                }
                else if (sA == false && eA == true)
                {
                    start++;
                }
                else
                {
                    start++; end--;
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
