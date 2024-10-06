// BOJ_17271


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

long[] dp = new long[10005];

for (int i = 0; i < m; i++)
{
    dp[i] = 1;
}

for (int i = m; i <= n; i++)
{
    dp[i] = (dp[i - 1] + dp[i - m]) % 1000000007;
}

Console.WriteLine(dp[n] % 1000000007);