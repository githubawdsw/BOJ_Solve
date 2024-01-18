// BOJ_1958


string str1 = Console.ReadLine();
string str2 = Console.ReadLine();   
string str3 = Console.ReadLine();

int[,,] dp = new int[105, 105, 105];
for (int i = 1; i <= str1.Length; i++)
{
	for (int j = 1; j <= str2.Length; j++)
	{
		for (int k = 1; k <= str3.Length; k++)
		{
			if (str1[i - 1] == str2[j - 1] && str2[j - 1] == str3[k - 1])
				dp[i, j, k] = dp[i - 1, j - 1, k - 1] + 1;
			else
			{
				dp[i, j, k] = Math.Max(dp[i - 1, j, k], dp[i, j - 1, k]);
				dp[i, j, k] = Math.Max(dp[i, j, k], dp[i, j, k - 1]);
            }
        }
	}
}

Console.WriteLine(dp[str1.Length, str2.Length, str3.Length]);