using System;
using System.Linq;
public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        Array.Sort(A);
        B = B.OrderByDescending(x => x).ToArray();
        
        int length = A.Length;
        for(int i = 0; i < length; i++){
            answer += A[i] * B[i];
        }
        return answer;
    }
}