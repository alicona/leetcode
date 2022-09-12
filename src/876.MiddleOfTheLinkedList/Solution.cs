namespace _876.MiddleOfTheLinkedList;
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode ptr2 = head;

        while(ptr2 != null && ptr2.next != null)
        {
            head = head.next;
            ptr2 = ptr2.next.next;
        }

        return head;
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