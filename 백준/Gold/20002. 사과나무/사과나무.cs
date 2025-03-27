// BOJ_20002


int n = int.Parse(Console.ReadLine());

int[,] board = new int[305, 305];
int[,] dp = new int[305, 305];
int ans = -1000;

for (int i = 0; i < n; i++)
{
    int[] inputProfit = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		board[i + 1, j + 1] = inputProfit[j];
		ans = Math.Max(ans, inputProfit[j]);
	}
}

for (int i = 1; i <= n; i++)
{
	for (int j = 1; j <= n; j++)
	{
		dp[i, j] = dp[i - 1, j] + dp[i, j - 1] - dp[i - 1, j - 1] + board[i, j];
	}
}

for (int i = 1; i < n; i++)
{
	for (int j = 1; j <= n - i; j++)
	{
		for (int k = 1; k <= n - i; k++)
		{
			ans = Math.Max(ans, dp[j + i, k + i] - dp[j + i, k - 1] - dp[j - 1, k + i] + dp[j - 1, k - 1]);
            if(ans == 54)
				Console.WriteLine();
		}
	}
}

Console.WriteLine(ans);