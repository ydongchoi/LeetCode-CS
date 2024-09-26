
// Time Complexity : O(1), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/check-if-the-number-is-fascinating/description/

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _2729_CheckIfTheNumberIsFascinating
    {
        public bool IsFascinating(int n)
        {
            string first = n.ToString();
            string second = (2 * n).ToString();
            string third = (3 * n).ToString();

            string total = first + second + third;
            if (total.Length > 9) return false;

            int[] numLen = new int[10];
            for (int idx = 0; idx < total.Length; ++idx)
            {
                int number = total[idx] - '0';
                if (number == 0) return false;

                numLen[number]++;
            }

            for (int idx = 1; idx <= 9; ++idx)
            {
                if (numLen[idx] != 1) return false;
            }

            return true;
        }
    }
}
