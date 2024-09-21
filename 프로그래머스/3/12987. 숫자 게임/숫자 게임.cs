using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] A, int[] B) {
        Array.Sort(A);
        Array.Sort(B);
        int answer = 0;
        int idx = B.Length - 1;
        for(int i = A.Length - 1; i >= 0; i--){
            if(B[idx] > A[i]){
                answer++;
                idx--;
            }
        }
        
        return answer;
    }
}