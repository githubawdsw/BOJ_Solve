// BOJ_1577


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
Dictionary<(int, int), HashSet<(int, int)>> dict = new Dictionary<(int, int), HashSet<(int, int)>>();
long[,] dp = new long[105, 105];

int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    int[] inputWork = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputWork[0];
    int b = inputWork[1];
    int c = inputWork[2];
    int d = inputWork[3];
    if (a + b < c + d)
    {
        if (!dict.ContainsKey((a, b)))
            dict.Add((a, b), new HashSet<(int, int)>());
        dict[(a, b)].Add((c, d));
    }
    else
    {
        if (!dict.ContainsKey((c, d)))
            dict.Add((c, d), new HashSet<(int, int)>());
        dict[(c, d)].Add((a, b));
    }
}

for (int i = 0; i <= n; i++)
{
    dp[i, 0] = 1;
    if (dict.ContainsKey((i, 0)) && dict[(i, 0)].Contains((i + 1, 0)))
        break;
}
for (int i = 0; i <= m; i++)
{
    dp[0, i] = 1;
    if (dict.ContainsKey((0, i)) && dict[(0, i)].Contains((0, i + 1)))
        break;
}
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= m; j++)
    {
        if (!dict.ContainsKey((i - 1, j)) || !dict[(i - 1, j)].Contains((i, j)))
            dp[i, j] += dp[i - 1, j];
        if (!dict.ContainsKey((i, j - 1)) || !dict[(i, j - 1)].Contains((i, j)))
            dp[i, j] += dp[i, j - 1];

    }
}


Console.WriteLine(dp[n, m]);