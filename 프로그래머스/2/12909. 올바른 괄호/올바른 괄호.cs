using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
        Queue<char> q = new Queue<char>();
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '(')
                q.Enqueue('(');
            else{
                if(q.Count > 0)
                    q.Dequeue();
                else
                    return false;
            }
        }
        
        if(q.Count > 0)
            return false;
        
        return true;
    }
}