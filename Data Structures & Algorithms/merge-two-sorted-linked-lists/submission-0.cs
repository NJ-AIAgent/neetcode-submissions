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
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode front1;
        ListNode front2;
        ListNode head=null;

        if(list1 == null && list2 == null)
            return null;

        if(list1 == null && list2 != null){
            head= list2;
            return list2;
        } 

        else if (list2 == null && list1 != null){
            head = list1;
            return list1;
        } 


      if (list1.val < list2.val) 
         head = list1;
      else              
         head = list2;



    ListNode tail = head;
    if (head == list1) list1 = list1.next; else list2 = list2.next;

    while (list1 != null && list2 != null) {
        if (list1.val < list2.val) {
             tail.next = list1; list1 = list1.next; }
        else                       
            { tail.next = list2; list2 = list2.next; }
            
        tail = tail.next;
    }
    tail.next = (list1 != null) ? list1 : list2;
    return head;
    }
}
