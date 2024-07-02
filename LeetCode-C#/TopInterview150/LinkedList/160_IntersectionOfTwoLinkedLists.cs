
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/intersection-of-two-linked-lists/

namespace LeetCode_C_.TopInterview150.LinkedList
{
    public class _160_IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();

            while (headA is not null)
            {
                set.Add(headA);
                headA = headA.next;
            }

            while (headB is not null)
            {
                if (set.Contains(headB))
                {
                    return headB;
                }
                headB = headB.next;
            }

            return null;
        }
    }
}
