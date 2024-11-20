using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string solution(string number, int k) {
        StringBuilder sb = new StringBuilder();
        int idx = -1;
        for(int i = 0; i < number.Length - k; i++){
            char max = '0';
            for(int j = idx + 1; j <= i + k; j++){
                if(max < number[j]){
                    idx = j;
                    max = number[j];
                }
            }
            sb.Append(max);
        }
        
        return sb.ToString();
    }
}