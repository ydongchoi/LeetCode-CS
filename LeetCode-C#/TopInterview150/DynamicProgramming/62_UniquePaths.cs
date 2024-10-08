
// Time Complexity : O(MN), Spacious Complexity : O(MN)
// Link : https://leetcode.com/problems/unique-paths/description/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _62_UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            int[,] memo = new int[m, n];
            bool[,] visited = new bool[m, n];
            int[] nxtRow = [1, 0];
            int[] nxtCol = [0, 1];

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(Tuple.Create(0, 0));
            memo[0, 0] = 1;

            while (queue.Count != 0)
            {
                var cur = queue.Dequeue();
                int curX = cur.Item1; int curY = cur.Item2;

                if (visited[curX, curY]) continue;
                visited[curX, curY] = true;

                for (int idx = 0; idx < 2; idx++)
                {
                    int nxtX = curX + nxtRow[idx];
                    int nxtY = curY + nxtCol[idx];

                    if (nxtX < 0 || nxtX >= m || nxtY < 0 || nxtY >= n) continue;

                    memo[nxtX, nxtY] = memo[nxtX, nxtY] + memo[curX, curY];
                    queue.Enqueue(Tuple.Create(nxtX, nxtY));
                }
            }

            return memo[m - 1, n - 1];
        }
    }
}
