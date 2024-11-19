using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] prices) {
        int[] answer = new int[prices.Length];
        Stack<(int, int)> s = new Stack<(int, int)>();        
        
        for(int i = 0; i < prices.Length; i++){
            answer[i] = prices.Length - 1 - i;
        }
        for(int i = 0; i < prices.Length; i++){
            int target = prices[i];
            
            while(s.Count > 0 && s.Peek().Item2 > target){
                answer[s.Peek().Item1] = i - s.Pop().Item1;
            }
            
            s.Push((i, target));
        }
        return answer;
    }
}