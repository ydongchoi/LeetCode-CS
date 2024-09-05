
// Time Complexity : O(M + N), Spacious Complexity : O(M)
// Link : https://leetcode.com/problems/permutation-in-string/description/

namespace LeetCode_C_.TopInterview150.SlidingWindow
{
    public class _567_PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>();
            Dictionary<char, List<int>> dic2 = new Dictionary<char, List<int>>();
            int s1Len = s1.Length;

            for (int idx = 0; idx < s1.Length; ++idx)
            {
                if (dic.TryGetValue(s1[idx], out List<int> val))
                {
                    val.Add(idx);
                }
                else
                {
                    dic.Add(s1[idx], new List<int> { idx });
                }
            }

            int compCnt = 0;
            int start = 0;
            for (int idx = 0; idx < s2.Length; ++idx)
            {
                char elem = s2[idx];

                if (dic.TryGetValue(elem, out List<int> val))
                {

                    if (dic2.TryGetValue(elem, out List<int> val2))
                    {

                        if (val.Count == val2.Count)
                        {
                            dic2.Clear();
                            start = val2[0];

                            compCnt = 0;
                            for (int i = start + 1; i <= idx; ++i)
                            {
                                compCnt++;
                                if (dic2.ContainsKey(s2[i]))
                                {
                                    dic2[s2[i]].Add(i);
                                }
                                else
                                {
                                    dic2.Add(s2[i], new List<int> { i });
                                }
                            }
                        }
                        else
                        {
                            dic2[elem].Add(idx); compCnt++;
                        }
                    }
                    else
                    {
                        dic2.Add(elem, new List<int> { idx }); compCnt++;
                    }

                }
                else
                {
                    dic2.Clear(); compCnt = 0;
                    continue;
                }

                if (compCnt == s1Len)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
