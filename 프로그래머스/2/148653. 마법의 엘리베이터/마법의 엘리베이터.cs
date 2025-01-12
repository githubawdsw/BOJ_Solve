using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int storey) {
        int answer = int.MaxValue;
        
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((storey, 0));
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(cur.Item1 == 0){
                answer = Math.Min(cur.Item2, answer);
            }
                
            int c = 10;
            while(c <= 1000000000){
                if(cur.Item1 % c > 0){
                    q.Enqueue((cur.Item1 - cur.Item1 % c, cur.Item2 + cur.Item1 % c / (c / 10)));
                    q.Enqueue((cur.Item1 + (c - cur.Item1 % c), cur.Item2 + (c - cur.Item1 % c) / (c / 10)));
                    break;
                }
                c *= 10;
            }
        }
        return answer;
    }
}