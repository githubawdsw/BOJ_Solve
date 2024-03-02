// BOJ_17212


int n = int.Parse(Console.ReadLine());

int[] dp = new int[100010];

int[] coin = { 1, 2, 5, 7 };
for (int i = 0; i <= n; i++)
{
	for (int j = 0; j < 4; j++)
	{
		if (dp[i + coin[j]] == 0)
			dp[i + coin[j]] = dp[i] + 1;
		else
			dp[i + coin[j]] = Math.Min(dp[i + coin[j]], dp[i] + 1);
	}
}

Console.WriteLine(dp[n]);