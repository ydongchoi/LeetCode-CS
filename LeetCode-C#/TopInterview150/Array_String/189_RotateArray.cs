
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/rotate-array/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _189_RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            k = k % len;
            int[] copiedNums = new int[nums.Length];

            for (int idx = 0; idx < nums.Length; idx++)
                copiedNums[idx] = nums[idx];

            for (int idx = 0; idx < nums.Length; idx++)
                nums[(idx + k) % len] = copiedNums[idx];
        }
    }
}
