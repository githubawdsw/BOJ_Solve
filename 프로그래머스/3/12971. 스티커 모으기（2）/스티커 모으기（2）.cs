using System;

class Solution
{
    public int solution(int[] sticker)
    {
        if(sticker.Length == 1)
            return sticker[0];
        int[,] dp = new int[100005,3];
        dp[0,0] = sticker[0];
        dp[1,0] = sticker[0];
        dp[1,1] = sticker[1];
        for(int i = 2; i < sticker.Length; i++){
            dp[i,0] = Math.Max(dp[i - 2, 0] + sticker[i], dp[i - 1,0]);
            dp[i,1] = Math.Max(dp[i - 2, 1] + sticker[i], dp[i - 1,1]);
        }
        
        int answer = Math.Max(dp[sticker.Length - 2, 0], dp[sticker.Length - 1, 1]);
        return answer;
    }
}