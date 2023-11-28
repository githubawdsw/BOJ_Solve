// BOJ_20183


List<Tuple<long, long>>[] list = new List<Tuple<long, long>>[500005];

string[] inputnmabc = Console.ReadLine().Split(' ');
long n = long.Parse(inputnmabc[0]);
long m = long.Parse(inputnmabc[1]);
long a = long.Parse(inputnmabc[2]);
long b = long.Parse(inputnmabc[3]);
long c = long.Parse(inputnmabc[4]);

long low = 1, high = 0;

for (int i = 0; i < m; i++)
{
    string[] inputuvc = Console.ReadLine().Split(' ');
    long p1 = long.Parse(inputuvc[0]);
    long p2 = long.Parse(inputuvc[1]);
    long cost = long.Parse(inputuvc[2]);
    if (list[p1] == null)
        list[p1] = new List<Tuple<long, long>>();
    list[p1].Add(new Tuple<long, long>(cost, p2));

    if (list[p2] == null)
        list[p2] = new List<Tuple<long, long>>();
    list[p2].Add(new Tuple<long, long>(cost, p1));
    high = Math.Max(high, cost);
}



while (low < high)
{
    long mid = (low + high) / 2;
    if (solve(mid))
        high = mid;
    else
        low = mid + 1;
}
if (solve(low))
    Console.WriteLine(  low);
else
    Console.WriteLine(  -1);
bool solve(long temp)
{
    long[] dp = new long[500005];
    Array.Fill(dp, long.MaxValue / 2);
    dp[a] = 0;

    PriorityQueue<Tuple<long, long>, long> pq = new PriorityQueue<Tuple<long, long>, long>();
    pq.Enqueue(new Tuple<long, long>(0, a) , 0);
    while (pq.Count != 0)
    {
        var cur = pq.Dequeue();
        if (dp[cur.Item2] != cur.Item1)
            continue;
        if (list[cur.Item2] == null)
            continue;
        foreach (var one in list[cur.Item2])
        {
            if (one.Item1 > temp)
                continue;
            if (dp[one.Item2] > one.Item1 + cur.Item1)
            {
                dp[one.Item2] = one.Item1 + cur.Item1;
                pq.Enqueue(new Tuple<long, long>(dp[one.Item2], one.Item2), dp[one.Item2]);
            }
        }
    }
    if (dp[b] > c)
        return false;
    return true;
}
