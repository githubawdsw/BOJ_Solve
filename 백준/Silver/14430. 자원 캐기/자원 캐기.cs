// BOJ_14430


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[305, 305];
int[,] dp = new int[305, 305];
for (int i = 1; i <= n; i++)
{
	int[] areaInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 1; j <= m; j++)
	{
		board[i,j] = areaInfo[j - 1];
	}
}

for (int i = 1; i <= n; i++)
{
	for (int j = 1; j <= m; j++)
	{
		dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]) + board[i, j];
	}
}

Console.WriteLine(dp[n,m]);