// BOJ_21758


int n = int.Parse(Console.ReadLine());
long[] inputHoney = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

long[] dp = new long[100005];
for (int i = 1; i <= n; i++)
{
    dp[i] = inputHoney[i - 1] + dp[i - 1];
}

long ans = 0;
for (int i = 2; i < n; i++)
{
    ans = Math.Max(ans, dp[n] - inputHoney[0] + dp[n] - inputHoney[i - 1] - dp[i]);
}
for (int i = 2; i < n; i++)
{
    ans = Math.Max(ans, dp[n] - inputHoney[n - 1] + dp[i - 1] - inputHoney[i - 1]);
}
for (int i = 2; i < n; i++)
{
    ans = Math.Max(ans, dp[i] - inputHoney[0] + dp[n] - dp[i - 1] - inputHoney[n - 1]);
}

Console.WriteLine(ans);
