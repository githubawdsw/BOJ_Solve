using System;

public class Solution {
    public long solution(long r1, long r2) {
        long min = r1 * r1;
        long max = r2 * r2;
        long ans = 0;
        
       for (long i = 1; i < r2; i++)
        {
            long bigCircle = (long)Math.Floor(Math.Sqrt(max - i * i));
            if (i >= r1)
                ans += bigCircle;
            else
            {

                long smallCircle = (long)Math.Ceiling(Math.Sqrt(min - i * i));
                ans += bigCircle - smallCircle + 1;
            }
        }
        ans += r2 - r1 + 1;
        ans *= 4;
        
        return ans;
    }
}