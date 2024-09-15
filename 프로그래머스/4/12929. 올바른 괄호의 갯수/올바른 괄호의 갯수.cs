public class Solution {
    public int solution(int n) {
        int[] dp = new int[20];
        dp[0] = 1;
        dp[1] = 1;
        for(int i = 2; i <= n; i++){
            for(int j = 0; j < i; j++){
                dp[i] += dp[j] * dp[i - 1 - j];
            }
        }
        
        int answer = dp[n];
        return answer;
    }
}