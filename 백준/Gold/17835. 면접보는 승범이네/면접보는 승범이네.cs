// BOJ_17835

List<Tuple<int, int>>[] list = new List<Tuple<int, int>>[100005];

string[] inputnmk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnmk[0]);
int m = int.Parse(inputnmk[1]);
int k = int.Parse(inputnmk[2]);

for (int i = 0; i < m; i++)
{
    string[] inputuvc = Console.ReadLine().Split(' ');
    int u = int.Parse(inputuvc[0]);
    int v = int.Parse(inputuvc[1]);
    int c = int.Parse(inputuvc[2]);
    if (list[v] == null)
        list[v] = new List<Tuple<int, int>>();
    list[v].Add(new Tuple<int, int>(c, u));
}

long[] dp = new long[100005];
Array.Fill(dp, long.MaxValue / 2);

string[] inputend = Console.ReadLine().Split(' ');

PriorityQueue<Tuple<long, int>, long> pq = new PriorityQueue<Tuple<long, int>, long>();
Tuple<int, long> ans = new Tuple< int, long>(1, 0);

for (int i = 0; i < k; i++)
{
    int end = int.Parse(inputend[i]);
    dp[end] = 0;
    pq.Enqueue(new Tuple<long, int>(dp[end], end), dp[end]);
}

while (pq.Count != 0)
{
    var cur = pq.Dequeue();
    if (list[cur.Item2] == null)
        continue;
    if (dp[cur.Item2] != cur.Item1)
        continue;
    foreach (var one in list[ cur.Item2])
    {
        if (dp[one.Item2] > dp[cur.Item2] + one.Item1)
        {
            dp[one.Item2] = dp[cur.Item2] + one.Item1;
            pq.Enqueue(new Tuple<long, int>(dp[one.Item2], one.Item2), dp[one.Item2]);
        }
    }
}
int idx = 0; long max = 0;
for (int i = 1; i <= n; i++)
{
    if( max < dp[i])
    {
        idx = i;
        max = dp[i];
    }
}

Console.WriteLine(idx);

Console.WriteLine( max);
