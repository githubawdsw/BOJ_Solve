using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] players, int m, int k) {
        int answer = 0;
        Queue<int> q = new Queue<int>();
        for(int i = 0; i < players.Length; i++){
            while(q.Count > 0 && q.Peek() == i)
                q.Dequeue();
            
            while(players[i] / m > q.Count){
                q.Enqueue(i + k);
                answer++;
            }
        }
        return answer;
    }
}