using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public List<Tuple<int,int>>[] list = new List<Tuple<int,int>>[50005];
    public int[] solution(int n, int[,] paths, int[] gates, int[] summits) {
        for(int i = 0; i < paths.GetLength(0); i++){
            if(list[paths[i,0]] == null)
                list[paths[i,0]] = new List<Tuple<int,int>>();
            list[paths[i,0]].Add(new Tuple<int,int>(paths[i,2], paths[i,1]));
            if(list[paths[i,1]] == null)
                list[paths[i,1]] = new List<Tuple<int,int>>();
            list[paths[i,1]].Add(new Tuple<int,int>(paths[i,2], paths[i,0]));
        }
        
        int[] max = new int[50005];
        SortedSet<Tuple<int,int>> ss = new SortedSet<Tuple<int,int>>(new MyCompare());
        bool[] isSummit = new bool[50005];
        
        Array.Fill(max, int.MaxValue / 2);
        for(int i = 0; i < gates.Length; i++){
            ss.Add(new Tuple<int,int>(0 , gates[i]));
            max[gates[i]] = 0;
        }
        
        
        for(int i = 0; i < summits.Length; i++){
            isSummit[summits[i]] = true;
        }
        
        while(ss.Count > 0){
            var cur = ss.First();
            ss.Remove(cur);
            
            if(max[cur.Item2] < cur.Item1 || isSummit[cur.Item2])
                continue;
            
            foreach(var one in list[cur.Item2]){
                int val = Math.Max(max[cur.Item2], one.Item1);
                if(max[one.Item2] > val){
                    max[one.Item2] = val;
                    ss.Add(new Tuple<int,int>(val , one.Item2));
                }
            }
        }
        
        int[] answer = { int.MaxValue, int.MaxValue};
        Array.Sort(summits);
        for(int i = 0; i < summits.Length; i++){
            if(max[summits[i]] < answer[1]){
                answer[0] = summits[i];
                answer[1] = max[summits[i]];
            }
        }
        return answer;
    }
    
    public class MyCompare : IComparer<Tuple<int,int>>{
        
        public int Compare(Tuple<int,int> x, Tuple<int,int> y){
            if(x.Item1 == y.Item1)
                return x.Item2 - y.Item2;
            return x.Item1 - y.Item1;
        }
    }
}