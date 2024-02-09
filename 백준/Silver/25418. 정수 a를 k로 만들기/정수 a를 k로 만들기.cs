// BOJ_25418


int[] inputak = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputak[0];
int k = inputak[1];

int[] dp = new int[1000005];
for (int i = a; i <= k; i++)
{
    dp[i] = int.MaxValue / 2;
}
dp[a] = 0;

for (int i = a; i <= 1000000; i++)
{
    if (dp[k] != int.MaxValue / 2)
        break;

    dp[i + 1] = Math.Min(dp[i] + 1, dp[i + 1]);
    if(i * 2 <= 1000000)
        dp[i * 2] = Math.Min(dp[i] + 1, dp[i * 2]);
}

Console.WriteLine(dp[k]);