// BOJ_20500


long n = int.Parse(Console.ReadLine());

long[,] dp = new long[1550, 3];

dp[1, 2] = 1;
for (int i = 2; i <= n; i++)
{
    dp[i, 0] = (dp[i - 1, 2] + dp[i - 1, 1]) % 1000000007;
    dp[i, 1] = (dp[i - 1, 0] + dp[i - 1, 2]) % 1000000007;
    dp[i, 2] = (dp[i - 1, 1] + dp[i - 1, 0]) % 1000000007;
}

Console.WriteLine(dp[n,0]);