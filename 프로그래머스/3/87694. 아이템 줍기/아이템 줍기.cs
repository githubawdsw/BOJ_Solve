using System;
using System.Collections.Generic;
public class Solution {
    public int[,] dis = new int[105,105];
    public bool[,] board = new bool[105,105];
    public int[] dx = {1,0,-1,0};
    public int[] dy = {0,1,0,-1};
    public int solution(int[,] rectangle, int characterX, int characterY, int itemX, int itemY) {
        Queue<Tuple<int,int>> q = new Queue<Tuple<int,int>>();
        
        FloodFillInner(rectangle);
        q.Enqueue(new Tuple<int,int> (characterX * 2, characterY * 2));
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(cur.Item1 == itemX * 2 && cur.Item2 == itemY * 2)
            {
                break;
            }
            for(int i = 0; i < 4; i++){
                int nx = cur.Item1 + dx[i];
                int ny = cur.Item2 + dy[i];
                
                 if (nx < 0 || ny < 0 || nx > 102 || ny > 102)
                    continue;
                if(!board[nx,ny] || dis[nx,ny] > 0)
                    continue;
                
                q.Enqueue(new Tuple<int,int> (nx,ny));
                dis[nx,ny] = dis[cur.Item1,cur.Item2] + 1;
                
            }
        }
        return dis[itemX * 2, itemY * 2] / 2;
        
    }
    public void FloodFillInner(int[,] rectangle){
        for(int i = 0; i < rectangle.GetLength(0); i++){
            int minx = rectangle[i,0] * 2;
            int miny = rectangle[i,1] * 2;
            int maxx = rectangle[i,2] * 2;
            int maxy = rectangle[i,3] * 2;
            
            for(int j = minx; j <= maxx; j++){
                for(int k = miny; k <= maxy; k++){
                    board[j,k] = true;
                }
            }
        }
        
        for(int i = 0; i < rectangle.GetLength(0); i++){
            int minx = rectangle[i,0] * 2;
            int miny = rectangle[i,1] * 2;
            int maxx = rectangle[i,2] * 2;
            int maxy = rectangle[i,3] * 2;
            
            for(int j = minx + 1; j <= maxx - 1; j++){
                for(int k = miny + 1; k <= maxy - 1; k++){
                    board[j,k] = false;
                }
            }
        }
    }
}