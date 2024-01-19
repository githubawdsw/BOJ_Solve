// BOJ_2624


int t = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
List<(int, int)> list = new List<(int, int)>();
int[] dp = new int[10005];
for (int i = 0; i < k; i++)
{
    int[] inputpn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int p = inputpn[0];
    int n = inputpn[1];
    list.Add((p, n));
}
dp[0] = 1;

for (int i = 0; i < k; i++)
{
    for (int j = t; j > 0; j--)
    {
        int sum = 0;
        for (int x = 0; x < list[i].Item2; x++)
        {
            sum += list[i].Item1;
            if (j - sum >= 0 && dp[j - sum] > 0)
                dp[j] += dp[j - sum];
        }
    }
}

Console.WriteLine(dp[t]);