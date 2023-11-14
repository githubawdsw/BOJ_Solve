using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_9252
    {
        static void Main(string[] args)
        {
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();

            int[,] dp = new int[1005,1005];

            for (int i = 1; i <= strA.Length; i++)
            {
                for (int j = 1; j <= strB.Length; j++)
                {
                    if (strA[i - 1] == strB[j - 1])
                        dp[i, j] += dp[i - 1, j - 1]+1;
                    else
                        dp[i, j] = Math.Max( dp[i - 1, j] , dp[i, j - 1]);
                }
            }
            Console.WriteLine(dp[strA.Length, strB.Length]);

            string ans = "";
            int a = strA.Length;
            int b = strB.Length;
            while (a > 0 && b > 0)
            {
                if (dp[a, b] == dp[a - 1, b])
                    a--;
                else if (dp[a, b] == dp[a, b - 1])
                    b--;
                else
                {
                    ans += strA[--a];
                    b--;
                }
            }
            ans = new string( ans.Reverse().ToArray());
            if (dp[strA.Length,strB.Length] != 0)
                Console.WriteLine(ans);
        }
    }
    
}
