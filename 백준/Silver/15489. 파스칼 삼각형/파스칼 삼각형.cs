// BOJ_15489



int[] inputrcw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrcw[0];
int c = inputrcw[1];
int w = inputrcw[2];

int[,] dp = new int[35, 35];
for (int i = 1; i <= 31; i++)
{
	dp[i, 1] = 1;
	dp[i, i] = 1;
}

for (int i = 3; i <= 31; i++)
{
	for (int j = 2; j < i; j++)
	{
		dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
	}
}

int ans = 0;
for (int i = r; i < r + w; i++)
{
	for (int j = c; j <= i - r + c; j++)
	{
		ans += dp[i, j];
	}
}
Console.WriteLine(ans);
