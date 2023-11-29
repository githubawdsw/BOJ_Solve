// BOJ_1162


List<Tuple<long, int, int>>[] tupleList = new List<Tuple<long, int, int>>[10005];

string[] inputnmk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnmk[0]);
int m = int.Parse(inputnmk[1]);
int k  = int.Parse(inputnmk[2]);

for (int i = 0; i < m; i++)
{
    string[] inputroadcost = Console.ReadLine().Split(' ');
    int a = int.Parse(inputroadcost[0]);
    int b = int.Parse(inputroadcost[1]);
    long t = int.Parse(inputroadcost[2]);
    if (tupleList[a] == null)
        tupleList[a] = new List<Tuple<long, int, int>>();
    tupleList[a].Add(new Tuple<long, int, int>(t,0, b));
    tupleList[a].Add(new Tuple<long, int, int>(0,1, b));

    if (tupleList[b] == null)
        tupleList[b] = new List<Tuple<long, int,int>>();
    tupleList[b].Add(new Tuple<long, int, int>(t,0, a));
    tupleList[b].Add(new Tuple<long, int, int>( 0,1, a));
}

long[][] dp = new long[10005][];
for (int i = 0; i <= k; i++)
{
    dp[i] = new long[10005];
    Array.Fill(dp[i], 9223372036854775800);
    dp[i][1] = 0;
}
PriorityQueue<Tuple<long, int, int>, long> pq = new PriorityQueue<Tuple<long, int, int>, long>();
pq.Enqueue(new Tuple<long, int, int>(dp[0][1], 0 , 1), dp[0][1]);
while (pq.Count!= 0)
{
    var cur = pq.Dequeue();
    if (tupleList[cur.Item3] == null)
        continue;
    if (dp[cur.Item2][cur.Item3] != cur.Item1)
        continue;
    foreach (var one in tupleList[cur.Item3])
    {
        long dc = cur.Item1 + one.Item1;
        int dk = cur.Item2 + one.Item2;
        if (dk  > k)
            continue;
        if(dc >= dp[dk][one.Item3])
            continue;
        dp[dk][one.Item3] = dc;
        pq.Enqueue(new Tuple<long, int, int>(dc, dk, one.Item3), dc);
    }
}

long ans = long.MaxValue;
for (int i = 0; i <= k; i++)
    ans = Math.Min(dp[i][n], ans);

Console.WriteLine(ans);