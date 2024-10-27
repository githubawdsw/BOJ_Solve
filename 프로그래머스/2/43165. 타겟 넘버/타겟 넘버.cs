using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] numbers, int target) {
        int[] d = {1, -1};
        int answer = 0;
        Queue<(int,int)> q = new Queue<(int,int)>();
        q.Enqueue((0,0));
        while(q.Count > 0){
            var cur = q.Dequeue();
            
            if(cur.Item2 == numbers.Length){
                if(cur.Item1 == target)
                    answer++;
                continue;
            }
            for(int i = 0; i < 2; i++){
                int nx = cur.Item1 + d[i] * numbers[cur.Item2];
                q.Enqueue((nx, cur.Item2 + 1));
            }
        }
        
        return answer;
    }
}