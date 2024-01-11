// BOJ_13301



int n = int.Parse(Console.ReadLine());
long[] dp = new long[100];
dp[1] = 4;
dp[2] = 6;
for (int i = 3; i <= n; i++)
{
    dp[i] = dp[i - 1] + dp[i - 2];
}

Console.WriteLine(dp[n]);