using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] board) {
        int r = board.Length;
        int c = board[0].Length;
        
        Queue<(int,int)> q = new Queue<(int,int)>();
        int[,] dis = new int[105,105];
        int[] dx = {1,0,-1,0};
        int[] dy = {0,1,0,-1};
        Tuple<int,int> end = new Tuple<int,int>(101,101);
        
        for(int i = 0; i < r; i++){
            for(int j = 0; j < c; j++){
                if(board[i][j] == 'R'){
                    q.Enqueue((i,j));
                    dis[i,j] = 1;
                }
                    
                if(board[i][j] == 'G')
                    end = new Tuple<int,int>(i,j);
            }
        }
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            for(int i = 0; i < 4; i++){
                int nx = cur.Item1;
                int ny = cur.Item2;
                
                while(true){
                    if(nx + dx[i] < 0 || ny + dy[i] < 0 || nx + dx[i] >= r || ny + dy[i] >= c)
                        break;
                    if(board[nx + dx[i]][ny + dy[i]] == 'D')
                        break;
                    nx += dx[i];
                    ny += dy[i];
                }
                if(nx < 0 || ny < 0 || nx >= r || ny >= c)
                    continue;
                if(dis[nx,ny] > 0)
                    continue;
                
                dis[nx,ny] = dis[cur.Item1, cur.Item2] + 1;
                q.Enqueue((nx,ny));
            }
        }
        return dis[end.Item1, end.Item2] == 0 ? -1 : dis[end.Item1, end.Item2] - 1;
    }
}