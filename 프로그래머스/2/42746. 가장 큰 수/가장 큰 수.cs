using System;
using System.Linq;
using System.Text;
public class Solution {
    public string solution(int[] numbers) {
        
        if (numbers.Max() == 0)
            return "0";
        
        StringBuilder sb = new StringBuilder();

        string[] strParse = new string[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
            strParse[i] = numbers[i].ToString();

        strParse = strParse.OrderByDescending(x => x + x + x).ToArray();

        for (int i = 0; i < strParse.Length; i++)
            sb.Append( strParse[i]);

        return sb.ToString();
    }
}