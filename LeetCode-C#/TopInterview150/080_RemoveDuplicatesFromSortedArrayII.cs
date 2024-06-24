
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150
{
    public class _080_RemoveDuplicatesFromSortedArrayII
    {
		public int RemoveDuplicates(int[] nums)
		{
			int k = 1;
            int numCnt = 1;

            for (int idx =  1; idx < nums.Length; ++idx)
			{
				if(numCnt >= 2 && nums[idx - 1] == nums[idx])
				{
					numCnt++;
				}
				else if (nums[idx - 1] == nums[idx])
				{
					nums[k++] = nums[idx];
                    numCnt++;
				}
				else
				{
                    nums[k++] = nums[idx];
                    numCnt = 1;
                }
            }

			return k;
		}
	}
}
