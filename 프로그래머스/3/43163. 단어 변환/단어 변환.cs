using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string begin, string target, string[] words) {
        int answer = 0;
        bool[] vis = new bool[55];
        Queue<Tuple<string, int>> q = new Queue<Tuple<string, int>>();
        q.Enqueue(new Tuple<string, int>(begin, 0));
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(cur.Item1 == target){
                answer = Math.Max(answer, cur.Item2);
                break;
            }
            
            for(int i = 0; i < words.Length; i++){
                if(vis[i])
                    continue;
                
                int count = 0;
                for(int j = 0; j < words[i].Length; j++){
                    if(cur.Item1[j] != words[i][j])
                        count++;
                }
                if(count == 1){
                    q.Enqueue(new Tuple<string, int>(words[i], cur.Item2 + 1));
                    vis[i] = true;
                }
            }
        }
        
        return answer;
    }
}