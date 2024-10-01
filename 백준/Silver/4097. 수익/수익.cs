// BOJ_4097


using System.Text;

StringBuilder sb = new StringBuilder();

while (true)
{
    int n = int.Parse(Console.ReadLine());

    if (n == 0)
    {
        Console.WriteLine(sb);
        return;
    }

    int[] dp = new int[250005];
    Array.Fill(dp, -10000);
    dp[0] = int.Parse(Console.ReadLine());
    int answer = -10000;
    for (int i = 1; i < n; i++)
    {
        int p = int.Parse(Console.ReadLine());
        dp[i] = Math.Max(dp[i], p);
        dp[i] = Math.Max(dp[i - 1] + p, dp[i]);
        answer = Math.Max(dp[i], answer);
    }
    sb.AppendLine(answer.ToString());
}
