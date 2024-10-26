using System;
using System.Collections.Generic;
class Solution {
    public int solution(int[,] maps) {
        int[] dx = {1,0,-1,0};
        int[] dy = {0,1,0,-1};
        int[,] dis = new int[105,105];
        Queue<(int,int)> q = new Queue<(int,int)>();
        q.Enqueue((0,0));
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            for(int i = 0; i < 4; i++){
                int nx = cur.Item1 + dx[i];
                int ny = cur.Item2 + dy[i];
                
                if(nx < 0 || ny < 0 || nx >= maps.GetLength(0) || ny >= maps.GetLength(1))
                    continue;
                if(maps[nx,ny] == 0 || dis[nx,ny] > 0)
                    continue;
                
                dis[nx,ny] = dis[cur.Item1, cur.Item2] + 1;
                q.Enqueue((nx,ny));
            }
        }
        int answer = dis[maps.GetLength(0) - 1, maps.GetLength(1) - 1] == 0 ? -1 : dis[maps.GetLength(0) - 1, maps.GetLength(1) - 1] + 1;
        return answer;
    }
}