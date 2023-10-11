// BOJ_1446


string[] inputnd = Console.ReadLine().Split(' ');
int n = int.Parse(inputnd[0]);
int d = int.Parse(inputnd[1]);

List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int>>[10005];

for (int i = 0; i < n; i++)
{
    string[] inputsel = Console.ReadLine().Split(' ');
    int s = int.Parse(inputsel[0]);
    int e = int.Parse(inputsel[1]);
    int l = int.Parse(inputsel[2]);

    if(e <= d)
    {
        if (tupleList[e] == null)
            tupleList[e] = new List<Tuple<int, int>>();
        tupleList[e].Add(new Tuple<int, int>((e- s < l) ? e-s : l , s));
    }
}

int[] dp = new int[10005];
dp[0] = 0;
for (int i = 1; i <= d; i++)
{
    dp[i] = dp[i-1] + 1;
    if (tupleList[i] != null)
        foreach (var one in tupleList[i])
            dp[i] = Math.Min(dp[i], one.Item1 + dp[one.Item2]);
    
}

Console.WriteLine(dp[d]);