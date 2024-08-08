
// Time Complexity : O(M*N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/modify-the-matrix/description/

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _3033_ModifyTheMatrix
    {
        public int[][] ModifiedMatrix(int[][] matrix)
        {

            for (int i = 0; i < matrix[0].Length; ++i)
            {
                List<int> posMem = new List<int>();
                int max = 0;

                for (int j = 0; j < matrix.Length; ++j)
                {
                    if (matrix[j][i] == -1)
                    {
                        posMem.Add(j);
                        continue;
                    }
                    max = max > matrix[j][i] ? max : matrix[j][i];
                }

                foreach (int elem in posMem)
                {
                    matrix[elem][i] = max;
                }

            }

            return matrix;
        }
    }
}
