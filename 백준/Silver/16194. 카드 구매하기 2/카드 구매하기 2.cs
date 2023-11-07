// BOJ_16194


int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] dp = new int[1005];
for (int i = 1; i <= n; i++)
{
	dp[i] = arr[i - 1];
	for (int j = 1; j < i; j++)
		dp[i] = Math.Min(dp[i], dp[i - j] + dp[j]);
}

Console.WriteLine(dp[n]);
