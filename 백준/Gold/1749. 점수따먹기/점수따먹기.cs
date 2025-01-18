// BOJ_1749


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[205, 205];
for (int i = 1; i <= n; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    for (int j = 1; j <= m; j++)
    {
		board[i, j] = inputInfo[j - 1];
    }
}

int[,] dp = new int[205, 205];
for (int i = 1; i <= n; i++)
{
	dp[i, 1] = dp[i - 1, 1] + board[i, 1];
}
for (int i = 1; i <= m; i++)
{
    dp[1, i] = dp[1, i - 1] + board[1, i];
}

for (int i = 1; i <= n; i++)
{
	for (int j = 1; j <= m; j++)
	{
		dp[i, j] = (dp[i - 1, j] + dp[i, j - 1] - dp[i - 1, j - 1]) + board[i, j];

    }
}

int ans = int.MinValue;

for (int x = 1; x <= n; x++)
{
	for (int y = 1; y <= m; y++)
	{
		ans = Math.Max(ans, dp[x, y]);
        for (int i = 0; i < x; i++)
		{
			for (int j = 0; j < y; j++)
			{
				ans = Math.Max(ans, dp[x, y] - dp[i, y] - dp[x, j] + dp[i, j]);
            }
		}
	}
}

Console.WriteLine(ans);