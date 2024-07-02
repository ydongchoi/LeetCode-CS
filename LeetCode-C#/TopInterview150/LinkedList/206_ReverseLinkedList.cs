
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/reverse-linked-list/description/

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
            Stack<ListNode> data = new Stack<ListNode>();

            while (head is not null)
            {
                data.Push(head);
                head = head.next;
            }

            ListNode start = data.Count == 0 ? null : data.Pop();
            ListNode answer = start;

            while (data.Count != 0)
            {
                start.next = data.Pop();
                start = start.next;
            }

            if (start is not null) start.next = null;

            return answer;
        }
    }
}
