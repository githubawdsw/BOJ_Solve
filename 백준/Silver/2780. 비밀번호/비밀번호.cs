// BOJ_2780


using System.Text;

StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[,] dp = new int[15, 1005];
    for (int i = 0; i < 10; i++)
    {
        dp[i, 1] = 1;
    }

    int n = int.Parse(Console.ReadLine());

    for (int i = 2; i <= n; i++)
    {
        dp[1, i] = (dp[2, i - 1] + dp[4, i - 1]) % 1234567;
        dp[2, i] = (dp[1, i - 1] + dp[3, i - 1] + dp[5, i - 1]) % 1234567;
        dp[3, i] = (dp[2, i - 1] + dp[6, i - 1]) % 1234567;
        dp[4, i] = (dp[1, i - 1] + dp[5, i - 1] + dp[7, i - 1]) % 1234567;
        dp[5, i] = (dp[2, i - 1] + dp[4, i - 1] + dp[6, i - 1] + dp[8, i - 1]) % 1234567;
        dp[6, i] = (dp[3, i - 1] + dp[5, i - 1] + dp[9, i - 1]) % 1234567;
        dp[7, i] = (dp[4, i - 1] + dp[8, i - 1] + dp[0, i - 1]) % 1234567;
        dp[8, i] = (dp[5, i - 1] + dp[7, i - 1] + dp[9, i - 1]) % 1234567;
        dp[9, i] = (dp[6, i - 1] + dp[8, i - 1]) % 1234567;
        dp[0, i] = (dp[7, i - 1]) % 1234567;
    }

    int ans = 0;
    for (int i = 0; i < 10; i++)
    {
        ans += dp[i, n] % 1234567;
    }
    sb.AppendLine((ans % 1234567).ToString());
}

Console.WriteLine(sb);