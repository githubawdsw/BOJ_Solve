// BOJ_4781


using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    double[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
    int n = (int)inputnm[0];
    int m = (int)(inputnm[1] * 100 + 0.5);

    if (n == 0 && m == 0)
        break;

    int[] dp = new int[10005];

    for (int i = 0; i < n; i++)
    {
        double[] inputcp = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        int c = (int)inputcp[0];
        int p = (int)(inputcp[1] * 100 + 0.5);

        if (p > m)
            continue;

        for (int j = p; j <= m; j++)
        {
            dp[j] = Math.Max (dp[j] ,dp[j - p] + c);
        }
    }

    sb.AppendLine(dp[m].ToString());
}

Console.WriteLine(sb);