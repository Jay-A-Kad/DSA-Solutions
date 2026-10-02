public class Solution {
    public int[][] KClosest(int[][] points, int k) {

       var heap = new PriorityQueue<int[],int>();

        foreach(var pt in points)
        {
            int dist = pt[0] * pt[0] + pt[1] * pt[1];

            heap.Enqueue(pt, dist);
        }


        var result = new int[k][];
        for(int i=0 ; i < k ;i++)
        {
            result[i] = heap.Dequeue();
        }

        return result;
    }
}