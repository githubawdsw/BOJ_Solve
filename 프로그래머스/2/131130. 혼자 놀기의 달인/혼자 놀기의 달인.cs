using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] cards) {
        int answer = 0;
        bool[] vis = new bool[105];
        List<int> list = new List<int>();
        
        for(int i = 0; i < cards.Length; i++){
            int target = cards[i];
            if(vis[target - 1])
                continue;
            
            int count = 0;
            Queue<int> q = new Queue<int>();
            q.Enqueue(target);
            while(q.Count > 0){
                var cur = q.Dequeue();
                if(vis[cur - 1])
                    break;
                
                count++;
                vis[cur - 1] = true;
                q.Enqueue(cards[cur - 1]);
            }
            list.Add(count);
        }
        
        if(list.Count == 1)
            return 0;
        
        list = list.OrderByDescending( x => x ).ToList();
        answer = list[0] * list[1];
        return answer;
    }
}