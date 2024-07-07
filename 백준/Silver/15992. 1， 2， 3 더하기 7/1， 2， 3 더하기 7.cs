// BOJ_15992


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

long[,] dp = new long[1005, 1005];
dp[1, 1] = 1;
dp[2, 1] = 1;
dp[2, 2] = 1;
dp[3, 1] = 1;
dp[3, 2] = 2;
dp[3, 3] = 1;

for (int i = 4; i <= 1000; i++)
{
    for (int j = 1; j <= 1000; j++)
    {
        dp[i, j] = (dp[i - 1, j - 1] + dp[i - 2, j - 1] + dp[i - 3, j - 1]) % 1000000009;
    }
}

while (t-- > 0)
{
    int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnm[0];
    int m = inputnm[1];

    sb.AppendLine(dp[n, m].ToString());
}

Console.WriteLine(sb);
