// BOJ_13141


int[][] dp = new int[205][];
List<Tuple<int, int, int>> vertex = new List<Tuple<int, int, int>>();
string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

for (int i = 1; i <= n; i++)
{
    dp[i] = new int[205];
    Array.Fill(dp[i], int.MaxValue / 2);
}

for (int i = 1; i <= n; i++)
    dp[i][i] = 0;

for (int i = 0; i < m; i++)
{
    string[] inputsel = Console.ReadLine().Split(' ');
    int s = int.Parse(inputsel[0]);
    int e = int.Parse(inputsel[1]);
    int l = int.Parse(inputsel[2]);
    dp[s][e] = Math.Min(dp[s][e], l);
    dp[e][s] = Math.Min(dp[e][s], l);
    vertex.Add(new Tuple<int, int, int>(s, e, l));
}

for (int i = 1; i <= n; i++)
    for (int j = 1; j <= n; j++)
        for (int h = 1; h <= n; h++)
            dp[j][h] = Math.Min(dp[j][h], dp[j][i] + dp[i][h]);


double ans = int.MaxValue / 2;
for (int i = 1;i <= n; i++)
{
    double totalTime = 0;
    for (int j = 0; j < m; j++)
    {
        var cur = vertex[j];
        totalTime = Math.Max(totalTime,
            (double)(cur.Item3 + dp[i][cur.Item1] + dp[i][cur.Item2]) / 2);
    }
    ans = Math.Min(ans, totalTime);
}

Console.WriteLine("{0:F1}", Math.Truncate(ans * 100) / 100);