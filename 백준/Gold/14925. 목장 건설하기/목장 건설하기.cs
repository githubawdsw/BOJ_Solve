// BOJ_14925


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[1005, 1005];
int[,] dp = new int[1005, 1005];
int ans = 0;
for (int i = 0; i < n; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
	if (board[i, 0] == 0)
	{
		dp[i, 0] = 1;
		ans = 1;
	}
}

for (int i = 0; i < m; i++)
{
	if (board[0, i] == 0)
	{
		dp[0, i] = 1;
		ans = 1;
	}
}

for (int i = 1; i < n; i++)
{
	for (int j = 1; j < m; j++)
	{
		if (board[i,j] == 0)
		{
			dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]);
			dp[i, j] = Math.Min(dp[i, j], dp[i - 1, j - 1]) + 1;
			ans = Math.Max(dp[i, j], ans);
		}
	}
}

Console.WriteLine(ans);
