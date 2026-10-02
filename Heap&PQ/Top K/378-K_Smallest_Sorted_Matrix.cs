public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        
        int n = matrix.Count();
        var heap = new PriorityQueue<(int row, int col), int>();

        for(int r=0;r< n;r++)
        {
            heap.Enqueue((r,0), matrix[r][0]);
        }

        (int row, int col) current = default;
        for(int i=0;i< k;i++)
        {
            current = heap.Dequeue();
            int r = current.row;
            int c  = current.col;

            if(c + 1 < n)
            {
                heap.Enqueue((r,c+1), matrix[r][c+1]);
            }
            
            
        }
        return matrix[current.row][current.col];
    }
}