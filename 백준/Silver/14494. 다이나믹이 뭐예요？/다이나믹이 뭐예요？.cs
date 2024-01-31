// BOJ_14494


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

long[,] dp = new long[1005, 1005];
for (int i = 0; i <= n; i++)
{
    dp[i, 1] = 1;
}
for (int i = 0; i <= m; i++)
{
    dp[1, i] = 1;
}

for (int i = 2; i <= n; i++)
{
    for (int j = 2; j <= m; j++)
    {
        dp[i, j] = (dp[i - 1, j] + dp[i, j - 1] + dp[i - 1, j - 1]) % 1000000007;
    }
}

Console.WriteLine(dp[n,m]);
