// BOJ_1535



int n = int.Parse(Console.ReadLine());
int[] greeting = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] glad = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[,] dp = new int[25, 105];
int ans = 0;
for (int i = 1; i <= n; i++)
{
	for (int j = 100; j >= 0; j--)
	{
		if (j - greeting[i - 1] > 0)
			dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - greeting[i - 1]] + glad[i - 1]);
		else
			dp[i, j] = dp[i - 1,j];
		ans = Math.Max(ans, dp[i, j]);
	}
}

Console.WriteLine(ans);

