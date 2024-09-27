using System;

public class Solution {
    public int solution(int n, int[,] results) {
        int[][] dis = new int[105][];
        for(int i = 0; i <= n; i++){
            dis[i] = new int[105];
        }
        for(int i = 0; i < results.GetLength(0); i++){
            dis[results[i,0]][results[i,1]] = 1;
        }
        
        for(int i = 1; i <= n; i++){
            for(int j = 1; j <= n; j++){
                for(int k = 1; k <= n; k++){
                    if(dis[j][k] == 0 && dis[j][i] == 1 && dis[i][k] == 1)
                        dis[j][k] = 1;
                }
            }
        }
        
        int answer = 0;
        for(int i = 1; i <= n; i++){
            int sum = 0;
            for(int j = 1; j <= n; j++){
                if(dis[i][j] == 1)
                    sum++;
                if(dis[j][i] == 1)
                    sum++;
            }
            if(sum == n - 1)
                answer++;
        }
        
        return answer;
    }
}