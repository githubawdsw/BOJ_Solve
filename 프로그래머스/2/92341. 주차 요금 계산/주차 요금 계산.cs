using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] fees, string[] records) {
        SortedDictionary<string, List<int>> dict = new SortedDictionary<string, List<int>>();
        for(int i = 0; i < records.Length; i++){
            string[] info = records[i].Split(' ');
            string[] time = info[0].Split(':');
            int parse = int.Parse(time[0]) * 60 + int.Parse(time[1]);
            
            if(!dict.ContainsKey(info[1]))
                dict.Add(info[1], new List<int>());
            dict[info[1]].Add(parse);
        }
        
        int[] answer = new int[dict.Count];
        int idx = 0;
        foreach(var one in dict){
            if(one.Value.Count % 2 == 1)
                dict[one.Key].Add(23 * 60 + 59);
            
            int sum = 0;
            for(int i = 0; i < dict[one.Key].Count; i += 2){
                sum += dict[one.Key][i + 1] - dict[one.Key][i];
            }
            if(sum <= fees[0])
                answer[idx] = fees[1];
            else
                answer[idx] = fees[1] + ((sum - fees[0]) % fees[2] == 0 ? (sum - fees[0]) / fees[2] : (sum - fees[0]) / fees[2] + 1) * fees[3];
            
            idx++;
        }
        
        return answer;
    }
}