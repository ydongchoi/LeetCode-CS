
// Time Complexity : O(N^2), Spacious Complexity : O(N^2)
// Link : https://leetcode.com/problems/pascals-triangle/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _118_PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var answer = new List<IList<int>>();

            // Initialization
            for (int idx = 1; idx <= numRows; idx++)
            {
                var row = new List<int>();
                for (int idx1 = 0; idx1 < idx; idx1++)
                {
                    row.Add(1);
                }
                answer.Add(row);
            }

            for (int idx = 0; idx < answer.Count - 1; idx++)
            {
                for (int idx1 = 0; idx1 < answer[idx].Count - 1; idx1++)
                {
                    int tmpSum = answer[idx][idx1] + answer[idx][idx1 + 1];
                    answer[idx + 1][idx1 + 1] = tmpSum;
                    Console.WriteLine(tmpSum);
                }
            }

            return answer;
        }
    }
}
