using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] picks, string[] minerals) {
        int answer = 0;
        List<Dictionary<string,int>> list = new List<Dictionary<string,int>>();
        list.Add(new Dictionary<string,int>());
        int idx = 0;
        int max = picks.Sum();
        
        list[idx].Add("diamond", 0);
        list[idx].Add("iron", 0);
        list[idx].Add("stone", 0);
        for(int i = 0; i < minerals.Length; i++){
            if (i > max * 5)
            break;

            var one = minerals[i];
            switch (one)
            {
                case "diamond" :
                    list[idx]["diamond"] += 1;
                    list[idx]["iron"] += 5;
                    list[idx]["stone"] += 25;
                    break;
                case "iron":
                    list[idx]["diamond"] += 1;
                    list[idx]["iron"] += 1;
                    list[idx]["stone"] += 5;
                    break;
                case "stone":
                    list[idx]["diamond"] += 1;
                    list[idx]["iron"] += 1;
                    list[idx]["stone"] += 1;
                    break;
            }

            if ((i + 1) % 5 == 0)
            {
                list.Add(new Dictionary<string, int>());
                idx++;
                list[idx].Add("diamond", 0);
                list[idx].Add("iron", 0);
                list[idx].Add("stone", 0);
            }
        }

        list = list.OrderByDescending(x => x["stone"]).ToList();

        for (int i = 0; i < list.Count; i++)
        {
            if (picks[0] > 0)
            {
                answer += list[i]["diamond"];
                picks[0]--;
            }
            else if (picks[1] > 0)
            {
                answer += list[i]["iron"];
                picks[1]--;
            }
            else if (picks[2] > 0)
            {
                answer += list[i]["stone"];
                picks[2]--;
            }
        }
        return answer;
    }
}