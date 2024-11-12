using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int time = 0;
        Queue<(int, int)> q = new Queue<(int, int)>();
        int curWeight = 0;
        int idx = 0;
        
        while(idx < truck_weights.Length){
            if(q.Count > 0 && time - q.Peek().Item2 == bridge_length){
                curWeight -= q.Peek().Item1;
                q.Dequeue();
            }
            if(curWeight + truck_weights[idx] <= weight){
                q.Enqueue((truck_weights[idx], time));
                curWeight += truck_weights[idx];
                idx++;
            }
            time++;
        }
        
        var target = q.Dequeue();
        while(q.Count > 0){
            target = q.Dequeue();
        }
        while(time - target.Item2 != bridge_length){
            time++;
        }
        return time + 1;
    }
}