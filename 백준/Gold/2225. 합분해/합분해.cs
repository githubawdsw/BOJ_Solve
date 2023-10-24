using System;

namespace Dynamic
{
    
    class BOJ_2225
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);

            long[,] dp = new long[205,205];
            for (int i = 1; i <= k; i++)
                dp[1, i] = i;
            for (int i = 1; i <= n; i++)
                dp[n, 1] = 1;
            for (int i = 2; i <= n; i++)
                for (int j = 1; j <= k; j++)
                    dp[i, j] = (dp[i - 1, j] + dp[i, j - 1] ) % 1000000000;

            long ans = dp[n, k] % 1000000000;
            Console.WriteLine(ans);
        }
    }
    
}
