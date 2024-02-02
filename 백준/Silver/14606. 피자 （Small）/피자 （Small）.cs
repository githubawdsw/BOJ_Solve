// BOJ_14606


int n = int.Parse(Console.ReadLine());


int[] dp = new int[15];
dp[2] = 1;
for (int i = 3; i <= n; i++)
{
    dp[i] = (i / 2) * (i - (i / 2));
    dp[i] += dp[i / 2] + dp[i - (i / 2)];
}

Console.WriteLine(dp[n]);