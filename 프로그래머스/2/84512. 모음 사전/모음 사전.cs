using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    char[] vowels = {'A', 'E' ,'I', 'O', 'U'};
    public int solution(string word) {
        List<string> list = new List<string>();
        
        for(int length = 1; length <= 5; length++){
            Add(0, length, list, "");
        }
        
        list = list.OrderBy(x => x).ThenBy(x => x.Length).ToList();
        
        int answer = list.IndexOf(word) + 1;
        
        return answer;
    }
    
    public void Add(int count ,int length, List<string> list, string str){
        if(count == length){
            list.Add(str);
            return;
        }
        
        for(int i = 0; i < 5; i++){
            Add(count + 1, length, list, str + vowels[i]);
        }
    }
}