using System;
using System.Collections.Generic;

public class Solution {
    public double[] solution(int k, int[,] ranges) {
        double[] answer = new double[ranges.GetLength(0)];
        Dictionary<int,double> dict = new Dictionary<int,double>();
        
        int idx = 1;
        dict.Add(0,k);
        while(k != 1){
            k = k % 2 == 0 ? k / 2 : k * 3 + 1;
            dict.Add(idx++, k);
        }
        
        for(int i = 0; i < ranges.GetLength(0); i++){
            int left = ranges[i,0];
            int right = dict.Count - 1 + ranges[i,1];
            
            if(left > right){
                answer[i] = -1;
                continue;
            }
            
            double sum = 0;
            for(int j = left; j < right; j++){
                sum += Math.Abs(dict[j + 1] - dict[j]) / 2 + Math.Min(dict[j + 1], dict[j]);
            }
            answer[i] = sum;
        }
        
        return answer;
    }
}