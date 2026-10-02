//A super ugly number is a positive integer whose prime factors are in the array primes.

//Given an integer n and an array of integers primes, return the nth super ugly number.

//The nth super ugly number is guaranteed to fit in a 32-bit signed integer.


public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
    
        var heap = new PriorityQueue<long, long>();
        var seen = new HashSet<long> { 1 };
        heap.Enqueue(1, 1);

        for (int i = 0; i < n - 1; i++)
        {
            long val = heap.Dequeue();
            foreach (int p in primes)
            {
                long next = val * p;
                if (seen.Add(next))
                {
                    heap.Enqueue(next, next);
                }
            }
        }

        return (int)heap.Peek();
    }
}