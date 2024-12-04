using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = {0, 0};
        HashSet<string> hs = new HashSet<string>();
        hs.Add(words[0]);
        for(int i = 1; i < words.Length; i++){
            if(words[i - 1].Last() != words[i].First()){
                answer = new int[] {i % n + 1, i / n + 1};
                break;
            }
            if(hs.Contains(words[i])){
                answer = new int[] {i % n + 1, i / n + 1};
                break;
            }
            hs.Add(words[i]);
        }
        
        return answer;
    }
}