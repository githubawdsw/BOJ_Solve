// BOJ_15989


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

int[,] dp = new int[10005, 4];
for (int i = 0; i <= 10000; i++)
{
    dp[i, 1] = 1;
}

dp[2, 2] = 1;
dp[3, 2] = 1;
dp[3, 3] = 1;

for (int i = 4; i <= 10000; i++)
{
    dp[i, 2] = dp[i - 2, 1] + dp[i - 2, 2];
    dp[i, 3] = dp[i - 3, 1] + dp[i - 3, 2] + dp[i - 3, 3];
}

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    sb.AppendLine($"{dp[n, 1] + dp[n, 2] + dp[n, 3]}");
}

Console.WriteLine(sb);