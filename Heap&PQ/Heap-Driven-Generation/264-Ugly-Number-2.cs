//An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

//Given an integer n, return the nth ugly number.


public class Solution {
    public int NthUglyNumber(int n) {
    int[] primes = { 2, 3, 5 };


    var ans = new PriorityQueue<long, long>();
    var usedNums = new HashSet<long> { 1 };

    ans.Enqueue(1, 1);
    for (int i = 0; i < n - 1; i++)
    {
        long val = ans.Dequeue();
        foreach (int mul in primes)
        {
            long res = val * mul;
            if (!usedNums.Contains(res))
            {
                ans.Enqueue(res, res);
                usedNums.Add(res);
            }
        }
    }
    return (int)ans.Peek();
    }
}