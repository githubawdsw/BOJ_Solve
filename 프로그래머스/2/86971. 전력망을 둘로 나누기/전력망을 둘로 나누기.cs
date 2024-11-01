using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[,] wires) {
        int max = int.MaxValue;
        for(int i = 0; i < wires.GetLength(0); i++){
            List<int>[] list = new List<int>[n + 1];
            for(int j = 0; j < wires.GetLength(0); j++){
                if(j == i)
                    continue;
                if(list[wires[j,0]] == null)
                    list[wires[j,0]] = new List<int>();
                list[wires[j,0]].Add(wires[j,1]);
                
                if(list[wires[j,1]] == null)
                    list[wires[j,1]] = new List<int>();
                list[wires[j,1]].Add(wires[j,0]);
            }
            
            bool[] vis = new bool[105];
            Queue<int> q = new Queue<int>();
            List<int> count = new List<int>();
            for(int j = 1; j <= n; j++){
                if(vis[j])
                    continue;
                q.Enqueue(j);
                vis[j] = true;
                count.Add(Bfs(list, q, vis));
            }
            max = Math.Min(Math.Abs(count[0] - count[1]), max);
        }
        return max;
    }
    
    public int Bfs(List<int>[] list , Queue<int> q, bool[] vis){
        int count = 1;
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(list[cur] == null)
                continue;
            foreach(var one in list[cur]){
                if(vis[one])
                    continue;
                
                vis[one] = true;
                count++;
                q.Enqueue(one);
            }
        }
        return count;
    }
}