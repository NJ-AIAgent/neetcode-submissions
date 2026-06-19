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
   public void ReorderList(ListNode head) {
    if (head == null || head.next == null) return;

    // Step 1: find middle (slow ends at middle)
    ListNode slow = head, fast = head;
    while (fast.next != null && fast.next.next != null) {
        slow = slow.next;
        fast = fast.next.next;
    }

    // Step 2: reverse second half
    ListNode second = slow.next;
    slow.next = null;          // cut the list
    ListNode prev = null;
    while (second != null) {
        ListNode tmp = second.next;
        second.next = prev;
        prev = second;
        second = tmp;
    }
    second = prev;             // new head of reversed half

    // Step 3: merge two halves alternately
    ListNode first = head;
    while (second != null) {
        ListNode t1 = first.next, t2 = second.next;
        first.next = second;
        second.next = t1;
        first = t1;
        second = t2;
    }
}
}
