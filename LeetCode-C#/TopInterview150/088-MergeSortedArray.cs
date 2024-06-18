
// https://leetcode.com/problems/merge-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150
{
    public class _088_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int idx1 = 0, idx2 = 0; idx2 < n; )
            {
                if (nums1[idx1] >= nums2[idx2])
                {
                    for(int i = m + n - 1; i > idx1; i--) nums1[i] = nums1[i-1];
                    nums1[idx1] = nums2[idx2++];
                }
                else
                {
                    if (idx1 >= (m + idx2)) nums1[idx1++] = nums2[idx2++];
                    else idx1++;
                }
            }
        }
    }
}
