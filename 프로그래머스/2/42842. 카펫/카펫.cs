using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int whole = brown + yellow;
        
        int[] answer = new int[2];
        for(int row = 3; row <= whole / 2; row++){
            if(whole % row == 0){
                int col = whole / row;
                
                if((row - 2) * (col - 2) == yellow){
                    answer[0] = col;
                    answer[1] = row;
                    break;
                }
            }
        }
        return answer;
    }
}