using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        Dictionary<string, int> target = new Dictionary<string, int>();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for(int i = 0; i < number.Length; i++){
            target.Add(want[i], number[i]);
            dict.Add(want[i], 0);
        }
        
        for(int i = 0; i < 10; i++){
            if(dict.ContainsKey(discount[i])){
                dict[discount[i]]++;
            }
        }
        
        bool check = true;
        foreach(var one in dict){
            if(target[one.Key] != one.Value){
                check = false;
                break;
            }
        }
        if(check)
            answer++;
        
        for(int i = 10; i < discount.Length; i++){
            
            if(dict.ContainsKey(discount[i - 10]))
                dict[discount[i - 10]]--;
            
            if(dict.ContainsKey(discount[i])){
                dict[discount[i]]++;
                
                check = true;
                foreach(var one in dict){
                    if(target[one.Key] != one.Value){
                        check = false; 
                        break;
                    }
                }

                if(check)
                    answer++;
            }
            
        }
        return answer;
    }
}