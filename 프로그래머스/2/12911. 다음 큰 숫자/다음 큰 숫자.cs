using System;

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        string binary = Convert.ToString(n, 2);
        int count = 0;
        for(int i = 0; i < binary.Length; i++){
            if(binary[i] == '1')
                count++;
        }
        
        while(true){
            n++;
            string str = Convert.ToString(n, 2);
            int compare = 0;
            for(int i = 0; i < str.Length; i++){
                if(str[i] == '1')
                    compare++;
            }
            if(compare == count){
                answer = n;
                break;
            }
        }
        return answer;
    }
}