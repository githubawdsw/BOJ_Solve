// BOJ_21278


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[][] dp = new int[105][];
for (int i = 1; i <= n; i++)
{
    dp[i] = new int[105];
    Array.Fill(dp[i], int.MaxValue / 2);
    dp[i][i] = 0;
}

for (int i = 0; i < m; i++)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];
    dp[a][b] = 2;
    dp[b][a] = 2;
}

for (int i = 1; i <= n; i++)
    for (int j = 1; j <= n; j++)
        for (int k = 1; k <= n; k++)
            if (dp[j][k] > dp[j][i] + dp[i][k])
                dp[j][k] = dp[j][i] + dp[i][k];

int ans = int.MaxValue;
(int, int) house = (0, 0);
for (int i = 1; i <= n; i++)
{
    for (int j = i + 1; j <= n; j++)
    {
        int min = 0;
        for (int k = 1; k <= n; k++)
        {
            min += Math.Min(dp[i][k], dp[j][k]);
        }
        if(min < ans)
        {
            ans = min;
            house = (i, j);
        }
    }
}
Console.WriteLine($"{house.Item1} {house.Item2} {ans}");