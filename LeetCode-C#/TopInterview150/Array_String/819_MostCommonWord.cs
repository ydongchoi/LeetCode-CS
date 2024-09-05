
// Time Complexity : O(N), Spacious Complexity : O(N)
// https://leetcode.com/problems/most-common-word/description/
// Split, Dictionary, HashSet

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _819_MostCommonWord
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            // Split the paragraph using charSeperators
            char[] charSeperators = new char[] { ' ', '!', '?', ',', ';', '.', '\'' };
            string[] words = paragraph.Split(charSeperators, StringSplitOptions.RemoveEmptyEntries);

            // Stored banned to HashSet for finding banned word more fastly
            HashSet<string> bannedMemo = new HashSet<string>();
            foreach (var elem in banned) bannedMemo.Add(elem);

            // Find the most frequent word in paragraph.
            Dictionary<string, int> wordDic = new Dictionary<string, int>();
            int maxWordCnt = 0;
            string answer = "";

            foreach (var word in words)
            {
                string lowerWord = word.ToLower();
                if (bannedMemo.Contains(lowerWord)) continue;

                if (wordDic.TryGetValue(lowerWord, out int wordCnt))
                {
                    wordDic[lowerWord]++;
                    maxWordCnt = maxWordCnt > wordDic[lowerWord] ? maxWordCnt : wordDic[lowerWord];
                    answer = maxWordCnt > wordDic[lowerWord] ? answer : lowerWord;

                }
                else
                {
                    wordDic.Add(lowerWord, 1);
                    answer = maxWordCnt > 1 ? answer : lowerWord;
                }
            }

            return answer;
        }
    }
}
