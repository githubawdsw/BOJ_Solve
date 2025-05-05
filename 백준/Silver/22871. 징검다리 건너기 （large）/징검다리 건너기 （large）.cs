// BOJ_22871


int n = int.Parse(Console.ReadLine());
long[] inputStoneInfo = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

long[] dp = new long[5005];

for (int i = 1; i < n; i++)
{
	long max = 0;
	for (int j = 0; j < i; j++)
	{
		max = Math.Max(dp[j], (i - j) * (1 + Math.Abs(inputStoneInfo[i] - inputStoneInfo[j])));

		if (dp[i] == 0)
			dp[i] = max;
		else
			dp[i] = Math.Min(dp[i], max);
	}
}

Console.WriteLine(dp[n - 1]);