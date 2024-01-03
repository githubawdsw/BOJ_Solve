// BOJ_13398

int n = int.Parse(Console.ReadLine());
int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[,] dp = new int[100005, 2];

for (int i = 0; i <= n; i++)
{
    dp[i, 0] = -1000;
    dp[i, 1] = -1000;
}

int range = 0;
int ans = -1000;
dp[0, 0] = inputinfo[0];
for (int i = 1; i < n; i++)
{
    dp[i, 0] = Math.Max( dp[i - 1, 0] + inputinfo[i] , inputinfo[i]);
    
    dp[i, 1] = Math.Max(dp[i - 1, 0], dp[i - 1, 0] + inputinfo[i]);
    dp[i, 1] = Math.Max(dp[i, 1], dp[i - 1, 1] + inputinfo[i]);
}

for (int i = 0; i < n; i++)
{
    ans = Math.Max(ans, dp[i, 1]);
    ans = Math.Max(ans, dp[i, 0]);
}

Console.WriteLine(ans);
