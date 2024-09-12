using System;
using System.Linq;
public class Solution {
    public int[] answer = new int[10000];
    public bool[] vis = new bool[20];
    public int idx = 0;
    public int solution(int[] info, int[,] edges) {
        vis[0] = true;
        
        Dfs(info, edges, 1, 0);
        
        return answer.Max();
        
    }
    
    public void Dfs(int[] info, int[,] edges, int sheep, int wolf){
        if(sheep > wolf)
            answer[idx++] = sheep;
        else
            return;

        for(int i = 0; i < edges.GetLength(0); i++){
            if(vis[edges[i,0]] && !vis[edges[i,1]]){
                vis[edges[i,1]] = true;
                if(info[edges[i,1]] == 0)
                    Dfs(info, edges, sheep + 1, wolf);
                else
                    Dfs(info, edges, sheep, wolf + 1);

                vis[edges[i,1]] = false; 
            }

        }
    }
}