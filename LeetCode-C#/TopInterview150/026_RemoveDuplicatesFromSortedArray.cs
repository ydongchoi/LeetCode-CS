
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150
{
    public class _026_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int answer = 0;

            for(int idx = 1; idx < nums.Length; idx++)
            {
                if (nums[idx - 1] == nums[idx])
                    nums[answer] = nums[idx];
                else 
                    nums[++answer] = nums[idx];
            }

            return answer + 1;
        }
    }
}
