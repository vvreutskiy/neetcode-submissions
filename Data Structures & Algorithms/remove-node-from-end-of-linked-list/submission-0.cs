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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0, head);
        var current = head;
        ListNode slow = dummy;
        var counter = 0;
        while (current != null) {
            current = current.next;
            if (counter == n) {
                slow = slow.next;
            } else {
                counter++;
            }
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}
