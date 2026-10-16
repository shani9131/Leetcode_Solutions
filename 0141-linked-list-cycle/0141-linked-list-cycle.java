/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public boolean hasCycle(ListNode head) {
        
        ListNode curr=head;
        ListNode temp=head;
        if(head==null || head.next==null ){
            return false;
        }
        while(temp!=null && temp.next!=null){
            curr=curr.next;
            temp=temp.next.next;
            if(curr==temp){
                return true;
            }
        }
        // if(curr!=temp){
        //     return false;
        // }
        return false;
        
    }
}