using System;
using System.Linq;

public class Solution {
    public long solution(int n, int[] times) {
        long left = 1;
        long right = (long)times.Max() * n;
        
        long answer = 0;
        while(left <= right){
            long mid = (left + right) / 2;
            long count = 0;
            for(int i = 0; i < times.Length; i++){
                count += mid / (long)times[i];
            }
            
            if(count >= n){
                answer = mid;
                right = mid - 1;
            }
            else
                left = mid + 1;
        }
        
        return answer;
    }
}