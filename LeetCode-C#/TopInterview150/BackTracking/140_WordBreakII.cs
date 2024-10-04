using System.Text;

// Time Complexity : O(2^N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/word-break-ii/description/

namespace LeetCode_C_.TopInterview150.BackTracking
{
    public class _140_WordBreakII
    {
        private List<string> _answer;
        private HashSet<string> _dic;

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            _answer = new List<string>();
            _dic = new HashSet<string>();
            foreach (var elem in wordDict) _dic.Add(elem);

            BackTracking(new StringBuilder(s), new StringBuilder());

            return _answer;
        }

        public void BackTracking(StringBuilder sb, StringBuilder sentence)
        {
            if (sb.Length == 0)
            {
                _answer.Add(sentence.ToString(0, sentence.Length - 1));
                return;
            }

            for (int idx = 0; idx < sb.Length; idx++)
            {
                var word = sb.ToString(0, idx + 1);
                if (!_dic.Contains(word)) continue;

                sentence.Append(word + " ");
                BackTracking(new StringBuilder(sb.ToString(idx + 1, sb.Length - word.Length)), sentence);
                sentence.Remove(sentence.Length - (word.Length + 1), word.Length + 1);
            }
        }
    }
}
