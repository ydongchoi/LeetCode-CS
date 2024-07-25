
// Time Complexity : O(N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/


namespace LeetCode_C_.TopInterview150.LinkedList
{
    public class _83_RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null) return null;

            HashSet<int> memoization = new HashSet<int>();

            ListNode prev = head; memoization.Add(prev.val);
            ListNode cur = head.next;

            while (cur is not null)
            {
                if (memoization.Contains(cur.val))
                {
                    prev.next = cur.next;
                }
                else
                {
                    memoization.Add(cur.val);
                    prev = prev.next;
                }

                cur = cur.next;
            }

            return head;
        }
    }
}
