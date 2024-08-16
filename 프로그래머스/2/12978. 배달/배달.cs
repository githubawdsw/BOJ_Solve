using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public int solution(int n, int[,] road, int k)
    {
        List<(int, int)>[] list = new List<(int, int)>[55];
        for(int i = 0; i < road.GetLength(0); i++){
            if(list[road[i,0]] == null)
                list[road[i,0]] = new List<(int, int)>();
            list[road[i,0]].Add((road[i,1], road[i,2]));
            
            if(list[road[i,1]] == null)
                list[road[i,1]] = new List<(int, int)>();
            list[road[i,1]].Add((road[i,0], road[i,2]));
        }
        
        SortedSet<(int,int)> pq = new SortedSet<(int,int)>(new Mycompare());
        int[] dp = new int[55];
        
        pq.Add((1 , 0));
        Array.Fill(dp, int.MaxValue / 2);
        dp[1] = 0;
        
        while(pq.Count > 0){
            var cur = pq.First();
            pq.Remove(cur);
            
            int target = cur.Item1;
            int cost = cur.Item2;
            
            if(dp[target] != cost)
                continue;
            foreach(var one in list[target]){
                if(dp[one.Item1] > one.Item2 + dp[target]){
                    dp[one.Item1] = one.Item2 + dp[target];
                    pq.Add((one.Item1, dp[one.Item1]));
                }
            }
        }
        
        int answer = 0;
        for(int i = 1; i <= n; i ++){
            if(dp[i] <= k)
                answer++;
        }
        
        return answer;
    }
    
    public class Mycompare : IComparer<(int,int)>{
        
        public int Compare((int,int) x, (int,int) y){
            if(x.Item2 == y.Item2)
                return x.Item1 - y.Item1;
            
            return x.Item2 - y.Item2;
        }
    }
}