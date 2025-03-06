using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        int[,] board = new int[1000,1000];
        int[] answer = new int[n * (n + 1) / 2];
        
        int[] dx = {1,0,-1};
        int[] dy = {0,1,-1};
        
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((0, 0));
        board[0, 0] = 1;
        int diridx = 0;
        if(n == 1){
            return new int[] {1};
        }
        while(q.Count > 0){
            var cur = q.Dequeue();
            int nx = cur.Item1 + dx[diridx];
            int ny = cur.Item2 + dy[diridx];
            
            if(nx < 0 || ny < 0|| nx >= n || ny >= n){
                q.Enqueue(cur);
                diridx = (diridx + 1) % 3;
                continue;
            }
                
            if(board[nx,ny] != 0){
                q.Enqueue(cur);
                diridx = (diridx + 1) % 3;
                continue;
            }
            
            board[nx,ny] = board[cur.Item1, cur.Item2] + 1;
            q.Enqueue((nx,ny));
            
            if(board[cur.Item1, cur.Item2] + 1 == n * (n + 1) / 2)
                break;
        }
        
        int idx = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(board[i,j] == 0)
                    break;
                answer[idx++] = board[i, j];
            }
        }
        return answer;
    }
}