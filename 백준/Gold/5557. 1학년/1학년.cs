// BOJ_5557


int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long[,] dp = new long[105, 105];

dp[0, arr[0]] = 1;
for (int i = 1; i < n - 1; i++)
{
	for (int j = 0; j <= 20; j++)
	{
		if (j + arr[i] <= 20)
			dp[i, j] += dp[i - 1, j + arr[i]];
		if (j - arr[i] >= 0)
			dp[i, j] += dp[i - 1, j - arr[i]];
	}
}

Console.WriteLine(dp[n-2, arr[n-1]]);