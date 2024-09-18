using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] par = new int[105];
    public int solution(int n, int[,] costs) {
        List<Tuple<int,int,int>> list = new List<Tuple<int,int,int>>();
        for(int i = 0; i < costs.GetLength(0); i++){
            list.Add( new Tuple<int,int,int>(costs[i,0], costs[i,1], costs[i,2]));
        }
        list = list.OrderBy(x=>x.Item3).ToList();
        
        int count = 0;
        int answer = 0;
        
        for(int i = 0; i < costs.GetLength(0); i++){
            var cur = list[i];
            if(!IsDiffGroup(cur.Item1, cur.Item2))
                continue;
            answer += cur.Item3;
            count++;
            if(count == n - 1)
                break;
        }
        
        return answer;
    }
    public bool IsDiffGroup(int x, int y){
        x = find(x); y = find(y);
        if(x == y)
            return false;
        
        if(par[x] == par[y])
            par[x]--;
        if(par[x] < par[y])
            par[y] = x;
        else
            par[x] = y;
        
        return true;
    }
    
    public int find(int x){
        if(par[x] <= 0)
            return x;
        return par[x] = find(par[x]);
    }
}