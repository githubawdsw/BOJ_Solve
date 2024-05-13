// BOJ_28017


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] time = new int[505, 505];
int[][] dp = new int[505][];
int ans = int.MaxValue;
for (int i = 0; i < n; i++)
{
    dp[i] = new int[505];
    Array.Fill(dp[i], int.MaxValue / 2);
}
for (int i = 0; i < n; i++)
{
    int[] inputTime = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        time[i, j] = inputTime[j];
	}
}

for (int i = 0; i < m; i++)
{
    dp[0][i] = time[0, i];
}

for (int i = 1; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m; k++)
        {
            if (k != j)
                dp[i][j] = Math.Min(dp[i][j], dp[i - 1][k] + time[i, j]);
        }
    }
}

for (int i = 0; i < m; i++)
{
    ans = Math.Min(ans, dp[n - 1][i]);
}
Console.WriteLine(ans);