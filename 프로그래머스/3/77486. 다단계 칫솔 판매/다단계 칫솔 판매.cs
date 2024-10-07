using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount) {
        Dictionary<string, int> money = new Dictionary<string, int>();
        Dictionary<string, string> par = new Dictionary<string, string>();
        
        money.Add("-", 0);
        for(int i = 0; i < enroll.Length; i++){
            money.Add(enroll[i], 0);
            par.Add(enroll[i], referral[i]);
        }
        
        for(int i = 0; i < seller.Length; i++){
            int value = amount[i] * 100;
            string target = seller[i];
            while(target != "-" && value != 0){
                money[target] += value - value / 10;
                target = par[target];
                value = value / 10;
            }
        }   
        int[] answer = new int[enroll.Length];
        for(int i = 0; i < enroll.Length; i++){
            answer[i] = money[enroll[i]];
        }
            
        return answer;
    }
}