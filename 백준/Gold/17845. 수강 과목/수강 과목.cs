// BOJ_17845


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

List<(int, int)> list = new();
long[,] dp = new long[1005, 10005];

for (int i = 0; i < k; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int impotance = inputInfo[0];
    int time = inputInfo[1];

    list.Add((impotance, time));
}

for (int i = 1; i <= k; i++)
{
    var cur = list[i - 1].Item2;
    for (int j = 0; j <= n; j++)
    {
        dp[i, j] = dp[i - 1, j];
        if(j - cur >= 0)
        {
            dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - cur] + list[i - 1].Item1);
        }
    }
}

Console.WriteLine(dp[k,n]);