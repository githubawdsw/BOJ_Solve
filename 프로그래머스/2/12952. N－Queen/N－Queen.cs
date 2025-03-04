using System;

public class Solution {
    public int[] dx = {1,0,-1,0,1,-1,1,-1};
    public int[] dy = {0,1,0,-1,1,-1,-1,1};
    public bool[,] QPos = new bool[13,13];
    public int answer = 0;
    public int solution(int n) {
        for(int i = 0; i < n; i++){
            QPos[0, i] = true;
            Dfs(1, n, 0);
            QPos[0, i] = false;
        }
        
        return answer;
    }
    
    public void Dfs(int depth, int n, int x){
        if(depth == n){
            answer++;
            return;
        }
        
        for(int i = 0; i < n; i++){
            bool check = true;
            for(int j = 0; j < 8; j++){
                int nx = x + 1;
                int ny = i;

                if (!check)
                    break;

                while(nx >= 0 && ny >= 0 && nx < n && ny < n){
                    if(QPos[nx, ny]){
                        check = false;
                        break;
                    }
                    nx += dx[j];
                    ny += dy[j];
                }
            }
            if(check){
                QPos[x + 1, i] = true;
                Dfs(depth + 1, n, x + 1);
                QPos[x + 1, i] = false;
            }
        }
        
    }
}