// BOJ_11909



int[,] board = new int[2225, 2225];
int[,] dp = new int[2225, 2225];
int[] dx = { 1, 0 };
int[] dy = { 0, 1 };

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	string[] inputarr = Console.ReadLine().Split(' ');
	for (int j = 0; j < n; j++)
	{
		board[i+1, j+1] = int.Parse(inputarr[j]);
    }
}

for (int i = 1; i <= n; i++)
{
	for (int j = 1; j <= n; j++)
	{
		int cost1 = 0;
		int cost2 = 0;
		if (j > 1)
			cost1 = board[i, j] < board[i, j - 1] ? 0 : board[i, j] - board[i, j - 1] + 1;
		if (i > 1)
			cost2 = board[i, j] < board[i - 1, j] ? 0 : board[i, j] - board[i - 1, j] + 1;
		if (i == 1)
			dp[i, j] = dp[i, j - 1] + cost1;
		else if (j == 1)
			dp[i, j] = dp[i - 1, j] + cost2;
		else
			dp[i, j] = Math.Min(dp[i, j - 1] + cost1, dp[i - 1, j] + cost2);
    }
}

Console.WriteLine(dp[n,n]);
