using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public long solution(int[] a, int[,] edges) {
        long answer = 0;
        long sum = a.Sum();
        if(sum != 0)
            return -1;
        
        List<int>[] list = new List<int>[a.Length];
        Queue<int> q = new Queue<int>();
        long[] weight = new long[a.Length];
        bool[] vis = new bool[a.Length];
        int[] indegree = new int[a.Length];
        
        for(int i = 0; i < edges.GetLength(0); i++){
            if(list[edges[i,0]] == null)
                list[edges[i,0]] = new List<int>();
            list[edges[i,0]].Add(edges[i,1]);
            indegree[edges[i,0]]++;
            
            if(list[edges[i,1]] == null)
                list[edges[i,1]] = new List<int>();
            list[edges[i,1]].Add(edges[i,0]);
            indegree[edges[i,1]]++;
        }
        
        for(int i = 0; i < a.Length; i++){
            weight[i] = a[i];
            if(list[i].Count == 1)
                q.Enqueue(i);
        }
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            vis[cur] = true;
            
            foreach(var one in list[cur]){
                if(!vis[one]){
                    indegree[one]--;
                    weight[one] += weight[cur];
                    answer += weight[cur] < 0 ? -weight[cur] : weight[cur];
                    weight[cur] = 0;
                    if(indegree[one] == 1)
                        q.Enqueue(one);
                }
            }
        }
        
        return answer;
    }
}