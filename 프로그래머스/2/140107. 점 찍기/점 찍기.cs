using System;

public class Solution {
    public long solution(int k, int d) {
        long answer = 0; 
        long dd = (long)Math.Pow(d, 2);
        long xx;

        for (int x = 0; x <= d; x += k)
        {
            xx = (long)Math.Pow(x, 2);
            int maxY = (int)Math.Sqrt(dd - xx); 
            answer += (maxY / k) + 1;
        }
        return answer;
    }
}