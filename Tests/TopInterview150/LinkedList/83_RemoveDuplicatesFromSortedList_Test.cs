using LeetCode_C_.TopInterview150.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.LinkedList
{
    public class _83_RemoveDuplicatesFromSortedList_Test
    {
        private readonly _83_RemoveDuplicatesFromSortedList _algorithm;

        public _83_RemoveDuplicatesFromSortedList_Test()
        {
            _algorithm = new _83_RemoveDuplicatesFromSortedList();
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 1, 2, 3, 3 }, new int[] { 1, 2, 3 })]
        public void DeleteDuplicates_Input_Returns(int[] nums, int[] expectedResult)
        {
            var head = new ListNode(nums[0]);
            var cur = head;
            for (int idx = 1; idx < nums.Length; idx++)
            {
                cur.next = new ListNode(nums[idx]);
                cur = cur.next;
            }

            ListNode result = _algorithm.DeleteDuplicates(head);

            foreach (var expResult in expectedResult)
            {
                Assert.Equal(expResult, result.val);
                result = result.next;
            }
        }
    }
}
