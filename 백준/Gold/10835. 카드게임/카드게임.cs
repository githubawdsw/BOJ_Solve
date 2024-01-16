// BOJ_10835


int n = int.Parse(Console.ReadLine());
int[] leftDeck = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] rightDeck = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int aMax = leftDeck.Max();
int[,] dp = new int[2005, 2005];

for (int i = n-1; i >= 0; i--)
{
	for (int j = n-1; j >= 0; j--)
	{
		if (leftDeck[i] > rightDeck[j])
			dp[i, j] = dp[i, j + 1] + rightDeck[j];
		else
			dp[i, j] = Math.Max(dp[i + 1, j + 1], dp[i + 1, j]);
	}
}

Console.WriteLine(dp[0,0]);