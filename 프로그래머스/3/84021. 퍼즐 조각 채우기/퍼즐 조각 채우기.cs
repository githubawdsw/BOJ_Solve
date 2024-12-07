using System;
using System.Collections.Generic;
public class Solution {
    public List<(int[,], int)> puzzle = new List<(int[,], int)>();
    public List<(int[,], int)> empty = new List<(int[,], int)>();
    public bool[,] vis = new bool[105,105];
    
    public int solution(int[,] game_board, int[,] table) {
        int answer = 0;
        
        for(int i = 0; i < table.GetLength(0); i++){
            for(int j = 0; j < table.GetLength(1); j++){
                if(table[i,j] == 1 && !vis[i,j])
                    Find(i, j, table, puzzle);
            }
        }
        
        for(int i = 0; i < table.GetLength(0); i++){
            for(int j = 0; j < table.GetLength(1); j++){
                game_board[i,j] = game_board[i,j] == 1 ? 0 : 1;
            }
        }
        
        vis = new bool[105,105];
        for(int i = 0; i < table.GetLength(0); i++){
            for(int j = 0; j < table.GetLength(1); j++){
                if(game_board[i,j] == 1 && !vis[i,j])
                    Find(i, j, game_board, empty);
            }
        }
        
        bool[] isUse = new bool[puzzle.Count];
        
        for(int i = 0; i < empty.Count; i++){
            for(int j = 0; j < puzzle.Count; j++){
                if(isUse[j])
                    continue;
                
                bool check = false;
                int[,] target = puzzle[j].Item1;
                for(int k = 0; k < 4; k++){
                    if(Compare(empty[i].Item1, target)){
                        answer += puzzle[j].Item2;
                        check = true;
                        isUse[j] = true;
                        break;
                    }
                    else
                        target = Rotate(target);
                }
                if(check)
                    break;
            }
        }
        
        return answer;
    }
    
    public void Find(int x, int y, int[,] table, List<(int[,], int)> list){
        int minx = x;
        int miny = y;
        int maxx = x;
        int maxy = y;
        
        int[] dx = {1,0,-1,0};
        int[] dy = {0,1,0,-1};
        bool[,] temp = new bool[105, 105];
        Queue<(int,int)> q = new Queue<(int,int)>();
        q.Enqueue((x,y));
        vis[x, y] = true;
        temp[x,y] = true;
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            for(int i = 0; i < 4; i++){
                int nx = cur.Item1 + dx[i];
                int ny = cur.Item2 + dy[i];
                
                if(nx < 0 || ny < 0 || nx >= table.GetLength(0) || ny >= table.GetLength(1))
                    continue;
                if(vis[nx,ny] || table[nx,ny] == 0 || temp[nx,ny])
                    continue;
                
                minx = Math.Min(minx, nx);
                miny = Math.Min(miny, ny);
                maxx = Math.Max(maxx, nx);
                maxy = Math.Max(maxy, ny);
                temp[nx, ny] = true;
                q.Enqueue((nx,ny));
            }
        }
        
        int[,] shape = new int[maxx - minx + 1, maxy - miny + 1];
        int count = 0;
        for(int i = minx; i <= maxx; i++){
            for(int j = miny; j <= maxy; j++){
                if(temp[i,j]){
                    vis[i,j] = true;
                    shape[i - minx, j - miny] = 1;
                    count++;
                }
            }
        }
        list.Add((shape, count));
    }
    
    public int[,] Rotate(int[,] target){
        int lengthx = target.GetLength(0);
        int lengthy = target.GetLength(1);
        int[,] rotate = new int[lengthy, lengthx];
        
        for(int i = 0; i < lengthx; i++){
            for(int j = 0; j < lengthy; j++){
                if(j >= lengthy || lengthx - i - 1 < 0)
                    continue;
                rotate[j, lengthx - i - 1] = target[i,j];
            }
        }
        
        return rotate;
    }
    
    public bool Compare(int[,] x, int[,] y){
        int lengthx = x.GetLength(0);
        int lengthy = x.GetLength(1);
        
        if(lengthx != y.GetLength(0) || lengthy != y.GetLength(1))
                return false;
        
        for(int i = 0; i < lengthx; i++){
            for(int j = 0; j < lengthy; j++){
                if(x[i,j] != y[i,j])
                    return false;
            }
        }
        return true;
    }
}