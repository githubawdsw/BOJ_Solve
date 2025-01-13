using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int k, int[] enemy) {
        int answer = 0;
        SortedDictionary<int, int> ss = new SortedDictionary<int, int>(new MyCompare());
        for(int i = 0; i < enemy.Length; i++){
            if(n >= enemy[i]){
                n -= enemy[i];
                if(!ss.ContainsKey(enemy[i]))
                    ss.Add(enemy[i], 0);
                ss[enemy[i]]++;
                answer++;
            }
            else{
                if(k-- > 0){
                    if(!ss.ContainsKey(enemy[i]))
                        ss.Add(enemy[i], 0);
                    ss[enemy[i]]++;
                    n -= enemy[i];
                    
                    n += ss.First().Key;
                    if(--ss[ss.First().Key] == 0)
                        ss.Remove(ss.First().Key);
                    
                    answer++;
                }
                else
                    break;
            }
        }
        return answer;
    }
    
    public class MyCompare : IComparer<int>{
        public int Compare(int x, int y){
            return y - x;
        }
    }
}