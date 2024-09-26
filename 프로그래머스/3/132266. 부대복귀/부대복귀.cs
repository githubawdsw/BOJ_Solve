using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] dis = new int[100005];
    List<int>[] list = new List<int>[100005];
    
    public int[] solution(int n, int[,] roads, int[] sources, int destination) {
        for(int i = 0; i < roads.GetLength(0); i++){
            if(list[roads[i,0]] == null)
                list[roads[i,0]] = new List<int>();
            list[roads[i,0]].Add(roads[i,1]);
            
            if(list[roads[i,1]] == null)
                list[roads[i,1]] = new List<int>();
            list[roads[i,1]].Add(roads[i,0]);
        }
        
        int[] answer = new int[sources.Length];
        Dijkstra(destination, n);
        for(int i = 0; i < sources.Length; i++){
            answer[i] = dis[sources[i]] == 999999 ? -1 : dis[sources[i]];
        }
        return answer;
    }
    
    public void Dijkstra(int start, int n){
        SortedSet<Tuple<int, int>> ss = new SortedSet<Tuple<int, int>> (new MyCompare());
        
        for(int i = 1; i <= n; i++){
            dis[i] = 999999;
        }
        dis[start] = 0;
        ss.Add(new Tuple<int, int>(0, start));
        
        while(ss.Count > 0){
            var cur = ss.First();
            ss.Remove(cur);

            if(dis[cur.Item2] != cur.Item1)
                continue;
            if(list[cur.Item2] == null)
                continue;
            
            foreach(var one in list[cur.Item2]){
                if(dis[one] > 1 + dis[cur.Item2]){
                    dis[one] = 1 + dis[cur.Item2];
                    ss.Add(new Tuple<int, int>(dis[one], one));
                }
            }
        }
    }
    
    public class MyCompare : IComparer<Tuple<int,int>>{
        public int Compare(Tuple<int,int> x , Tuple<int,int> y){
            if(x.Item1 == y.Item1)
                return x.Item2 - y.Item2;
            return x.Item1 - y.Item1;
        }
    }
}