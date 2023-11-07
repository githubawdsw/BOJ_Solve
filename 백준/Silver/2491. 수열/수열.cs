// BOJ_2491



int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[][] dp = new int[3][];
dp[1] = new int[100005];
Array.Fill(dp[1], 1);
dp[2] = new int[100005];
Array.Fill(dp[2], 1);

for (int i = 1; i < n; i++)
{
    if (arr[i] >= arr[i - 1])
        dp[1][i] = dp[1][i - 1] + 1;

    if (arr[i] <= arr[i - 1])
        dp[2][i] = dp[2][i - 1] + 1;
}

int ans = Math.Max(dp[1].Max(), dp[2].Max());
Console.WriteLine(ans);