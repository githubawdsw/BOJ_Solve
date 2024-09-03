using System;

public class Solution {
    public string solution(string s) {
        string[] arr = s.Split(' ');
        
        int max = int.MinValue;
        int min = int.MaxValue;
        for(int i = 0; i < arr.Length; i++){
            max = Math.Max(max, int.Parse(arr[i]));
            min = Math.Min(min, int.Parse(arr[i]));
        }
        string answer = min + " " + max;
        return answer;
    }
}