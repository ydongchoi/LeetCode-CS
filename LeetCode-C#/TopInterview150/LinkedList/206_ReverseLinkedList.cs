
// Time Complexity : O(N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/reverse-linked-list/description/

using System.Runtime.Versioning;

namespace LeetCode_C_.TopInterview150.LinkedList
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
 
    public class _206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head is null) return null;

            ListNode prev = head;
            ListNode cur = head.next;

            while(cur is not null)
            {
                ListNode tmp = cur;
                ListNode tmpNext = cur.next;
                
                cur.next = prev;

                prev = tmp;
                cur = tmpNext;
            }
            head.next = null;

            return prev;
        }
    }
}
