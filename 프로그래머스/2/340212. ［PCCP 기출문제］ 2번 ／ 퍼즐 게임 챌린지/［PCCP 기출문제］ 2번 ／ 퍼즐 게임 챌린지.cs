using System;
using System.Linq;
public class Solution {
    public int solution(int[] diffs, int[] times, long limit) {
        int answer = int.MaxValue;
        int left = diffs.Min();
        int right = diffs.Max();
        
        while(left <= right){
            int mid = (left + right) / 2;
            int level = mid;
            long time = 0;
            
            if(level >= diffs[0])
                time += times[0];
            else
                time += times[0] * (diffs[0] - level);
            
            for(int i = 1; i < diffs.Length; i++){
                if(level >= diffs[i])
                    time += times[i];
                else
                    time += (long)(diffs[i] - level) * (times[i] + times[i - 1]) + times[i];
            }
            
            if(limit >= time){
                right = mid - 1;
                answer = level;
            }
            else
                left = mid + 1;
                
        }
        
        return answer;
    }
}