
// Time Complexity : O(M + N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/intersection-of-two-linked-lists/

namespace LeetCode_C_.TopInterview150.LinkedList
{
    public class _160_IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode curA = headA; ListNode curB = headB;
            int skipA = 0; int skipB = 0;

            while(curA.next is not null)
            {
                skipA++;
                curA = curA.next;
            }

            while (curB.next is not null)
            {
                skipB++;
                curB = curB.next;
            }

            if (curA != curB) return null;

            int remain = Math.Abs(skipB - skipA);
            if(skipA > skipB)
            {
                for (int idx = 0; idx < remain; ++idx) headA = headA.next;

            }else if(skipB > skipA)
            {
                for (int idx = 0; idx < remain; ++idx) headB = headB.next;
            }

            while(headA is not null && headB is not null)
            {
                if (headA == headB) break;
                headA = headA.next; headB = headB.next;
            }

            return headA;
        }
    }
}
