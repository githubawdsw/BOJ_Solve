using System;
using System.Collections.Generic;

public class Solution {
    public string answer = "";
    public char[] ch = {'d', 'l', 'r', 'u'};
    public int[] dx = {1,0,0,-1};
    public int[] dy = {0,-1,1,0};
    public string solution(int n, int m, int x, int y, int r, int c, int k) {
        int mindis = Math.Abs(r - x) + Math.Abs(c - y);
        if(k - mindis < 0 || (k - mindis)  % 2 == 1)
            return "impossible";
        
        string[,,] memo = new string[55,55,2505];
        
        Dfs(x,y,"",0, n, m ,r ,c, k);
        
        return answer;
    }
    public void Dfs(int x, int y, string str, int move, int n, int m, int r, int c, int k){
        if( k < move + Math.Abs(r - x) + Math.Abs(c - y))
            return;
        
        if(move == k && x == r && y == c){
            answer = str;
            return;
        }
        for(int i = 0; i < 4; i++){
            int nx = x + dx[i];
            int ny = y + dy[i];
            
            if(nx > 0 && nx <= n && ny > 0 && ny <= m && answer == "")
                Dfs(nx, ny, str + ch[i], move + 1 , n , m , r, c,k);
        }
    }
}