using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int N, int number) {
        HashSet<int>[] dp = new HashSet<int>[10];
        
        if(N == number)
            return 1;
        
        for(int i = 1; i < 10; i++){
            dp[i] = new HashSet<int>();
        }
        
        dp[1].Add(N);
        
        for(int i = 2; i <= 9; i++){
            for(int j = 1; j < i; j++){
                foreach(var a in dp[i - j]){
                    foreach(var b in dp[j]){
                        dp[i].Add(a * b);
                        dp[i].Add(a + b);
                        if(b != 0)
                            dp[i].Add(a / b);
                        if(a - b > 0)
                            dp[i].Add(a - b);
                    }
                }
            }
            
            string sum = "";
            for(int j = 0; j < i; j++){
               sum += string.Format("{0}", N);
            }
            dp[i].Add(int.Parse(sum));
            foreach(var one in dp[i]){
                if(one == number){
                    return i > 8 ? -1 : i;
                }
            }
        }
        return -1;
    }
}