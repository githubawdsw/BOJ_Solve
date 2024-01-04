// BOJ_17404


int n = int.Parse(Console.ReadLine());
int[,] infoArr = new int[3, 1005];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    infoArr[0, i] = inputInfo[0];
    infoArr[1, i] = inputInfo[1];
    infoArr[2, i] = inputInfo[2];
}

int[,] dp = new int[3, 1005];
int ans = int.MaxValue;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
        dp[j, 0] = int.MaxValue / 2;
    dp[i, 0] = infoArr[i, 0];

    for (int j = 1; j < n; j++)
    {
        dp[0, j] = Math.Min(dp[1, j - 1], dp[2, j - 1]) + infoArr[0, j];
        dp[1, j] = Math.Min(dp[0, j - 1], dp[2, j - 1]) + infoArr[1, j];
        dp[2, j] = Math.Min(dp[1, j - 1], dp[0, j - 1]) + infoArr[2, j];
    }

    for (int j = 0; j < 3; j++)
    {
        if (i == j)
            continue;
        ans = Math.Min(dp[j, n - 1], ans);
    }
}

Console.WriteLine(ans);
