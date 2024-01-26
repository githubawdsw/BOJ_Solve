// BOJ_13699


int n = int.Parse(Console.ReadLine());
long[] dp = new long[36];

dp[0] = 1;
for (int i = 1; i <= n; i++)
{
	long sum = 0;
	for (int j = 0; j < i; j++)
	{
		sum += dp[j] * dp[i - 1 - j];
	}
	dp[i] = sum;
}

Console.WriteLine(dp[n]);