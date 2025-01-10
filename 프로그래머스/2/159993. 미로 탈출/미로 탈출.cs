using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] maps) {
        int answer = 0;
        char[,] board = new char[105,105];
        int[,] dis = new int[105,105];
        Queue<Tuple<int,int>> q = new Queue<Tuple<int,int>>();
        int[] dx = {1,0,-1,0};
        int[] dy = {0,1,0,-1};
        
        int lx = maps.Length;
        int ly = maps[0].Length;
        Tuple<int, int> pos = new Tuple<int, int>(0, 0);
        
        for(int i = 0; i < lx; i++){
            for(int j = 0; j < ly; j++){
                board[i,j] = maps[i][j];
                if(board[i,j] == 'S'){
                    q.Enqueue(new Tuple<int,int>(i,j));
                    pos = new Tuple<int,int>(i, j);
                }
            }
        }
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            
            if(board[cur.Item1, cur.Item2] == 'L'){
                pos = new Tuple<int,int>(cur.Item1, cur.Item2);
                break;
            }
                
            for(int i = 0; i < 4; i++){
                int nx = cur.Item1 + dx[i];
                int ny = cur.Item2 + dy[i];
                
                if(nx < 0 || ny < 0 || nx >= lx || ny >= ly)
                    continue;
                if(board[nx,ny] == 'X' || dis[nx,ny] > 0)
                    continue;
                
                dis[nx,ny] = dis[cur.Item1, cur.Item2] + 1;
                q.Enqueue(new Tuple<int,int>(nx,ny));
            }
        }
        
        q.Clear();
        q.Enqueue(pos);
        
        if(board[pos.Item1, pos.Item2] != 'L')
            return -1;
        
        int temp = dis[pos.Item1, pos.Item2];
        dis = new int[105,105];
        dis[pos.Item1, pos.Item2] = temp;
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            
            if(board[cur.Item1, cur.Item2] == 'E'){
                pos = new Tuple<int,int>(cur.Item1, cur.Item2);
                break;
            }
            
            for(int i = 0; i < 4; i++){
                int nx = cur.Item1 + dx[i];
                int ny = cur.Item2 + dy[i];
                
                if(nx < 0 || ny < 0 || nx >= lx || ny >= ly)
                    continue;
                if(board[nx,ny] == 'X' || dis[nx,ny] > 0)
                    continue;
                
                dis[nx,ny] = dis[cur.Item1, cur.Item2] + 1;
                q.Enqueue(new Tuple<int,int>(nx,ny));
            }
        }
        
        if(board[pos.Item1, pos.Item2] == 'E')
            return dis[pos.Item1, pos.Item2];
        
        return -1;
    }
}