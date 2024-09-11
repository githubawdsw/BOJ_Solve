using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int distance, int[] rocks, int n) {
        int answer = 0;
        
        Array.Sort(rocks);
        List<int> list = new List<int>(){ 0 };
        
        for(int i = 0; i < rocks.Length; i++){
            list.Add(rocks[i]);
        }
        list.Add(distance);
        
        int left = 1;
        int right = distance;
        while(left <= right){
            int mid = (left + right) / 2;
            int count = 0;
            int baseSpot = 0;
            for(int i = 1; i < list.Count; i++){
                if(list[i] - baseSpot < mid)
                    count++;
                else
                    baseSpot = list[i];
            }
            
            if(count > n)
                right = mid - 1;
            else{
                answer = mid;
                left = mid + 1;
            }
                
        }
        
        return answer;
    }
}