using System;

public class Solution {
    public long solution(int cap, int n, int[] deliveries, int[] pickups) {
        long answer = 0;
        int dsum = 0;
        int psum =0;
        
        for(int i = n - 1; i >= 0; i--){
            int count = 0;
            dsum += deliveries[i];
            psum += pickups[i];
            
            while(dsum > 0 || psum > 0){
                dsum -= cap;
                psum -= cap;
                
                count++;
            }
            
            answer += (i + 1) * count * 2;
        }
        
        return answer;
    }
}