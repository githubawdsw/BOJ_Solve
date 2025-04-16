using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] dx = {1,0,-1,0};
    public int[] dy = {0,1,0,-1};
    
    public int solution(string[] storage, string[] requests) {
        int answer = 0;
        int n = storage.Length;
        int m = storage[0].Length;
        
        char[,] board = new char[55,55];
        Stack<(int,int)> s = new Stack<(int, int)>();
        Queue<(int,int)> q = new Queue<(int,int)>();
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                board[i,j] = storage[i][j];
            }
        }
        
        for(int i = 0; i < requests.Length; i++){
            char target = requests[i][0];
            if(requests[i].Length == 1){
                for(int x = 0; x < n; x++){
                    for(int y = 0; y < m; y++){
                        if(board[x,y] != target)
                            continue;
                        
                        bool[,] vis = new bool[55, 55];
                        s.Clear();
                        s.Push((x,y));
                        while(s.Count > 0){
                            var cur = s.Pop();
                            for(int t = 0; t < 4; t++){
                                int nx = cur.Item1 + dx[t];
                                int ny = cur.Item2 + dy[t];
                                if(nx < 0 || ny < 0 || nx >= n || ny >= m){
                                    q.Enqueue((x,y));
                                    break;
                                }
                                else if(vis[nx,ny])
                                    continue;
                                else if(board[nx,ny] == '.'){
                                    vis[nx,ny] = true;
                                    s.Push((nx,ny));
                                }
                                    
                            }
                        }
                    }
                }
                
                while(q.Count > 0){
                    var cur = q.Dequeue();
                    board[cur.Item1, cur.Item2] = '.';
                }
            }
            else{
                for(int x = 0; x < n; x++){
                    for(int y = 0; y < m; y++){
                        if(board[x,y] == target)
                            board[x,y] = '.';
                    }
                }
            }
        }
        
        for(int x = 0; x < n; x++){
            for(int y = 0; y < m; y++){
                if(board[x,y] != '.')
                    answer++;
            }
        }
        return answer;
    }
    
}