using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int time = 0;
        List<int> list = new List<int>();
        int count = 0;
        
        for(int i = 0; i < progresses.Length; i++){
            if(progresses[i] + time * speeds[i] >= 100){
                count++;
                continue;
            }
            if(count != 0)
                list.Add(count);
            
            count = 0;
            while(progresses[i] + time * speeds[i] < 100){
                time++;
            }
            count++;
        }
        if(count > 0)
            list.Add(count);
        
        return list.ToArray();
    }
}