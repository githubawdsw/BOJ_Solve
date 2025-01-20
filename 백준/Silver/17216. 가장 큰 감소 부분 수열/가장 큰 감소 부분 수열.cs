// BOJ_17216


int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] dp = new int[1005];

for (int i = 0; i < n; i++)
{
	dp[i] = inputArr[i];
    for (int j = 0; j < i; j++)
	{
		if (inputArr[j] > inputArr[i])
			dp[i] = Math.Max(dp[j] + inputArr[i], dp[i]);
	}
}

Console.WriteLine(dp.Max());

