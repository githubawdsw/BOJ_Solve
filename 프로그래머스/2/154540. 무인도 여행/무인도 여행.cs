using System;
using System.Collections.Generic;
public class Solution {
    public List<int> answer = new List<int>();
    public bool[,] vis = new bool[105,105];
    public int[] dx = {1,0,-1,0};
    public int[] dy = {0,1,0,-1};
    public int[] solution(string[] maps) {
        for(int i = 0; i < maps.Length; i++){
            for(int j = 0; j < maps[i].Length; j++){
                if(maps[i][j] != 'X' && !vis[i,j])
                    Bfs(maps, (i,j));
            }
        }
        
        if(answer.Count == 0)
            answer.Add(-1);
        
        answer.Sort();
        return answer.ToArray();
    }
    
    public void Bfs(string[] maps, (int,int) start){
        Queue<(int,int)> q = new Queue<(int,int)>();
        q.Enqueue(start);
        vis[start.Item1, start.Item2] = true;
        int sum = maps[start.Item1][start.Item2] - '0';
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            for(int i = 0; i < 4; i++){
                int nx = cur.Item1 + dx[i];
                int ny = cur.Item2 + dy[i];
                
                if(nx < 0 || ny < 0 || nx >= maps.Length || ny >= maps[0].Length)
                    continue;
                if(vis[nx,ny] || maps[nx][ny] == 'X')
                    continue;
                
                sum += maps[nx][ny] -'0';
                vis[nx,ny] = true;
                q.Enqueue((nx,ny));
            }
        }
        answer.Add(sum);
    }
}