// BOJ_1374


PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
List<Tuple<int, int>> list = new List<Tuple<int, int>>();
int n = int.Parse(Console.ReadLine());
int ans = 1;
for (int i = 0; i < n; i++)
{
    int[] inputinfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add(new Tuple<int, int>(inputinfo[1], inputinfo[2]));
}

list = list.OrderBy(x => x.Item1).ThenBy(x=>x.Item2).ToList();
for (int i = 0; i < n; i++)
{
    var cur = list[i];

    while (pq.Count != 0 && pq.Peek().Item1 <= cur.Item1)
        pq.Dequeue();

    pq.Enqueue(new Tuple<int, int>(cur.Item2, cur.Item1), cur.Item2);
    ans = Math.Max(ans, pq.Count);
}

Console.WriteLine(ans);

