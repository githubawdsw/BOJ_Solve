// BOJ_15991


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

long[] dp = new long[100005];
dp[0] = 1;
dp[1] = 1;
dp[2] = 2;
dp[3] = 2;
dp[4] = 3;
dp[5] = 3;
for (int i = 6; i <= 100000; i++)
{
    dp[i] = (dp[i - 6] + dp[i - 4] + dp[i - 2]) % 1000000009;
}

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    sb.AppendLine(dp[n].ToString());
}

Console.WriteLine(sb);
