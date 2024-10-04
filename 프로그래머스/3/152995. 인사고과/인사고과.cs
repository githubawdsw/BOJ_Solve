using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] scores) {
        List<Tuple<int,int>> list = new List<Tuple<int,int>>();
        for(int i = 1; i < scores.GetLength(0); i++){
            list.Add(new Tuple<int,int>(scores[i,0], scores[i,1]));
        }
        list = list.OrderByDescending(x => x.Item1).ThenBy(x => x.Item2).ToList();
        
        int target1 = scores[0,0];
        int target2 = scores[0,1];
        int sum = target1 + target2;
        int secondMaxScore = 0;
        int answer = 1;
        
        for(int i = 0; i < list.Count; i++){
            if(target1 < list[i].Item1 && target2 < list[i].Item2)
            {
                answer = -1;
                break;
            }
            
            if(secondMaxScore <= list[i].Item2){
                secondMaxScore = list[i].Item2;
                
                if(sum < list[i].Item1 + list[i].Item2 )
                    answer++;
            }
        }
        
        return answer;
    }
}