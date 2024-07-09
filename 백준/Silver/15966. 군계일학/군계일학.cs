// BOJ_15966


int n = int.Parse(Console.ReadLine());
int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] dp = new int[1000005];
dp[inputarr[0]] = 1;
int ans = 1;

for (int i = 1; i < n; i++)
{
    if (dp[inputarr[i] - 1] > 0)
        dp[inputarr[i]] = dp[inputarr[i] - 1] + 1;
    else
        dp[inputarr[i]] = 1;

    ans = Math.Max(dp[inputarr[i]], ans);
}

Console.WriteLine(ans);