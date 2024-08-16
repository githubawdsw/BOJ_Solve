using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[,] edge) {
        
        List<int>[] list = new List<int>[20005];
        for(int i = 0; i < edge.GetLength(0) ; i++){
            if(list[edge[i,0]] == null)
                list[edge[i,0]] = new List<int>();
            list[edge[i,0]].Add(edge[i,1]);
            
            if(list[edge[i,1]] == null)
                list[edge[i,1]] = new List<int>();
            list[edge[i,1]].Add(edge[i,0]);
        }
        
        SortedSet<int> pq = new SortedSet<int>();
        int[] dp = new int[20005];
        pq.Add(1);
        Array.Fill(dp, int.MaxValue / 2);
        dp[1] = 0;
        int answer = 0;
        
        while(pq.Count > 0){
            var cur = pq.First();
            pq.Remove(cur);
            
            foreach(var one in list[cur]){
                if(dp[one] > dp[cur] + 1){
                    dp[one] = dp[cur] + 1;
                    pq.Add(one);
                }
            }
        }
        
        for(int i = 0; i < dp.Length; i++){
            if(dp[i] == int.MaxValue / 2)
                dp[i] = -1;
        }
        
        int max = dp.Max();
        for(int i = 2; i <= n; i++){
            if(dp[i] == max){
                answer++;
            }
        }
        
        return answer;
    }
    
}