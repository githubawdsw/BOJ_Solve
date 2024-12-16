using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i < tangerine.Length; i++){
            if(!dict.ContainsKey(tangerine[i]))   
                dict.Add(tangerine[i], 0);
            dict[tangerine[i]]++;
        }
        
        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
        
        foreach(var one in dict){
            if(k <= 0)
                break;
            answer++;
            k -= one.Value;
        }
        
        return answer;
    }
}