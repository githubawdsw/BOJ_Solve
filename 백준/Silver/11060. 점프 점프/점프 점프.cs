// BOJ_1743



int n = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');
int[] arr = new int[1005];
int[] dp = new int[1005];

for (int i = 0; i < n; i++)
    arr[i] = int.Parse(inputarr[i]);
Array.Fill(dp, int.MaxValue/2);
dp[0] = 0;

for (int i = 0; i < n-1; i++)
{
    if (dp[i] == int.MaxValue / 2)
        continue;
    int val = arr[i];
    for (int j = 1; j <= val; j++)
    {
        if (i + j >= n)
            continue;
        dp[i + j] = Math.Min(dp[i] + 1, dp[i + j]);
    }
}

if (dp[n - 1] == int.MaxValue/2)
    dp[n - 1] = -1;
Console.WriteLine(dp[n-1]);
