using System;

public class Solution {
    public long solution(int[] sequence) {
        int[] temp = (int[])sequence.Clone();
        long[,] dp = new long[500005,3];
        dp[0,0] = sequence[0];
        dp[0,1] = -sequence[0];
        
        long answer = Math.Max(dp[0, 0], dp[0, 1]);
        for(int i = 1; i < sequence.Length; i++){
            if(i % 2 == 1){
                dp[i, 0] = Math.Max(dp[i - 1, 0] - sequence[i], -sequence[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1] + sequence[i], sequence[i]);
            }
                
            if(i % 2 == 0){
                dp[i, 0] = Math.Max(dp[i - 1, 0] + sequence[i], sequence[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1] - sequence[i], -sequence[i]);
            }
            
            answer = Math.Max(answer, dp[i, 0]);
            answer = Math.Max(answer, dp[i, 1]);
        }
        
        return answer;
    }
}