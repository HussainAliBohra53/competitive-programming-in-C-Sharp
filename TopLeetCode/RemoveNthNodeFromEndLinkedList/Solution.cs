using System;
namespace Competitive_programming_in_C_Sharp.TopLeetCode
{ 
    public static class RemoveNthNodeFromEnd
    {
       public static ListNode RemoveNthNodeFromEndSolve(ListNode head,int n)
        {
            ListNode start = new ListNode(0);
            ListNode slow = start;
            ListNode fast = start;
            start.next = head;
            int i = 1;
            while (i<=n+1)
            {
                fast = fast.next;
                i++;
            }
            while (fast!= null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            slow.next = slow.next.next;
            return start.next;
        }
    }
}
