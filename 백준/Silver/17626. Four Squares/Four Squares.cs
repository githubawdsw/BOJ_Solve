using System;

namespace Dynamic
{
    
    class BOJ_17626
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[50005];
            for (int i = 1; i <= n; i++)
            {
                dp[i] = i;
                for (int j = 1; j * j <= i; j++)
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
            Console.WriteLine(dp[n] );
        }
    }
    
}
