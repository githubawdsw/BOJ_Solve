// BOJ_11058



int n = int.Parse(Console.ReadLine());
long[] dp = new long[105];
dp[1] = 1;
dp[2] = 2;
dp[3] = 3;
dp[4] = 4;
dp[5] = 5;
for (int i = 6; i <= n; i++)
{
	if (dp[i] <= dp[i - 3] * 2)
		dp[i] = dp[i - 3] * 2;
	
	if (dp[i] <= dp[i - 4] * 3)
		dp[i] = dp[i - 4] * 3;

    if (dp[i] <= dp[i - 5] * 4)
        dp[i] = dp[i - 5] * 4;
}

Console.WriteLine(dp[n]);