// BOJ_2229


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] dp = new int[1005];

for (int i = 1; i <= n; i++)
{
	int max = 0;
	int min = 10000;
	for (int j = i - 1; j >= 0; j--)
	{
		max = Math.Max(max, inputArr[j]);
		min = Math.Min(min, inputArr[j]);

		dp[i] = Math.Max(dp[i], dp[j] + (max - min));
	}
}

Console.WriteLine(dp[n]);
