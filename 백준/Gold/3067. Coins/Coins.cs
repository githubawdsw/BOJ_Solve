// BOJ_3067


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] coinInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int goal = int.Parse(Console.ReadLine());

    int[] dp = new int[10005];
    dp[0] = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = coinInfo[i]; j <= goal; j++)
        {
            dp[j] += dp[j - coinInfo[i]];
        }
    }
    sb.AppendLine(dp[goal].ToString());
}

Console.WriteLine(sb);
