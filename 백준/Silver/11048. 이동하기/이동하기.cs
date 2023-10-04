using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_11048
    {
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            int[,] dp = new int[1005, 1005];
            for (int i = 0; i < n; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    dp[i+1,j+1] = int.Parse(inputarr[j]);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int temp = dp[i, j];
                    dp[i, j] = Math.Max(temp + dp[i - 1, j], temp + dp[i, j - 1]);
                    dp[i, j] = Math.Max(dp[i, j] , temp + dp[i -1, j - 1]);
                }
            }
            Console.WriteLine(dp[n,m]);
        }
    }
    
}
