namespace _21.MergeTwoSortedLists;
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        var dummy = new ListNode();
        var head = dummy;

        while (list1 != null && list2 != null)
        {

            if(list1.val < list2.val)
            {
                dummy.next = list1;
                list1 = list1.next;
            }else  // list2 lt or equal list1
            {
                dummy.next = list2;
                list2 = list2.next;
            }

            dummy = dummy.next;
        }   

        if(list1 == null)
        {
            dummy.next = list2;
        }

        if (list2 == null)
        {
            dummy.next = list1;
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