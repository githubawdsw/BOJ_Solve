using System;

public class Solution {
    public int answer = 0;
    public int solution(string name) {
        int length = name.Length;
        int idx = 0;
        int min = int.MaxValue;
        for(int i = 0; i < length; i++){
            answer += Change(i, name);
            
            idx = i + 1;
            while (idx < length && name[idx] == 'A')
                idx++;
            
            int temp = Math.Min(length - 1, i * 2 + length - idx);
            temp = Math.Min(temp, i + (length - idx) * 2);
            
            if (min > temp)
                min = temp;
        }
        
        
        return answer + min;
    }
    
    public int Change(int pos, string name){
        int up = name[pos] - 'A';
        int down = 'Z' + 1 - name[pos];
        return Math.Min(up,down);
    }
}