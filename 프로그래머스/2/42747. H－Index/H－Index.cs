using System;

public class Solution {
    public int solution(int[] citations) {
        int n = citations.Length;
        Array.Sort(citations);
        
        int answer = 0;
        for(int i = 0; i <= n; i++){
            int idx = 0;
            int count = 0;
            while(idx < n && i > citations[idx]){
                idx++;
            }
            
            if(i <= n - idx)
                answer = i;
        }
        return answer;
    }
}