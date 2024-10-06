
// Time Complexity : O(N^2), Spacious Complexity : O(N^2)
// Link : https://leetcode.com/problems/pascals-triangle/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _118_PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> answer = new List<IList<int>>();

            for (int idx = 0; idx < numRows; ++idx)
            {
                List<int> row = new List<int>();
                row.Add(1);

                for (int idx1 = 1; idx1 < idx; idx1++)
                {
                    row.Add(answer[idx - 1][idx1 - 1] + answer[idx - 1][idx1]);
                }

                if (idx != 0) row.Add(1);
                answer.Add(row);
            }

            return answer;
        }
    }
}
