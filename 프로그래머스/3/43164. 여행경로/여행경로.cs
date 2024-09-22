using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public bool check = false;
    public bool[] vis = new bool[10005];
    public string[] solution(string[,] tickets) {
        List<string> answer = new List<string>();
        List<List<string>> list = new List<List<string>>();
        for(int i = 0; i < tickets.GetLength(0); i++){
            list.Add(new List<string>());
            list[i].Add(tickets[i,0]);
            list[i].Add(tickets[i,1]);
        }
        list = list.OrderBy(x=>x[0]).ThenBy(x=>x[1]).ToList();
        
        Dfs("ICN", list, 0, answer);
        
        return  answer.ToArray();
    }
    
    public void Dfs(string target, List<List<string>> list, int count, List<string> ans){
        if(count == list.Count)
            check = true;
        
        ans.Add(target);
        for(int i = 0; i < list.Count; i++){
            if(!vis[i] && list[i][0] == target){
                vis[i] = true;
                Dfs(list[i][1], list, count + 1, ans);
                
                if(!check){
                    ans.RemoveAt(ans.Count - 1);
                    vis[i] = false;
                }
                    
            }
        }
    }
}