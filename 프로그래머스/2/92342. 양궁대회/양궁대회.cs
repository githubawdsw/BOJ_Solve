using System;

public class Solution {
    public int[] answer = new int[11];
    public int[] count = new int[11];
    public int max = 0;
    public int[] solution(int n, int[] info) {
        Dfs(0, n, info);
        if(max == 0)
            return new int[]{-1};
        return answer;
    }
    
    public void Dfs(int depth, int arrow, int[] info){
        if(depth == 11 || arrow == 0){
            if(count[5] == 3 && count[7] == 1)
                Console.WriteLine();
            if(arrow > 0)
                count[10] += arrow;
            int apeach = 0;
            int ryan = 0;
            for(int i = 0; i <= 10; i++){
                if(info[i] < count[i])
                    ryan += 10 - i;
                else if(info[i] >= count[i] &&info[i] != 0)
                    apeach += 10 - i;
            }
            if(ryan - apeach >= max && ryan > apeach){
                if(ryan - apeach == max){
                    for(int i = 10; i >= 0; i--){
                        if (count[i] > answer[i])
                            break;
                        else if(count[i] < answer[i])
                            return;
                    }
                }
                Array.Copy(count, answer, 11);
                max = ryan - apeach;
            }
                
            if(arrow > 0)
                count[10] -= arrow;
            return;
        }
        
        if(info[depth] < arrow){
            count[depth] += info[depth] + 1;
            Dfs(depth + 1, arrow - (info[depth] + 1), info);
            count[depth] -= info[depth] + 1;
        }
        Dfs(depth + 1, arrow, info);
    }
}