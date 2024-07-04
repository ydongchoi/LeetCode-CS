
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/reorder-list/description/

namespace LeetCode_C_.TopInterview150.LinkedList
{
    public class _143_ReorderList
    {
        public void ReorderList(ListNode head)
        {
            if (head.next is null) return;

            // Split Linked List
            ListNode slow = head; ListNode fast = head;
            while (fast.next is not null && fast.next.next is not null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Reverse Second Linked List
            ListNode secondStart = slow.next;
            slow.next = null;
            ListNode prev = secondStart;
            ListNode cur = secondStart.next;
            prev.next = null;
            while(cur is not null)
            {
                ListNode tmp = cur.next;
                cur.next = prev;

                prev = cur;
                cur = tmp;
            }

            // Merge two Linked Lists
            cur = head;
            while (prev is not null)
            {
                ListNode prevTmp = prev.next;
                ListNode tmp = cur.next;

                cur.next = prev;
                prev.next = tmp;
                prev = prevTmp;
                cur = tmp;
            }
        }
    }
}
