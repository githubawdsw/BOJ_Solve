using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] order) {
        int answer = 0;
        Stack<int> s = new Stack<int>();
        int idx = 0;
        for(int i = 1; i <= order.Length; i++){
            if(i == order[idx]){
                answer++;
                idx++;
                continue;
            }
            while(s.Count > 0){
                if(s.Peek() == order[idx]){
                    s.Pop();
                    answer++;
                    idx++;
                }
                else
                    break;
            }
            s.Push(i);
        }
        
        while(s.Count > 0){
            if(s.Peek() == order[idx]){
                s.Pop();
                answer++;
                idx++;
            }
            else
                break;
        }
        return answer;
    }
}