using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        Stack<(int, int)> s = new Stack<(int, int)>();
        s.Push((0,numbers[0]));
        
        for(int i = 1; i < numbers.Length; i++){
            while(s.Count > 0 && s.Peek().Item2 < numbers[i]){
                answer[s.Peek().Item1] = numbers[i];
                s.Pop();
            }
            s.Push((i, numbers[i]));
        }
        
        while(s.Count > 0){
            var cur = s.Pop();
            answer[cur.Item1] = -1;
        }
        return answer;
    }
}