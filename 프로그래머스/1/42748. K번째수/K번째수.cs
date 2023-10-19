using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.Length / 3];
        for (int i = 0; i < commands.Length / 3; i++)
        {
            List<int> list = new List<int>();
            for (int j = commands[i,0] - 1; j < commands[i,1]; j++)
            {
                list.Add(array[j]);
            }
            list.Sort();
            answer[i] = list[commands[i, 2] - 1];
        }
        return answer;
        
    }
}