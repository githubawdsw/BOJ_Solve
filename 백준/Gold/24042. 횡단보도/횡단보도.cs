// BOJ_24042

string[] inputnm = Console.ReadLine().Split(' ');
long n = long.Parse(inputnm[0]);
long m  = long.Parse(inputnm[1]);

List<Tuple<long, long>>[] crossTime = new List<Tuple<long, long>>[700005];
for (int i = 1; i <= m; i++)
{
    string[] inputAB = Console.ReadLine().Split(' ');
    long a = long.Parse(inputAB[0]);
    long b = long.Parse(inputAB[1]);
    if (crossTime[a] == null)
        crossTime[a] = new List<Tuple<long, long>>();
    crossTime[a].Add(new Tuple<long, long>(b, i));
    if (crossTime[b] == null)
        crossTime[b] = new List<Tuple<long, long>>();
    crossTime[b].Add(new Tuple<long, long>(a, i));
}


long[] dis = new long[n + 5];
Array.Fill(dis, long.MaxValue - 2);
dis[1] = 0;
PriorityQueue<Tuple<long, long>, long> pq = 
    new PriorityQueue<Tuple<long, long>, long>();
pq.Enqueue(new Tuple<long, long>(1, 0), 0);
while (pq.Count != 0)
{
    var cur = pq.Dequeue();
    long time = cur.Item2;
    if(cur.Item1 == n)
    {
        Console.WriteLine(   time);
        return;
    }
    if (dis[cur.Item1] < time)
        continue;

    foreach (var one in crossTime[cur.Item1])
    {
        long next = one.Item1;
        long nextTime = one.Item2 + m * (time / m);
        while (nextTime <= time)
            nextTime += m;
        if (dis[next] > nextTime )
        {
            dis[next] = nextTime;
            pq.Enqueue(new Tuple<long, long>(next, nextTime) , nextTime);
        }
    }
}
Console.WriteLine(dis[n]);