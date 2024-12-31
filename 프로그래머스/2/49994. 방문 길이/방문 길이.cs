using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string dirs) {
        int answer = 0;
        Dictionary<char,(int,int)> dict = new Dictionary<char,(int,int)>();
        dict.Add('U', (-1,0));
        dict.Add('D', (1,0));
        dict.Add('L', (0,-1));
        dict.Add('R', (0,1));
        
        HashSet<(int,int, int,int)> hs = new HashSet<(int,int, int,int)>();
        Tuple<int, int> pos = new Tuple<int, int>(5, 5);
        
        for(int i = 0; i < dirs.Length; i++){
            var dir = dict[dirs[i]];
            int nx = dir.Item1 + pos.Item1;
            int ny = dir.Item2 + pos.Item2;
            if(nx < 0 || ny < 0 || nx > 10 || ny > 10)
                continue;
            
            
            if(hs.Contains((pos.Item1, pos.Item2, nx, ny))){
                pos = new Tuple<int, int>(nx, ny);
                continue;
            }
            
            hs.Add((pos.Item1, pos.Item2, nx, ny));
            hs.Add((nx, ny, pos.Item1, pos.Item2));
            pos = new Tuple<int, int>(nx, ny);
            answer++;
        }
        return answer;
    }
}