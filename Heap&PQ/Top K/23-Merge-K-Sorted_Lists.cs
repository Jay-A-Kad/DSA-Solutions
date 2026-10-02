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
    public ListNode MergeKLists(ListNode[] lists) {
        List<int> res = new List<int>();

        var heap = new PriorityQueue< ListNode, int>();

        foreach(var node in lists)
        {
            if(node != null){
                heap.Enqueue(node, node.val);
            }
           
        }

        var dummy = new ListNode();
        var tail = dummy;

        while(heap.Count > 0)
        {
            ListNode n = heap.Dequeue();
            tail.next = n;
            tail = n;
         
            if(n.next != null ){
                heap.Enqueue(n.next, n.next.val);
            }
        }

        return dummy.next;
    }
}