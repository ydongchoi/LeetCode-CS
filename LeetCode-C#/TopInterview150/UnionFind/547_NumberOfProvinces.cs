
// Time Complexity : O(N^2), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/number-of-provinces/description/

namespace LeetCode_C_.TopInterview150.UnionFind
{
    public class _547_NumberOfProvinces
    {
        private int[] parent;

        public int FindCircleNum(int[][] isConnected)
        {
            int n = isConnected.Length;

            parent = new int[n];
            // Initialization of Disjoint Sets
            for (int idx = 0; idx < n; ++idx)
            {
                parent[idx] = idx;
            }

            // Make Graph using Edge and Union
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (isConnected[i][j] == 1)
                    {
                        Union(i, j);
                    }
                }
            }

            // Find the number of root
            int count = 0;
            for (var i = 0; i < parent.Length; i++)
            {
                if (Find(i) == i) count++;
            }
            return count;
        }

        public int Find(int node)
        {
            if (parent[node] == node)
            {
                return node;
            }
            return parent[node] = Find(parent[node]);
        }

        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                parent[rootY] = rootX;
            }
        }
    }
}
