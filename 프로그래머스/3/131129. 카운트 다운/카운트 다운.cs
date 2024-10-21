using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int target) {
        int count = 0;
        while(target >= 311)
        {
            target -= 60;
            count++;
        }
        
        Tuple<int, int>[] dp = new Tuple<int, int>[100005];
        for (int i = 1; i <= target; i++)
        {
            dp[i] = new Tuple<int, int>(int.MaxValue / 2, 0);
        }

        for (int i = 1; i <= 20; i++)
        {
            dp[i] = new Tuple<int, int>(1, 1);
            dp[i * 2] = new Tuple<int, int>(1, 0);
            dp[i * 3] = new Tuple<int, int>(1, 0);
        }
        dp[0] = new Tuple<int, int>(0, 0);
        dp[50] = new Tuple<int, int>(1, 1);

        for (int i = 21; i <= target; i++)
        {
            for (int j = 11; j <= 20 && i >= j * 2; j++)
            {
                if (dp[i].Item1 > dp[i - j * 2].Item1 + 1)
                {
                    dp[i] = new Tuple<int, int>(dp[i - j * 2].Item1 + 1, dp[i - j * 2].Item2);
                }
            }

            for (int j = 7; j <= 20 && i >= j * 3; j++)
            {
                if (dp[i].Item1 > dp[i - j * 3].Item1 + 1)
                {
                    dp[i] = new Tuple<int, int>(dp[i - j * 3].Item1 + 1, dp[i - j * 3].Item2);
                }
            }

            for (int j = 1; j <= 20; j++)
            {
                if (dp[i].Item1 >= dp[i - j].Item1 + 1)
                {
                    if (dp[i].Item2 < dp[i - j].Item2 + 1)
                        dp[i] = new Tuple<int, int>(dp[i - j].Item1 + 1, dp[i].Item2 + 1);
                }
            }
            
            if (i >= 50 && dp[i].Item1 >= dp[i - 50].Item1 + 1 && dp[i].Item2 <= dp[i - 50].Item2 + 1)
                dp[i] = new Tuple<int, int>(dp[i - 50].Item1 + 1, dp[i - 50].Item2 + 1);
        }

        int[] answer = { count + dp[target].Item1, dp[target].Item2 };
        return answer;
    }
}