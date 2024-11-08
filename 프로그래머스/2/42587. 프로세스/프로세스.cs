using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] priorities, int location) {
        Queue<int> q = new Queue<int>();
        int length = priorities.Length;
        for(int i = 0; i < length; i++){
            q.Enqueue(i);
        }
        
        int max = priorities.Max();
        int count = 0;
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(priorities[cur] == max){
                priorities[cur] = 0;
                count++;
                max = priorities.Max();
                
                if(priorities[location] == 0)
                    break;
                
                continue;
            }
            
            q.Enqueue(cur);
        }
        int answer = count;
        return answer;
    }
}