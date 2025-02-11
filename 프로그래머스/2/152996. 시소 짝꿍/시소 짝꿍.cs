using System;
using System.Collections.Generic;
public class Solution {
    public long solution(int[] weights) {
        long answer = 0;
        Dictionary<int, long> dict = new Dictionary<int, long>();
        
        for(int i = 0; i < weights.Length; i++){
            if(!dict.ContainsKey(weights[i]))
                dict.Add(weights[i], 0);
            dict[weights[i]]++;
        }
        
        int target = 0;
        for(int i = 0; i < weights.Length; i++){
            if(weights[i] % 2 == 0){
                target = weights[i] * 3 / 2;
                if(dict.ContainsKey(target))
                    answer += dict[target];
            }
            if(weights[i] % 3 == 0){
                target = weights[i] * 4 / 3;
                if(dict.ContainsKey(target))
                    answer += dict[target];
            }
            
            target = weights[i] * 2;
            if(dict.ContainsKey(target))
                answer += dict[target];
        }
        foreach(var one in dict){
            if(one.Value >= 2)
                answer += (one.Value * (one.Value - 1)) / 2;
        }
        return answer;
    }
}