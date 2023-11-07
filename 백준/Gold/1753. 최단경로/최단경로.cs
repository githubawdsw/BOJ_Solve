
string[] inputve = Console.ReadLine().Split(' ');
int V = int.Parse(inputve[0]); 
int E = int.Parse(inputve[1]);
int start = int.Parse(Console.ReadLine());

List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int>>[20005];
int[] d = new int[20005];

Array.Fill(d, int.MaxValue / 2);
while (E-- > 0)
{
    string[] inputuvw = Console.ReadLine().Split(' ');
    int u = int.Parse(inputuvw[0]);
    int v = int.Parse(inputuvw[1]);
    int w = int.Parse(inputuvw[2]);
    if (tupleList[u] == null)
        tupleList[u] = new List<Tuple<int, int>>();
    tupleList[u].Add(new Tuple<int, int>(w, v));
}
d[start] = 0;
PriorityQueue<Tuple<int, int>, Tuple<int, int>> pq = 
    new PriorityQueue<Tuple<int, int>, Tuple<int, int>>();
pq.Enqueue(new Tuple<int, int>(d[start] , start), new Tuple<int, int>(d[start], start));
while (pq.Count > 0)
{
    var  top = pq.Dequeue();
    if (tupleList[top.Item2] == null)
        continue;
    if (d[top.Item2] != top.Item1)
        continue;
    foreach (var one in tupleList[top.Item2])
    {
        if (d[one.Item2] <= d[top.Item2] + one.Item1)
            continue;
        d[one.Item2] = d[top.Item2] + one.Item1;
        pq.Enqueue(new Tuple<int, int>(d[one.Item2], one.Item2), new Tuple<int, int>(d[one.Item2], one.Item2));
    }
}
for (int i = 1; i <= V; i++)
{
    if (d[i] == int.MaxValue/2)
        Console.WriteLine( "INF" );
    else
        Console.WriteLine(d[i]);
}
