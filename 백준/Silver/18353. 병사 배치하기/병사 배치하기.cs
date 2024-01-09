// BOJ_18353


int n = int.Parse(Console.ReadLine());
int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] dp = new int[2005];

for (int i = 0; i < n; i++)
    dp[i] = 1;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (inputInfo[j] > inputInfo[i])
            dp[i] = Math.Max(dp[j] + 1, dp[i]);
    }
}

int ans = 0;
for (int i = 0; i < n; i++)
{
    ans = Math.Max(dp[i], ans);
}
Console.WriteLine(n - ans);