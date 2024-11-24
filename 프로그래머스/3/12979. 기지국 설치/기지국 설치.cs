using System;

class Solution{
    public int solution(int n, int[] stations, int w){
        int answer =0;
        int sum = 0;
        
        sum = (stations[0] - w - 1) / (2 * w + 1);
        answer += sum;
        
        if((double)(stations[0] - w - 1) / (2 * w + 1) - sum > 0)
            answer++;
        
        for(int i = 1; i < stations.Length; i++){
            int left = stations[i - 1] + w;
            int right = stations[i] - w;
            
            sum = (right - left - 1) / (2 * w + 1);
            answer += sum;
            
            if((double)(right - left - 1) / (2 * w + 1) - sum > 0){
                answer++;
            }
                
        }
        
        if(stations[stations.Length - 1] + w < n){
            sum = (n - (stations[stations.Length - 1] + w)) / (2 * w + 1);
            answer += sum;
            
            if((double)(n - (stations[stations.Length - 1] + w)) / (2 * w + 1) - sum > 0){
                answer++;
            }
        }
            
            
        return answer;
    }
}