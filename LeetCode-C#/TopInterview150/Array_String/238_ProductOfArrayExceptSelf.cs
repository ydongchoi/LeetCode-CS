
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _238_ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            int[] memoization = new int[len];
            int[] reverseMemoization = new int[len];
            int[] answer = new int[len];

            memoization[0] = nums[0];
            reverseMemoization[len - 1] = nums[len - 1];

            for (int idx = 1; idx < len; ++idx)
            {
                memoization[idx] = nums[idx] * memoization[idx - 1];
                reverseMemoization[len - 1 - idx] = nums[len - 1 - idx] * reverseMemoization[len - idx];
            }

            for (int idx = 0; idx < len; ++idx)
            {
                int prev = idx - 1; int next = idx + 1;

                if (idx == 0)
                {
                    answer[idx] = reverseMemoization[next];
                }
                else if (idx == len - 1)
                {
                    answer[idx] = memoization[prev];
                }
                else
                {
                    answer[idx] = memoization[prev] * reverseMemoization[next];
                }
            }

            return answer;
        }
    }
}
