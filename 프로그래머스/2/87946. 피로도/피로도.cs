using System;

public class Solution {
    public bool[] check = new bool[10];
    public int answer = -1;
    public int solution(int k, int[,] dungeons) {
        Solve(0,dungeons.GetLength(0), k, dungeons);
        
        return answer;
    }
    
    public void Solve(int count, int length, int cur, int[,] dungeons){
        answer = Math.Max(answer, count);
        
        for(int i = 0 ; i < length; i++){
            if(check[i] || cur < dungeons[i,0])
                continue;
            
            check[i] = true;
            Solve(count + 1, length, cur - dungeons[i,1] , dungeons);
            check[i] = false;
        }
    }
}