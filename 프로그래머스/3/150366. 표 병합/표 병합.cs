using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int n = 2600;
    public string[] val = new string[2600];
    public int[] parGroup = new int[2600];
    public string[] solution(string[] commands) {
        List<string> answer = new List<string>();
        
        for(int i = 0; i < n; i++){
            parGroup[i] = i;
        }
        
        for (int i = 0; i < commands.Length; i++){
            string[] input = commands[i].Split(' ');
            if (input[0] == "UPDATE"){
                if (input.Length == 4){
                    int r = int.Parse(input[1]);
                    int c = int.Parse(input[2]);
                    val[Find(r * 50 + c)] = input[3];
                }
                else{
                    for(int j = 0; j < n; j++){
                        if(val[Find(j)] != null && val[Find(j)] == input[1])
                           val[Find(j)] = input[2];
                    }
                }
            }
            else if (input[0] == "MERGE"){
                int r1 = int.Parse(input[1]);
                int c1 = int.Parse(input[2]);
                int r2 = int.Parse(input[3]);
                int c2 = int.Parse(input[4]);

                int cell1 = r1 * 50 + c1;
                int cell2 = r2 * 50 + c2;
                
                if(val[Find(cell1)] == null && val[Find(cell2)] != null){
                    (cell1 ,cell2) = (cell2, cell1);
                }
                
                IsDiffGroup(cell1,cell2);
            }

            else if (input[0] == "UNMERGE"){
                int r = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                int g = Find(r * 50 + c);
                string v = val[g];
                
                for(int j = 0; j < n; j++){
                    Find(j);
                }
                
                for(int j = 0; j < n; j++){
                    if(Find(j) == g){
                        parGroup[j] = j;
                        if(j == r * 50 + c)
                            val[j] = v;
                        else
                            val[j] = null;
                    }
                }
            }
            else{
                int r = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                string v = val[Find(r * 50 + c)];
                answer.Add(v == null ? "EMPTY" : v);
            }
        }
        
        return answer.ToArray();
    }
    
    public bool IsDiffGroup(int a, int b){
        a = Find(a); b = Find(b);
        if(a == b)
            return false;
        
        val[b] = null;
        parGroup[b] = a;
        
        return true;
    }
    public int Find(int x){
        if(parGroup[x] == x)
            return x;
        return parGroup[x] = Find(parGroup[x]);
    }
}