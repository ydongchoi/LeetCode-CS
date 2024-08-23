
// Time Complexity : O(NlogN + N^2), Spacious Complexity : O(N^2)
// Link : https://leetcode.com/problems/3sum/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.TwoPointers
{
    public class _15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> answer = new List<List<int>>();
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            HashSet<string> isVisited = new HashSet<string>();

            // nlogn
            Array.Sort(nums);

            // n, n
            for (int idx = 0; idx < nums.Length; ++idx)
            {
                if (dic.TryGetValue(nums[idx], out List<int> val))
                {
                    if (val.Count < 3) val.Add(idx);
                }
                else
                {
                    dic.Add(nums[idx], new List<int> { idx });
                }

            }

            // n^2
            for (int i = 0; i < nums.Length; ++i)
            {
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    var tmp = -(nums[i] + nums[j]);
                    string combi = nums[i].ToString() + nums[j].ToString() + tmp.ToString();
                    if (isVisited.Contains(combi)) continue;

                    if (dic.TryGetValue(tmp, out List<int> val))
                    {
                        foreach (var elem in val)
                        {
                            if (i == elem || j == elem || elem < i || elem < j || isVisited.Contains(combi)) continue;

                            isVisited.Add(combi);
                            answer.Add(new List<int> { nums[i], nums[j], tmp });
                        }
                    }
                }
            }

            return answer.ToArray();
        }
    }
}
