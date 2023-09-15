// BOJ_10211


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] dp = new int[1005];
    int n = int.Parse(Console.ReadLine());
    string[] inputarr = Console.ReadLine().Split(' ');

    for (int i = 1; i <= n; i++)
        dp[i] = dp[i - 1] + int.Parse(inputarr[i - 1]);

    int ans = -20000000;
    for (int i = 1; i <= n; i++)
        ans = Math.Max(ans, dp[i]);
    
    for (int i = 1; i <= n; i++)
        for (int j = i + 1; j <= n; j++)
            ans = Math.Max(ans, dp[j] - dp[i]);

    sb.AppendLine(ans.ToString());
}

Console.WriteLine(  sb);
