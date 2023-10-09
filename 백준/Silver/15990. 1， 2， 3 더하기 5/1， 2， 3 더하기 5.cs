// BOJ_15990



using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

long[,] dp = new long[100005, 4];
dp[1, 1] = 1;
dp[2, 2] = 1;
dp[3, 1] = dp[3, 2] = dp[3, 3] = 1;
for (int i = 4; i <= 100000; i++)
{
    dp[i, 1] = (dp[i - 1, 2] + dp[i - 1, 3]) % 1000000009;
    dp[i, 2] = (dp[i - 2, 1] + dp[i - 2, 3]) % 1000000009;
    dp[i, 3] = (dp[i - 3, 1] + dp[i - 3, 2]) % 1000000009;
}

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    sb.AppendLine(((dp[n, 1] + dp[n, 2] + dp[n, 3]) % 1000000009).ToString()) ;
}

Console.WriteLine(  sb );
