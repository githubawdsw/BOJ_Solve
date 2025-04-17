// BOJ_12785


int[] inputwh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int w = inputwh[0];
int h = inputwh[1];

int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int x = inputxy[0];
int y = inputxy[1];

long[,] dp = new long[205, 205];
for (int i = 1; i <= x; i++)
{
    dp[i, 1] = 1;
}

for (int i = 1; i <= y; i++)
{
    dp[1, i] = 1;
}

for (int i = 2; i <= x; i++)
{
    for (int j = 2; j <= y; j++)
    {
        dp[i, j] = (dp[i, j - 1] + dp[i - 1, j]) % 1000007;
    }
}

for (int i = x; i <= w; i++)
{
    dp[i, y] = dp[x, y];
}

for (int i = y; i <= h; i++)
{
    dp[x, i] = dp[x, y];
}

for (int i = x + 1; i <= w; i++)
{
    for (int j = y + 1; j <= h; j++)
    {
        dp[i, j] = (dp[i, j - 1] + dp[i - 1, j]) % 1000007;
    }
}

Console.WriteLine(dp[w,h]);