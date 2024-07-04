using LeetCode_C_.TopInterview150.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.LinkedList
{
    public class _143_ReorderList_Test
    {
        private readonly _143_ReorderList _algorithm;

        public _143_ReorderList_Test()
        {
            _algorithm = new _143_ReorderList();
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4}, new int[] {1,4,2,3})]
        [InlineData(new int[] {1,2,3,4,5}, new int[] {1,5,2,4,3})]
        [InlineData(new int[] {1}, new int[] {1})]
        public void ReorderList_Input_Returns(int[] nums, int[] expectedResult)
        {
            // Assert
            ListNode head = new ListNode(nums[0]);
            ListNode cur = head;
            for(int idx = 1; idx < nums.Length; idx++)
            {
                ListNode addedNode = new ListNode(nums[idx]);
                cur.next = addedNode; cur = cur.next;
            }

            // Act
            _algorithm.ReorderList(head);

            // Assign
            foreach (var expResult in expectedResult)
            {
                Assert.Equal(expResult, head.val);
                head = head.next;
            }
        }
    }
}
