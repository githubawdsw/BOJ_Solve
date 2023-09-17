// BOJ_2775



using System.Text;

StringBuilder sb=  new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int k = int.Parse(Console.ReadLine());  
    int n = int.Parse(Console.ReadLine());
    int[,] dp = new int[15, 15];
    for (int i = 1; i <= n; i++)
        dp[0, i] = i;

    for (int i = 1; i <= k; i++)
        for (int j = 1; j <= n; j++)
            for (int h = 1; h <= j; h++)
                dp[i, j] += dp[i - 1, h];
    sb.AppendLine(dp[k, n].ToString());
}
Console.WriteLine(  sb);

