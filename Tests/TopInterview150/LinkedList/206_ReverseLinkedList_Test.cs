using LeetCode_C_.TopInterview150.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Tests.TopInterview150.LinkedList
{
    public class _206_ReverseLinkedList_Test
    {
        private readonly _206_ReverseLinkedList _algorithm;

        public _206_ReverseLinkedList_Test()
        {
            _algorithm = new _206_ReverseLinkedList();
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4,5}, new int[] {5,4,3,2,1})]
        [InlineData(new int[] {1,2}, new int[] {2,1})]
        public void ReverseList_Input_Returns(int[] nums, int[] expectedResult)
        {
            // Arrange
            var head = new ListNode(nums[0]);
            var cur = head;
            for (int idx = 1; idx < nums.Length; idx++)
            {
                cur.next = new ListNode(nums[idx]);
                cur = cur.next;
            }

            // Act
            var result = _algorithm.ReverseList(head);

            // Assert
            foreach(var expResult in expectedResult)
            {
                Assert.Equal(expResult, result.val);
                result = result.next;
            }
        }
    }
}
