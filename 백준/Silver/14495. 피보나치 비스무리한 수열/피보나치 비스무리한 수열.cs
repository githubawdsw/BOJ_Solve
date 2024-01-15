// BOJ_14495


int n = int.Parse(Console.ReadLine());
long[] dp = new long[120];
dp[1] = 1;
dp[2] = 1;
dp[3] = 1;

for (int i = 4; i <= n; i++)
{
    dp[i] = dp[i - 1] + dp[i - 3];
}
Console.WriteLine(dp[n]);
