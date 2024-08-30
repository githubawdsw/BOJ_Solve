using System;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        
        int left = 0;
        int right = 0;
        
        int sum = 0;
        int ans1 = 0;
        int ans2 = 0;
        int len = 1000005;
        
        while(right < sequence.Length){
            if(sum > k){
                sum -= sequence[left++];
            }
            else{
                sum += sequence[right++];
            }
            if(sum == k){
                if(right - 1 - left < len){
                    ans1 = left;
                    ans2 = right - 1;
                    len = ans2 - ans1;
                }
            }
                
        }
        
        while(sum > k){
            sum -= sequence[left++];
            if(sum == k){
                if(right - 1 - left < len){
                    ans1 = left;
                    ans2 = right - 1;
                    len = ans2 - ans1;
                }
            }
        }
        
        int[] answer = new int[] {ans1, ans2};
        return answer;
    }
}