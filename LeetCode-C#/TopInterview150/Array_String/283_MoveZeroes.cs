
// Time Complexity: O(n), Spacious Complexity: O(1)
// Link :https://leetcode.com/problems/move-zeroes/description/?envType=problem-list-v2&envId=array&difficulty=EASY

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _283_MoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int p = 0;
            for (int idx = 0; idx < nums.Length; ++idx)
            {
                if (nums[idx] != 0)
                {
                    int tmp = nums[p];
                    nums[p] = nums[idx];
                    nums[idx] = tmp;
                    p++;
                }
            }
        }
    }
}
