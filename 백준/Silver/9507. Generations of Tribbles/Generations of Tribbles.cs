// BOJ_9507


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

long[] dp = new long[70];
dp[0] = 1; dp[1] = 1; dp[2] = 2; dp[3] = 4;
for (int i = 4; i <= 67; i++)
{
    dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3] + dp[i - 4];
}

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    sb.AppendLine(dp[n].ToString());
}

Console.WriteLine(sb);
