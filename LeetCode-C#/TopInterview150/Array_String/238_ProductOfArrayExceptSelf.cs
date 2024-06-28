
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _238_ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int product = 1;
            int zeroCnt = 0;
            int zeroIdx = 0;

            for(int idx = 0; idx < nums.Length; ++idx)
            {
                if (nums[idx] == 0)
                {
                    zeroCnt++; zeroIdx = idx;
                    continue;
                }

                product = product * nums[idx];
            }

            if(zeroCnt >= 1)
            {
                for (int idx = 0; idx < nums.Length; ++idx)
                    nums[idx] = 0;
                if(zeroCnt == 1) nums[zeroIdx] = product;

            }
            else
            {
                for (int idx = 0; idx < nums.Length; ++idx) nums[idx] = (product / nums[idx]);
            }

            return nums;
        }
    }
}
