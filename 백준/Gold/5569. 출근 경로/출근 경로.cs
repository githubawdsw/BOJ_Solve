// BOJ_5569


int[] inputwh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int w = inputwh[0];
int h = inputwh[1];

int[,,,] dp = new int[105, 105, 2, 2];
for (int i = 0; i < w; i++)
{
    dp[0, i, 0, 0] = 1;
}

for (int i = 0; i < h; i++)
{
    dp[i, 0, 1, 0] = 1;
}

for (int i = 1; i < h; i++)
{
    for (int j = 1; j < w; j++)
    {
        dp[i, j, 0, 0] = (dp[i, j - 1, 0, 0] + dp[i, j - 1, 0, 1]) % 100000;
        dp[i, j, 0, 1] = dp[i, j - 1, 1, 0];
        dp[i, j, 1, 0] = (dp[i - 1, j, 1, 0] + dp[i - 1, j, 1, 1]) % 100000;
        dp[i, j, 1, 1] = dp[i - 1, j, 0, 0];
    }
}

Console.WriteLine((dp[h - 1, w - 1, 0, 0] + dp[h - 1, w - 1, 0, 1] + dp[h - 1, w - 1, 1, 0] + dp[h - 1, w - 1, 1, 1]) % 100000);
