// BOJ_22342


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = inputnm[0];
int n = inputnm[1];

int[,] board = new int[2005, 2005];
int[,] dp = new int[2005, 2005];
int ans = 0;

for (int i = 1; i <= m; i++)
{
    string inputWeight = Console.ReadLine();
    for (int j = 1; j <= n; j++)
	{
        board[i, j] = inputWeight[j - 1] - '0';
	}
}

for (int j = 1; j <= n; j++)
{
    for (int i = 1; i <= m; i++)
    {
        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - 1] + board[i, j]);
        dp[i, j] = Math.Max(dp[i, j], dp[i, j - 1] + board[i, j]);
        dp[i, j] = Math.Max(dp[i, j], dp[i + 1, j - 1] + board[i, j]);
    }
}

for (int i = 1; i <= m; i++)
{
    ans = Math.Max(dp[i, n - 1], ans);
}

Console.WriteLine(ans);
