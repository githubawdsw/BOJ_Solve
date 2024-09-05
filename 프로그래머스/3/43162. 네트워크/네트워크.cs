using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[,] computers) {
        bool[]  vis = new bool[205];
        int answer = 0;
        for(int i = 0; i < n; i++){
            if(!vis[i]){
                Bfs(i, n, computers, vis);
                answer++;
            }
        }
        return answer;
    }
    
    public void Bfs(int x, int n, int[,] computers, bool[] vis){
        Queue<int> q = new Queue<int>();
        q.Enqueue(x);
        while(q.Count > 0){
            var cur = q.Dequeue();
            for(int i = 0; i < n; i++){
                if(i == cur)
                    continue;
                
                if(computers[cur, i] == 1 && !vis[i]){
                    q.Enqueue(i);
                    vis[i] = true;
                }
            }
        }
    }
}