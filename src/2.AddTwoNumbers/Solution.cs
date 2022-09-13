namespace _2.AddTwoNumbers;
/*
* You are given two non-empty linked lists representing two non-negative integers. 
* The digits are stored in reverse order, and each of their nodes contains a single digit. 
* Add the two numbers and return the sum as a linked list.
*
* You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var dummy = new ListNode();
        var head = dummy;
        var extra = 0;
        
        while(l1 != null && l2 != null)
        {
            var sum = extra + l1.val + l2.val;
            var unit = sum % 10;
            extra = sum / 10;

            dummy.next = new ListNode(unit);
            dummy = dummy.next; 
            l1 = l1.next;
            l2 = l2.next;
        }

        // if l1 still has values, continue adding them up.
        while(l1 != null)
        {
            var sum = extra + l1.val;
            var unit = sum % 10;
            extra = sum / 10;

            dummy.next = new ListNode(unit);
            dummy = dummy.next; 
            l1 = l1.next;
        }

        // if l1 still has values, continue adding them up.
        while(l2 != null)
        {
            var sum = extra + l2.val;
            var unit = sum % 10;
            extra = sum / 10;

            dummy.next = new ListNode(unit);
            dummy = dummy.next; 
            l2 = l2.next;
        }

        if(extra > 0)
        {
            dummy.next = new ListNode(extra);
        }

        return head.next;
    }
}

public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
}
