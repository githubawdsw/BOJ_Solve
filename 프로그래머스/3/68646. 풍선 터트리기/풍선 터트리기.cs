using System;

public class Solution {
    public int solution(int[] a) {
        int answer = 0;
        int[] leftMin = new int[1000005];
        int[] rightMin = new int[1000005];
        leftMin[0] = a[0];
        rightMin[a.Length - 1] = a[a.Length - 1];
        for(int i = 1 ; i < a.Length; i++){
            leftMin[i] = Math.Min( a[i], leftMin[i - 1]);
        }
        for(int i = a.Length - 2; i >= 0; i--){
            rightMin[i] = Math.Min( a[i], rightMin[i + 1]);;
        }
        
        for(int i = 0; i < a.Length; i++){
            if(a[i] > leftMin[i] && a[i] > rightMin[i])
                answer++;
        }
        
        return a.Length - answer;
    }
}