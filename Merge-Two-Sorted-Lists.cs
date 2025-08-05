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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
     {
        List<int> values = new List<int>();

        // Step 1: Extract all values from both lists
        while (list1 != null) {
            values.Add(list1.val);
            list1 = list1.next;
        }

        while (list2 != null) {
            values.Add(list2.val);
            list2 = list2.next;
        }

        // Step 2: Sort the values
        values.Sort();

        // Step 3: Build a new linked list from sorted values
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        foreach (int val in values) {
            current.next = new ListNode(val);
            current = current.next;
        }

        return dummy.next;

        
    }
}