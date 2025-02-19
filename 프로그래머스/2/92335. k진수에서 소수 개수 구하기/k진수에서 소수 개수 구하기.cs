using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public int solution(int n, int k) {
        
        List<long> list = new List<long>();
        StringBuilder convsb = new StringBuilder();
        StringBuilder sb = new StringBuilder();

        while (n >= k)
        {
            convsb.Append(n % k);
            n /= k;
        }
        convsb.Append(n);

        char[] charArray = convsb.ToString().ToCharArray();
        Array.Reverse(charArray);
        string conv = new string(charArray);

        for (int i = 0; i < conv.Length; i++)
        {
            if (conv[i] != '0')
                sb.Append(conv[i]);
            else
            {
                if (sb.Length != 0)
                {
                    long val = long.Parse(sb.ToString());
                    if (CheckPrime(val))
                        list.Add(val);
                }
                sb.Clear();
            }
        }
        
        if (sb.Length != 0){
            long last = long.Parse(sb.ToString());
            if (CheckPrime(last))
                list.Add(last);
        }
        
        return list.Count;
    }
    
    public bool CheckPrime(long num){
        if(num < 2)
            return false;
        
        for(long i = 2; i * i <= num; i++){
            if(num % i == 0)
                return false;
        }
        return true;
    }
}