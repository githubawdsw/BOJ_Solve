using System;

namespace Dynamic
{
    
    class BOJ_1309
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[100005];
            dp[1] = 3;
            dp[2] = 7;
            for (int i = 3; i <= n; i++)
                dp[i] =( dp[i - 2] + 2 * dp[i - 1]) % 9901;
            Console.WriteLine(dp[n]% 9901);

        }
    }
    
}
