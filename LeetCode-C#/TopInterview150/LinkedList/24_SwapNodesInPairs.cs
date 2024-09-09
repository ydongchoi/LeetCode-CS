
// Time Complexity : O(N), Spacious Complexity : O(1)
// https://leetcode.com/problems/swap-nodes-in-pairs/

namespace LeetCode_C_.TopInterview150.LinkedList
{
    public class _24_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head is null || head.next is null) return head;

            ListNode prev = head;
            ListNode cur = head;
            ListNode answer = cur.next;

            while (cur is not null)
            {
                if (cur.next is not null)
                {
                    ListNode tmp = cur.next;

                    cur.next = cur.next.next;
                    tmp.next = cur;

                    if (cur != head) prev.next = tmp;
                }
                else break;

                prev = cur;
                cur = cur.next;
            }

            return answer;
        }
    }
}
