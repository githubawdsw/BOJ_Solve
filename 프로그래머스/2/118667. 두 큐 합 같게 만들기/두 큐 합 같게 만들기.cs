using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        int answer = 0;
        
        Queue<int> q1 = new Queue<int>(queue1);
        Queue<int> q2 = new Queue<int>(queue2);
        
        long sum1 = 0;
        long sum2 = 0;
        int idx = 0;
        while(idx < queue1.Length || idx < queue2.Length){
            if(idx < queue1.Length)
                sum1 += queue1[idx];
            if(idx < queue2.Length)
                sum2 += queue2[idx];
            idx++;
        }
        int pos = -1;
        while(q1.Count > 0 && q2.Count > 0 && sum1 != sum2){
            if(sum1 > sum2){
                sum2 += (long)q1.Peek();
                sum1 -= (long)q1.Peek();
                q2.Enqueue(q1.Dequeue());
                pos++;
            }
            else{
                sum1 += (long)q2.Peek();
                sum2 -= (long)q2.Peek();
                q1.Enqueue(q2.Dequeue());
            }
            answer++;
            if(pos > q2.Count)
                return -1;
        }
        
        if(sum1 != sum2)
            return -1;
        
        return answer;
    }
}