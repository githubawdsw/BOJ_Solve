// BOJ_1106


int[] inputcn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = inputcn[0];
int n = inputcn[1];
List<(int, int)> list = new List<(int, int)>();
int[] dp = new int[100005];
for (int i = 0; i < n; i++)
{
    int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int promotionCost = inputinfo[0];
    int client = inputinfo[1];
    list.Add((promotionCost, client));
}

for (int i = 0; i < n; i++)
{
    for (int j = 1; j <= 100000; j++)
    {
        if (j - list[i].Item1 >= 0)
            dp[j] = Math.Max(dp[j], dp[j - list[i].Item1] + list[i].Item2);
    }
}

for (int i = 0; i <= 100000; i++)
{
    if(dp[i] >= c)
    {
        Console.WriteLine(i);
        return;
    }
}