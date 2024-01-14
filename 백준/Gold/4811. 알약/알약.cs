// BOJ_4811



using System.Text;

StringBuilder sb = new StringBuilder();

long[,] dp = new long[35, 35];
dp[1, 0] = 1;
for (int i = 1; i <= 30; i++)
{
    dp[i, 0] = 1;
    for (int j = 1; j <= i; j++)
    {
        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
    }
}

while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0)
        break;
    sb.AppendLine(dp[n, n].ToString());
}

Console.WriteLine(sb);