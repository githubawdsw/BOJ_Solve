using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        List<char> list = new List<char>();
        for(int i = 0; i < s.Length; i++){
            list.Add(s[i]);
        }
        
        int count = 0;
        while(count++ < s.Length){
            if(Counting(list))
                answer++;
            
            list.Add(list.First());
            list.RemoveAt(0);
        }
        
        return answer;
    }
    public bool Counting(List<char> list){
        Stack<char> s = new Stack<char>();
        for(int i = 0; i < list.Count; i++){
            if(list[i] == '[' || list[i] == '{' || list[i] == '(')
                s.Push(list[i]);
            else{
                if(s.Count <= 0)
                    return false;
                if (list[i] == ']' && s.Pop() == '[')
                    continue;
                else if (list[i] == '}' && s.Pop() == '{')
                    continue;
                else if (list[i] == ')' && s.Pop() == '(')
                    continue;
                else
                    return false;
            }
        }
        if(s.Count > 0)
            return false;
        return true;
    }
}