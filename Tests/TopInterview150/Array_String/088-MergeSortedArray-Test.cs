using LeetCode_C_.TopInterview150.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.Array_String
{
    public class _088_MergeSortedArray_Test
    {
        private readonly _088_MergeSortedArray algorithm;

        public _088_MergeSortedArray_Test()
        {
            algorithm = new _088_MergeSortedArray();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 0, 0, 0 }, 0, new int[] { 2, 5, 6 }, 3, new int[] { 2, 5, 6 })]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { }, 0, new int[] { 1, 2, 3, 0, 0, 0 })]
        public void Merge_Input_Return(int[] nums1,int m, int[] nums2, int n, int[] expectedResult)
        {
            // Act
            algorithm.Merge(nums1, m, nums2, n);
            
            // Assert
            Assert.Equal(expectedResult, nums1);
        }

    }
}
