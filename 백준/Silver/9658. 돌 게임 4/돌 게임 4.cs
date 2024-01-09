// BOJ_9658


int n = int.Parse(Console.ReadLine());

int[,] dp = new int[1005,3];
dp[1, 0] = 1;
dp[2, 1] = 1;
dp[3, 0] = 1;
dp[4, 1] = 1;
dp[5, 1] = 1;
for (int i = 6; i <= n; i++)
{
    int value = Math.Max(dp[i - 3, 0], dp[i - 4, 0]);
    dp[i, 1] = Math.Max(dp[i - 1, 0], value);
    if (dp[i, 1] == 0)
        dp[i, 0] = 1;
}

if (dp[n,0] == 0)
    Console.WriteLine("SK");
else
    Console.WriteLine("CY");
