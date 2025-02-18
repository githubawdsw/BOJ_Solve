using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int answer = 0;
        Dictionary<char, List<char>> dict = new Dictionary<char, List<char>>();
        
        dict.Add(skill[0], new List<char>());
        for(int i = 1; i < skill.Length; i++){
            var target = skill[i];
            var last = dict.Last();
            dict.Add(target, last.Value.ToList());
            dict[target].Add(last.Key);
        }
        
        for(int i = 0; i < skill_trees.Length; i++){
            var cur = skill_trees[i];
            if(Find(cur, dict))
                answer++;
        }
        return answer;
    }
    
    public bool Find(string str,  Dictionary<char, List<char>> dict){
        bool[] check = new bool[30];
        for(int i = 0; i < str.Length; i++){
            var target = str[i];
            if (!dict.ContainsKey(target))
                continue;
            
            foreach(var one in dict[target]){
                if(!check[one - 'A'])
                    return false;
            }
            check[target - 'A'] = true;
        }
        return true;
    }
}