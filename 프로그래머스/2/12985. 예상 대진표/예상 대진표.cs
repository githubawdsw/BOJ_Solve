using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        int small = Math.Min(a,b);
        int big = Math.Max(a,b);
        
        while(small != big){
            if(small % 2 == 1)
                small++;
            
            if(big % 2 == 1)
                big++;
            
            small /= 2;
            big /= 2;
            answer++;
        }

        return answer;
    }
}