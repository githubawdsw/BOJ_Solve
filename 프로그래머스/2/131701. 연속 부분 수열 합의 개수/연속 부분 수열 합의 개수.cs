using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] elements) {
        HashSet<int> hs = new HashSet<int>();
        int[] concat = elements.Concat(elements).ToArray();
        
        for(int i = 1; i <= elements.Length; i++){
            for(int x = 0; x < elements.Length; x++){
                int sum = 0;
                for(int y = 0; y < i; y++){
                    sum += concat[x + y];
                }
                hs.Add(sum);
            }
        }
        return hs.Count;
    }
}