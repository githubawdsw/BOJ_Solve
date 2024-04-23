// BOJ_2157


int[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmk[0];
int m = inputnmk[1];
int k = inputnmk[2];

Dictionary<int, int>[] dict = new Dictionary<int, int>[305];
Queue<(int, int)> q = new Queue<(int, int)>();
int[,] dp = new int[305, 305];

for (int i = 0; i < k; i++)
{
    int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputabc[0];
    int b = inputabc[1];
    int c = inputabc[2];
    if (a > b)
        continue;

    if (dict[a] == null)
        dict[a] = new Dictionary<int, int>();

    if (!dict[a].ContainsKey(b))
        dict[a][b] = c;
    else
    {
        if (c > dict[a][b])
            dict[a][b] = c;
    }
}

q.Enqueue((1, 1));
while (q.Count > 0) 
{
    var i = q.Dequeue();
    if (dict[i.Item1] == null)
        continue;
    foreach (var one in dict[i.Item1])
    {
        if (dp[one.Key,i.Item2 + 1] < dp[i.Item1, i.Item2] + one.Value && i.Item2 + 1 <= m)
        {
            dp[one.Key, i.Item2 + 1] = dp[i.Item1, i.Item2] + one.Value;
            q.Enqueue((one.Key, i.Item2 + 1));
        }
    }
}

int ans = 0;
for (int i = 0; i <= m; i++)
{
    ans = Math.Max(dp[n, i], ans);
}
Console.WriteLine(ans);