using System;
using System.Linq;
public class Solution {
    public long solution(int a, int b, int[] g, int[] s, int[] w, int[] t) {
        long answer = -1;
        long start = 0;
        long end = (long)(a + b) * 2 * (long)t.Max();
        while(start <= end){
            long mid = (start + end) / 2;
            
            long gold = 0;
            long silver = 0;
            long both = 0;
            for(int i = 0; i < t.Length; i++){
                long curg = g[i];
                long curs = s[i];
                long curw = w[i];
                long curt = t[i];
                
                long count = mid / (t[i] * 2);
                if(mid % (t[i] * 2) >= t[i])
                    count++;
                
                gold += Math.Min(curg, count * curw);
                silver += Math.Min(curs, count * curw);
                both += Math.Min(curg + curs, count * curw);
            }
            
            if(gold >= a && silver >= b && both >= a + b){
                end = mid - 1;
                answer = mid;
            }
            else{
                start = mid + 1;
            }
        }
        
        return answer;
    }
}