
// Time Complexity : O(2^N*N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/combination-sum/description/

namespace LeetCode_C_.TopInterview150.BackTracking
{
    public class _39_CombinationSum
    {
        private List<IList<int>> _answer;
        private HashSet<string> _visited;

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            _answer = new List<IList<int>>();
            _visited = new HashSet<string>();

            DFS(new List<int>(), candidates, target, 0);

            return _answer;
        }

        public void DFS(List<int> combi, int[] candidates, int target, int result)
        {

            if (target < result)
            {
                return;
            }

            if (target == result)
            {
                var tmp = new List<int>(combi); tmp.Sort();
               
                StringBuilder sb = new StringBuilder();
                foreach (var elem in tmp)
                {
                    sb.Append(elem.ToString());
                }

                if (_visited.Contains(sb.ToString()))
                {
                    return;
                }

                _visited.Add(sb.ToString());
                _answer.Add(new List<int>(combi));
                return;
            }

            for (int idx = 0; idx < candidates.Length; idx++)
            {
                result += candidates[idx]; combi.Add(candidates[idx]);

                DFS(combi, candidates, target, result);

                result -= candidates[idx]; combi.RemoveAt(combi.Count - 1);
            }
        }
    }
}
