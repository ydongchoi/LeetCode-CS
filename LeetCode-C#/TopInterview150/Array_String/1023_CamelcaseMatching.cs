
// Time Complexity : O(NM), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/camelcase-matching/

using System.Text;

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _1023_CamelcaseMatching
    {
        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            var splittedPattern = SplitWord(pattern);
            List<bool> answer = new List<bool>();

            foreach (var query in queries)
            {
                bool oneAnswer = true;
                var splittedQuery = SplitWord(query);

                if (splittedQuery.Count < splittedPattern.Count)
                {
                    oneAnswer = false;
                    answer.Add(oneAnswer);
                    continue;
                }

                int pIdx = 0; int qIdx = 0;
                for (qIdx = 0; qIdx < splittedQuery.Count; qIdx++)
                {

                    if (pIdx >= splittedPattern.Count)
                    {
                        if (IsLower(splittedQuery[qIdx][0]))
                        {
                            continue;
                        }
                        else
                        {
                            oneAnswer = false;
                            break;
                        }
                    }

                    // Upper, Upper
                    if (!IsLower(splittedQuery[qIdx][0]) && !IsLower(splittedPattern[pIdx][0]))
                    {
                        if (splittedQuery[qIdx][0] != splittedPattern[pIdx][0])
                        {
                            oneAnswer = false; break;
                        }

                        pIdx = pIdx + 1;
                        continue;
                    }

                    // Upper, Lower
                    if (!IsLower(splittedQuery[qIdx][0]) && IsLower(splittedPattern[pIdx][0]))
                    {
                        oneAnswer = false; break;
                    }

                    // Lower, Upper
                    if (IsLower(splittedQuery[qIdx][0]) && !IsLower(splittedPattern[pIdx][0]))
                    {
                        continue;
                    }

                    // Lower, Lower
                    int idx = 0;
                    foreach (var elem in splittedQuery[qIdx])
                    {
                        if (idx >= splittedPattern[pIdx].Length) break;

                        if (elem == splittedPattern[pIdx][idx])
                        {
                            idx++;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (splittedPattern[pIdx].Length == idx)
                    {
                        pIdx = pIdx + 1;
                    }
                    else
                    {
                        oneAnswer = false; break;
                    }
                }

                answer.Add(oneAnswer);
            }

            return answer;
        }

        private List<string> SplitWord(string word)
        {
            List<string> splittedWord = new List<string>();
            StringBuilder sb = new StringBuilder("");

            for (int idx = 0; idx < word.Length; ++idx)
            {
                if ('a' <= word[idx] && word[idx] <= 'z')
                {
                    sb.Append(word[idx]);
                }
                else
                {
                    if (sb.Length != 0)
                    {
                        splittedWord.Add(sb.ToString());
                        sb.Clear();
                    }

                    splittedWord.Add(word[idx].ToString());
                }
            }

            if (sb.Length != 0)
            {
                splittedWord.Add(sb.ToString());
                sb.Clear();
            }

            return splittedWord;
        }

        private bool IsLower(char character)
        {
            bool isLower = ('a' <= character && character <= 'z');

            return isLower;
        }
    }
}
