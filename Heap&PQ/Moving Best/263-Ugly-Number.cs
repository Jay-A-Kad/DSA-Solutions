//An ugly number is a positive integer which does not have a prime factor other than 2, 3, and 5.
//Given an integer n, return true if n is an ugly number.


public class Solution {
    public bool IsUgly(int n) {
        if (n <= 0) return false;

        foreach (int p in new[] { 2, 3, 5 })
        {
            while (n % p == 0)
            {
                n /= p;
            }
        }

        return n == 1;
    }

}