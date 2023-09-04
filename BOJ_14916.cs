using System;

namespace Dynamic
{
    
    class BOJ_14916
    {
        static void Main(string[] args)
        {   
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[100005];
            dp[2] = 1;
            dp[4] = 2;
            dp[5] = 1;
            for (int i = 6; i <= n; i++)
            {
                if (dp[i - 5] != 0)
                    dp[i] = dp[i - 5] + 1;
                else if (dp[i - 2] != 0)
                    dp[i] = dp[i - 2] + 1;
            }
            if (dp[n] == 0)
                Console.WriteLine( -1 );
            else 
                Console.WriteLine(dp[n] );
        }
    }
    
}