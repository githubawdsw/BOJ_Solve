using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[,] book_time) {
        int answer = 1;
        List<(int, int)> list = new List<(int, int)>();
        for (int i = 0; i < book_time.GetLength(0); i++)
        {
            var cur1 = book_time[i, 0];
            string[] arr1 = cur1.Split(':');
            int val1 = int.Parse(arr1[0] + arr1[1]);
            
            var cur2 = book_time[i, 1];
            string[] arr2 = cur2.Split(':');
            int val2 = int.Parse(arr2[0] + arr2[1]) + 10;
            if(val2 % 100 >= 60)
                val2 += 100 - 60;
            
            if(val1 > val2)
                val2 += 2400;
            list.Add((val1, val2));
        }

        list = list.OrderBy(x => x.Item1).ToList();
        List<(int, int)> room = new List<(int, int)>();
        foreach(var one in list){
            if(room.Count == 0){
                room.Add(one);
                continue;
            }
            
            int idx = 0;
            while(idx < room.Count){
                if(room[idx].Item2 <= one.Item1){
                    room[idx] = one;
                    break;
                }
                idx++;
            }
            if(idx == room.Count){
                room.Add(one);
                answer = Math.Max(answer, room.Count);
            }
                
        }
        
        return answer;
    }
    
}