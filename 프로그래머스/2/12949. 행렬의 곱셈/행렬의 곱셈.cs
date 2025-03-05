using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int maxx = arr1.GetLength(0);
        int maxy = arr2.GetLength(1);
        int[,] answer = new int[maxx, maxy];
        
        for(int i = 0; i < maxx; i++){
            for(int j = 0; j < maxy; j++){
                int x1 = i;
                int y1 = 0;
                int x2 = 0;
                int y2 = j;
                
                while(y1 < arr1.GetLength(1)){
                    answer[i,j] += arr1[x1,y1] * arr2[x2,y2];
                    y1++;
                    x2++;
                }
            }
        }
        
        return answer;
    }
}