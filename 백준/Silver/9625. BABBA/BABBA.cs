// BOJ_9625


int k = int.Parse(Console.ReadLine());

int[,] dp = new int[50, 2];
dp[0, 0] = 1;
for (int i = 1; i <= k; i++)
{
    dp[i, 0] = dp[i - 1, 1];
    dp[i, 1] = dp[i - 1, 1] + dp[i - 1, 0];
}

Console.WriteLine($"{dp[k, 0]} {dp[k, 1]}");
