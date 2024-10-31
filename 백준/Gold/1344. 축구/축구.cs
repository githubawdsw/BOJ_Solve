// BOJ_1344


double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

a /= 100;
b /= 100;
int t = 0;
double[,,] dp = new double[20, 20, 20];
dp[0, 0, 0] = 1;
while (t++ < 18)
{
	for (int i = 0; i <= t; i++)
	{
		for (int j = 0; j <= t; j++)
		{
			dp[t, i, j] += dp[t - 1, i, j] * (1 - a) * (1 - b);
			dp[t, i + 1, j] += dp[t - 1, i, j] * a * (1 - b);
			dp[t, i, j + 1] += dp[t - 1, i, j] * (1 - a) * b;
			dp[t, i + 1, j + 1] += dp[t - 1, i, j] * a * b;
		}
	}
}

double ans = 1;
List<int> list = new List<int>() { 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18 };
for (int i = 0; i < list.Count; i++)
{
	for (int j = 0; j < list.Count; j++)
	{
        ans -= dp[18, list[i], list[j]];
    }
}

Console.WriteLine(ans);