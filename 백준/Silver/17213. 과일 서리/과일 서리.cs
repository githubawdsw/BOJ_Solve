// BOJ_17213


int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

long[,] dp = new long[35,35];
for (int i = 1; i <= m - 1; i++)
{
	dp[i, 0] = 1;
	dp[i, i] = 1;
	for (int j = 1; j < i; j++)
	{
		dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
	}
}

Console.WriteLine(dp[m - 1,n - 1]);