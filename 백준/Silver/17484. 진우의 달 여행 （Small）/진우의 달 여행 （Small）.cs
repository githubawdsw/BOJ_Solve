// BOJ_17484


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int m = inputnk[1];


int[,,] dp = new int[10, 10, 4];

int[] startInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 1; i <= m; i++)
{
    dp[0, i, 1] = startInfo[i - 1];
    dp[0, i, 2] = startInfo[i - 1];
    dp[0, i, 3] = startInfo[i - 1];
}
for (int i = 0; i < n; i++)
{
    dp[i, 0, 1] = int.MaxValue / 2;
    dp[i, 0, 2] = int.MaxValue / 2;
    dp[i, 0, 3] = int.MaxValue / 2;
    dp[i, m+1, 1] = int.MaxValue / 2;
    dp[i, m+1, 2] = int.MaxValue / 2;
    dp[i, m+1, 3] = int.MaxValue / 2;
}

for (int i = 1; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 1; j <= m; j++)
	{
        dp[i, j, 1] = Math.Min(dp[i - 1, j + 1, 2], dp[i - 1, j + 1, 3]) + inputInfo[j - 1];
        dp[i, j, 2] = Math.Min(dp[i - 1, j, 1], dp[i - 1, j, 3]) + inputInfo[j - 1];
        dp[i, j, 3] = Math.Min(dp[i - 1, j - 1, 1], dp[i - 1, j - 1, 2]) + inputInfo[j - 1];
    }
}

int ans = int.MaxValue;
for (int i = 1; i <= m; i++)
{
    ans = Math.Min(dp[n - 1, i, 1], ans);
    ans = Math.Min(dp[n - 1, i, 2], ans);
    ans = Math.Min(dp[n - 1, i, 3], ans);
}

Console.WriteLine(ans);
