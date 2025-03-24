using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] data, int col, int row_begin, int row_end) {
        var list = new List<int[]>();
        int len = data.GetLength(1);
        
        for(int i = 0; i < data.GetLength(0); i++){
            var arr = new int[len];
            
            for(int j = 0; j < len; j++){
                arr[j] = data[i,j];
            }
            list.Add(arr);
        }
        
        list = list.OrderBy(x => x[col - 1]).ThenByDescending(x => x[0]).ToList();
        
        List<int> sumList = new List<int>();
        for(int i = row_begin - 1; i < row_end; i++){
            int sum = 0;
            for(int j = 0; j < len; j++){
                sum += list[i][j] % (i + 1);
            }
            sumList.Add(sum);
        }
        
        int answer = sumList[0];
        for(int i = 1; i < sumList.Count; i++){
            answer ^= sumList[i];
        }
        return answer;
    }
}