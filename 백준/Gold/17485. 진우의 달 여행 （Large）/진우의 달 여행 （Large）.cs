// BOJ_17485


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[1005, 1005];
int[,,] dp = new int[1005, 1005, 5];
for (int i = 0; i < n; i++)
{
    int[] inputFuel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
    {
        board[i,j] = inputFuel[j];
        dp[i, j, 1] = int.MaxValue / 2;
        dp[i, j, 2] = int.MaxValue / 2;
        dp[i, j, 3] = int.MaxValue / 2;
    }
}

for (int i = 0; i < m; i++)
{
    dp[n - 1, i, 1] = board[n - 1, i];
    dp[n - 1, i, 2] = board[n - 1, i];
    dp[n - 1, i, 3] = board[n - 1, i];
}

for (int i = n - 2; i >= 0; i--)
{
    for (int j = 0; j < m; j++)
    {
        if(j - 1 >= 0)
            dp[i, j, 1] = Math.Min(dp[i + 1, j - 1, 2], dp[i + 1, j - 1, 3]) + board[i, j];
        if (j + 1 < m)
            dp[i, j, 3] = Math.Min(dp[i + 1, j + 1, 2], dp[i + 1, j + 1, 1]) + board[i, j];
        dp[i, j, 2] = Math.Min(dp[i + 1, j, 1], dp[i + 1, j, 3]) + board[i, j];
    }
}

int ans = int.MaxValue;
for (int i = 0; i < m; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        ans = Math.Min(dp[0, i, j], ans);
    }
}


Console.WriteLine(ans);
