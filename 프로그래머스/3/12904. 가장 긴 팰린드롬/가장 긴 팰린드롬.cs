using System;
public class Solution {
    public int solution(string s) {
        
        int answer = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int mid = i;
            int left = mid;
            int right = mid;
            
            while (left >= 0 && right < s.Length)
            {
                if (s[left] != s[right])
                {
                    break;
                }
                left--;
                right++;
            }

            answer = Math.Max(answer, right - left - 1);

            left = mid - 1;
            right = mid;
            while (left >= 0 && right < s.Length)
            {
                if (s[left] != s[right])
                {
                    break;
                }
                left--;
                right++;
            }
            answer = Math.Max(answer, right - left - 1);
        }
        return answer;
    }
}