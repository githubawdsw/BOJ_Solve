// BOJ_11568


int n = int.Parse(Console.ReadLine());
int[] inputCard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] dp = new int[1005];
Array.Fill(dp, 1);
int ans = 0;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < i; j++)
	{
		if (inputCard[i] > inputCard[j])
			dp[i] = Math.Max(dp[j] + 1, dp[i]);
	}
	ans = Math.Max(ans, dp[i]);
}

Console.WriteLine(ans);