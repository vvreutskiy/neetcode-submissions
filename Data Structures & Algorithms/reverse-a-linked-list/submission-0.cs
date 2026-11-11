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
    public ListNode ReverseList(ListNode head) {
        if (head?.next == null)
            return head;
        ListNode? current = head;
        ListNode? prev = null;
        do {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        } while (current != null);
        return prev;
    }
}
