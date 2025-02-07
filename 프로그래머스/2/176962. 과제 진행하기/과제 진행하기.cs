using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string[,] plans) {
        int n = plans.GetLength(0);
        string[] answer = new string[n];
        
        List<(string, int, int)> list = new List<(string, int, int)>();
        for(int i = 0; i < n; i++){
            string name = plans[i,0];
            string[] start = plans[i,1].Split(':');
            int playtime = int.Parse(plans[i,2]);
            
            list.Add((name, int.Parse(start[0]) * 60 + int.Parse(start[1]), playtime));
        }
        
        list = list.OrderBy(x => x.Item2).ToList();
        
        Stack<(string, int)> s = new Stack<(string, int)>();
        int idx = 0;
        int time = list[0].Item2;
        s.Push((list[0].Item1, list[0].Item3));
        
        for(int i = 1; i < n; i++){
            var next = list[i];
            
            while(s.Count > 0){
                var cur = s.Pop();

                if(time + cur.Item2 > next.Item2){
                    cur = (cur.Item1, cur.Item2 - (next.Item2 - time));
                    s.Push(cur);
                    break;
                }

                else {
                    answer[idx++] = cur.Item1;
                    time += cur.Item2;
                }
            }
            
            s.Push((next.Item1, next.Item3));
            time = next.Item2;
        }
        
        while(s.Count > 0){
            var cur = s.Pop();
            answer[idx++] = cur.Item1;
        }
        return answer;
    }
}