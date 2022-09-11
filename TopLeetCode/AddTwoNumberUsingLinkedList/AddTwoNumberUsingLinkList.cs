using System;
namespace Competitive_programming_in_C_Sharp.TopLeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class AddtwoNumberLinkedList
    {
        public static ListNode IntToList(int num)
        {
            ListNode listHead = null;
            ListNode p = null;
            if (num > 0)
            {
                listHead = new ListNode(num%10);
                p = listHead;
                num /= 10;
                while (num > 0) { 
                    p.next = new ListNode(num%10);
                    num /= 10;
                    p = p.next;
                }
            }
            return listHead;
        }
        public static void PrintList(ListNode listHead)
        {
            while (listHead != null)
            {
                Console.Write(listHead.val + " ");
                listHead = listHead.next;
            }
        }
        public static ListNode SolveAddtwoNumber(ListNode l1, ListNode l2)
        {
            ListNode ansHead = null;
            ListNode ansPointer = null;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = ((l2 == null) ? 0 : l2.val) + ((l1 == null) ? 0 : l1.val) + carry;
                if (ansHead == null)
                {
                    ansHead = new ListNode(sum % 10);
                    ansPointer = ansHead;
                }
                else
                {
                    ansPointer.next = new ListNode(sum % 10);
                    ansPointer = ansPointer.next;
                }
                carry = sum / 10;

                l1 = (l1 == null) ? l1 : l1.next;
                l2 = (l2 == null) ? l2 : l2.next;
            }
            return ansHead;
        }
    }
}
