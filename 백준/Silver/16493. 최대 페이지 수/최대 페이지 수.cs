// BOJ_16493


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<(int,int)> list = new List<(int,int)> ();
int[,] dp = new int[25, 205];
list.Add((0, 0));
for (int i = 0; i < m; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((inputInfo[0], inputInfo[1]));
}

for (int i = 1; i <= m; i++)
{
    for (int j = 0; j <= n; j++)
    {
        dp[i, j] = dp[i - 1, j];
        var cur = list[i];
        if (cur.Item1 <= j)
            dp[i, j] = Math.Max(cur.Item2 + dp[i - 1, j - cur.Item1], dp[i, j]);
    }
}

Console.WriteLine(dp[m,n]);
