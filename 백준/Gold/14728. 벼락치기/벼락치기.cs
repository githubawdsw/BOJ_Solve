// BOJ_14728


int[] inputnt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnt[0];
int t = inputnt[1];

List<(int, int)> list = new List<(int, int)>();
int[,] dp = new int[105, 10005];
for (int i = 0; i < n; i++)
{
    int[] inputks = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int k = inputks[0];
    int s = inputks[1];

    list.Add((k, s));
}

for (int i = 1; i <= n; i++)
{
    var cur = list[i - 1].Item1;
    for (int j = 0; j <= t; j++)
    {
        if(j >= cur)
            dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - cur] + list[i - 1].Item2);
        else
            dp[i, j] = dp[i - 1, j];
    }
}

Console.WriteLine(dp[n,t]);
