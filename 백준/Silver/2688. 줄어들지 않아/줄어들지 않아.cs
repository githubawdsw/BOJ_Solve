// BOJ_2688


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
long[,] dp = new long[70,15];
for (int i = 0; i < 10; i++)
    dp[1, i] = 1;
for (int i = 2; i < 65; i++)
{
    for (int j = 0; j < 10; j++)
    {
        long sum = 0;
        for (int k = j; k < 10; k++)
            sum += dp[i - 1, k];
        dp[i, j] = sum;
    }
}

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    long ans = 0;
    for (int i = 0;i < 10; i++)
        ans += dp[n, i];
    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);
