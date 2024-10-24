using System;
using System.Collections.Generic;
public class Solution {
    bool[] isNotPrime = new bool[10000000];
    
    public int[] arr = new int[10];
    public bool[] check = new bool[10];
    public HashSet<int> hs = new HashSet<int>();
    
    public int solution(string numbers) {
        isNotPrime[0] = true;
        isNotPrime[1] = true;
        for(int i = 2; i * i < 10000000; i++){
            if(isNotPrime[i])
                continue;
            for(int j = i + i; j < 10000000; j += i){
                isNotPrime[j] = true;
            }
        }
        
        for(int i = 1; i <= numbers.Length; i++){
            Backtracking(0, i, numbers);
        }
        
        int answer = hs.Count;
        
        return answer;
    }
        
    public void Backtracking(int count, int length, string numbers){
        if(count == length){
            string str = "";
            for(int i = 0; i < length; i++){
                str += arr[i];
            }
            
            int val = int.Parse(str);
            if(!isNotPrime[val])
                hs.Add(val);
                
            return;
        }
        
        for(int i = 0; i < numbers.Length; i++){
            if(check[i])
                continue;
            
            arr[count] = numbers[i] - '0';
            check[i] = true;
            
            Backtracking(count + 1, length, numbers);
            
            check[i] = false;
        }
    }
}