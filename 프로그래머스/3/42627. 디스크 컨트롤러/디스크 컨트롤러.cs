using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] jobs) {
        List<Tuple<int,int>> list = new List<Tuple<int,int>>();
        for(int i = 0; i < jobs.GetLength(0); i++){
            list.Add(new Tuple<int,int>(jobs[i,0], jobs[i,1]) );
        }
        list = list.OrderBy(x=>x.Item1).ThenBy(x=>x.Item2).ToList();
        
        int count = 0;
        int endTime = 0;
        double sum = 0;
        while(list.Count > 0){
            Tuple<int,int> target = null;
            for(int i = 0; i < list.Count; i++){
                if(list[i].Item1 > endTime)
                    break;
                
                if( target == null )
                    target = list[i];
                
                else{
                    int length = target.Item2 - list[i].Item2;
                    if(length == 0)
                        length = target.Item1 - list[i].Item1;
                    
                    if(length > 0)
                        target = list[i];
                }
            }
            
            if( target == null)
                target = list[0];
            
            int delay = endTime - target.Item1;
            int time = Math.Max(delay, 0) + target.Item2;
            if(delay > 0)
                endTime += target.Item2;
            else
                endTime = target.Item1 + target.Item2;
            sum += time;
            list.Remove(target);
            count++;
        }
        return (int)(sum / jobs.GetLength(0));
    }
}