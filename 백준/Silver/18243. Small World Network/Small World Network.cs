// BOJ_18243


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[][] dp = new int[105][];
for (int i = 1; i <= n; i++)
{
    dp[i] = new int[105];
    Array.Fill(dp[i], int.MaxValue / 2);
    dp[i][i] = 0;
}

for (int i = 0; i < k; i++)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];
    dp[a][b] = 1;
    dp[b][a] = 1;
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        for (int l = 1; l <= n; l++)
        {
            if(dp[j][l] > dp[j][i] + dp[i][l])
                dp[j][l] = dp[j][i] + dp[i][l];
        }
    }
}

int max = 0;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        max = Math.Max(max, dp[i][j]);
    }
    if(max > 6)
    {
        Console.WriteLine("Big World!");
        return;
    }    
}

Console.WriteLine("Small World!");
