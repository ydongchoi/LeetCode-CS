using LeetCode_C_.TopInterview150.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.LinkedList
{
    public class _160_IntersectionOfTwoLinkedLists_Test
    {
        private readonly _160_IntersectionOfTwoLinkedLists _algorithm;

        public _160_IntersectionOfTwoLinkedLists_Test()
        {
            _algorithm = new _160_IntersectionOfTwoLinkedLists();
        }

        [Theory]
        [InlineData(new int[] {4,1}, new int[] {5,6,1}, new int[] {8,4,5}, 8)]
        [InlineData(new int[] {1,9,1}, new int[] {3}, new int[] {2,4}, 2)]
        [InlineData(new int[] {2,6,4}, new int[] {1,5}, new int[] {}, null)]
        public void GetIntersectionNode_Input_Returns(int[] listA, int[] listB, int[] listCommon, int expectedResult)
        {
            // Arrange
            var headCommon = new ListNode();
            var cur = new ListNode();
            if (listCommon.Length != 0)
            {
                headCommon = new ListNode(listCommon[0]);
                cur = headCommon;
                for (int idx = 1; idx < listCommon.Length; idx++)
                {
                    cur.next = new ListNode(listCommon[idx]);
                    cur = cur.next;
                }
            }

            var headA = new ListNode(listA[0]);
            cur = headA;
            for (int idx = 1; idx < listA.Length; idx++)
            {
                cur.next = new ListNode(listA[idx]);
                cur = cur.next;
            }
            cur.next = headCommon;

            var headB = new ListNode(listB[0]);
            cur = headB;
            for (int idx = 1; idx < listB.Length; idx++)
            {
                cur.next = new ListNode(listB[idx]);
                cur = cur.next;
            }
            cur.next = headCommon;

            // Action
            var result = _algorithm.GetIntersectionNode(headA, headB);

            // Assert
            Assert.Equal(expectedResult, result.val);
        }

    }
}
