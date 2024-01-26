// BOJ_2410


int n = int.Parse(Console.ReadLine());
long[] dp = new long[1000005];

dp[0] = 1;
for (int i = 1; i <= n; i <<= 1)
{
	for (int j = i; j <= n; j++)
	{
		dp[j] = (dp[j] + dp[j - i]) % 1000000000;
	}
}

Console.WriteLine(dp[n]);
