// BOJ_10422


using System.Text;

StringBuilder sb = new StringBuilder();

long[] dp = new long[5005];

dp[0] = 1;
dp[2] = 1;
int t = int.Parse(Console.ReadLine());
for (int i = 4; i < 5001; i += 2)
{
	for (int j = 0; j < i; j += 2)
	{
		dp[i] += (dp[j] * dp[i - j - 2]) % 1000000007;
	}
	dp[i] %= 1000000007;
}

while (t-- > 0)
{
    int l = int.Parse(Console.ReadLine());
	sb.AppendLine((dp[l] % 1000000007).ToString());
}

Console.WriteLine(sb);