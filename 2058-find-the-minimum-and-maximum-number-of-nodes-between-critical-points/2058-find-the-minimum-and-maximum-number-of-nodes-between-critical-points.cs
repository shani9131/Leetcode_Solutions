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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        // If the list has fewer than 3 nodes, there can't be any critical points
        if (head == null || head.next == null || head.next.next == null) {
            return new int[] { -1, -1 };
        }

        List<int> criticalPoints = new List<int>();
        ListNode prev = head;
        ListNode curr = head.next;
        ListNode next = curr.next;
        int index = 1; // curr is the second node

        // Traverse the list to collect critical points
        while (next != null) {
            if ((curr.val > prev.val && curr.val > next.val) || (curr.val < prev.val && curr.val < next.val)) {
                criticalPoints.Add(index);
            }
            prev = curr;
            curr = next;
            next = next.next;
            index++;
        }

        // If there are fewer than 2 critical points, return [-1, -1]
        if (criticalPoints.Count < 2) {
            return new int[] { -1, -1 };
        }

        // Calculate the minimum and maximum distances between critical points
        int minDistance = int.MaxValue;
        int maxDistance = criticalPoints[criticalPoints.Count - 1] - criticalPoints[0];

        for (int i = 1; i < criticalPoints.Count; i++) {
            minDistance = Math.Min(minDistance, criticalPoints[i] - criticalPoints[i - 1]);
        }

        return new int[] { minDistance, maxDistance };
    }
}