
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/reorder-list/description/

namespace LeetCode_C_.TopInterview150.LinkedList
{
    public class _143_ReorderList
    {
        public void ReorderList(ListNode head)
        {
            if (head.next is null) return;

            // Count Node
            ListNode cur = head; int nodeCnt = 0;
            while(cur is not null)
            {
                nodeCnt++;
                cur = cur.next;
            }

            // Seperate Linked List to two parts
            int halfCnt = (nodeCnt % 2) == 1 ? nodeCnt / 2 + 1 : nodeCnt / 2;
            ListNode prev = head;  cur = head.next;
            for (int idx = 0; idx < halfCnt; idx++)
            {
                if (idx == halfCnt - 1)
                {
                    prev.next = null;
                    break;
                }
                prev = prev.next;
                cur = cur.next;
            }

            // Reverse Second Linked List
            ListNode secondStart = cur;
            prev = secondStart;
            cur = secondStart.next;
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
