// BOJ_14651


int n = int.Parse(Console.ReadLine());

long[] dp = new long[33340];
dp[2] = 2;
for (int i = 3; i <= n; i++)
{
    dp[i] = (dp[i - 1] * 3) % 1000000009;
}

Console.WriteLine(dp[n]);