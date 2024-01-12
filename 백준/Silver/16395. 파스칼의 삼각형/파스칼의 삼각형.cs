// BOJ_16395


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];
int[,] dp = new int[35, 35];
for (int i = 1; i <= n; i++)
{
    dp[i, i] = 1;
    dp[i, 1] = 1;
}

for (int i = 3; i <= n; i++)
{
    for (int j = 2; j < i; j++)
    {
        dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
    }
}

Console.WriteLine(dp[n,k]);
