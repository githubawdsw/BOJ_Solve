using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int x, int y, int n) {
        
        if(x == y)
            return 0;
        
        int[] dis = new int[3000005];
        Queue<int> q = new Queue<int>();
        q.Enqueue(x);
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(cur + n <= y && dis[cur + n] == 0){
                dis[cur + n] = dis[cur] + 1;
                q.Enqueue(cur + n);
            }
            
            if(cur * 2 <= y && dis[cur * 2] == 0){
                dis[cur * 2] = dis[cur] + 1;
                q.Enqueue(cur * 2);
            }
            
            if(cur * 3 <= y && dis[cur * 3] == 0){
                dis[cur * 3] = dis[cur] + 1;
                q.Enqueue(cur * 3);
            }
        }
        
        if(dis[y] == 0)
            return -1;
        
        return dis[y];
    }
}