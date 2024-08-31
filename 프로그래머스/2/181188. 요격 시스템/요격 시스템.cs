using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] targets) {
        List<(int,int)> list = new List<(int,int)>();
        
        for(int i = 0; i < targets.GetLength(0); i++){
            list.Add((targets[i,0], targets[i,1]));
        }
        
        list = list.OrderBy(x => x.Item2).ToList();
        
        
        int shoot = 0;
        double end = 0;
        for(int i = 0; i < list.Count; i++){
            var cur = list[i];
            if(end <= cur.Item1 ){
                shoot++;
                end = cur.Item2;
            }
                
        }
        return shoot;
    }
}