// BOJ_17396



string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);
string[] aArr = Console.ReadLine().Split(" ");

List<Tuple<int, int>>[] route = new List<Tuple<int, int>>[100005];
long[] dp = new long[100005];
for (int i = 0; i < m; i++)
{
    string[] inputabt = Console.ReadLine().Split(' ');
    int a = int.Parse(inputabt[0]);
    int b = int.Parse(inputabt[1]);
    int t = int.Parse(inputabt[2]);

    if (route[a] == null)
        route[a] = new List<Tuple<int, int>>();
    route[a].Add(new Tuple<int, int>(b, t));
    if (route[b] == null)
        route[b] = new List<Tuple<int, int>>();
    route[b].Add(new Tuple<int, int>(a, t));
}

Array.Fill(dp, long.MaxValue / 2);
dp[0] = 0;
PriorityQueue<Tuple<int, long>, long> pq = new PriorityQueue<Tuple<int, long>, long>();
pq.Enqueue(new Tuple<int, long>(0, dp[0]), 0);

while (pq.Count > 0)
{
    var cur = pq.Dequeue();
    if (dp[cur.Item1] != cur.Item2)
        continue;
    if (route[cur.Item1] == null)
        continue;
    foreach (var one in route[cur.Item1])
    {
        if (aArr[one.Item1] == "1" && one.Item1 != n - 1)
            continue;
        if (dp[one.Item1] > dp[cur.Item1] + one.Item2)
        {
            dp[one.Item1] = dp[cur.Item1] + one.Item2;
            pq.Enqueue(new Tuple<int, long>(one.Item1, dp[one.Item1]), dp[one.Item1]);
        }
    }
}

if (dp[n - 1] == long.MaxValue / 2)
    Console.WriteLine(-1);
else
    Console.WriteLine(dp[n-1] );

