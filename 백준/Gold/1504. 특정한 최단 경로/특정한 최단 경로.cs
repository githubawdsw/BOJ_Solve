// BOJ_1504


List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int>>[805];

string[] inputne = Console.ReadLine().Split(' ');
int n = int.Parse(inputne[0]); 
int e = int.Parse(inputne[1]);

for (int i = 1; i <= e; i++)
{
    string[] inputabc = Console.ReadLine().Split(' ');
    int a = int.Parse(inputabc[0]);
    int b = int.Parse(inputabc[1]);
    int c = int.Parse(inputabc[2]);

    if (tupleList[a] == null)
        tupleList[a] = new List<Tuple<int, int>>();
    tupleList[a].Add(new Tuple<int, int>(c, b));

    if (tupleList[b] == null)
        tupleList[b] = new List<Tuple<int, int>>();
    tupleList[b].Add(new Tuple<int, int>(c, a));
}
string[] inputv = Console.ReadLine().Split(' ');
int v1 = int.Parse(inputv[0]);
int v2 = int.Parse(inputv[1]);

int ans1 = 0;
ans1 += solve(1, v1);
ans1 += solve(v1, v2);
ans1 += solve(v2, n);

int ans2 = 0;
ans2 += solve(1, v2);
ans2 += solve(v2, v1);
ans2 += solve(v1, n);

int ans = Math.Min(ans1, ans2);
if(ans >= int.MaxValue / 2 || ans < 0)
{
    Console.WriteLine(  -1);
    return;
}
Console.WriteLine(ans);

int solve(int start, int end)
{
    int[] d = new int[805];
    Array.Fill(d, int.MaxValue /2 -1);

    d[start] = 0;
    PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
    pq.Enqueue(new Tuple<int, int>(d[start], start), d[start]);
    while (pq.Count != 0)
    {
        var cur = pq.Dequeue();
        if (tupleList[cur.Item2] == null)
            continue;
        if (d[cur.Item2] != cur.Item1)
            continue;
        foreach (var one in tupleList[cur.Item2])
        {
            if (d[one.Item2] > d[cur.Item2] + one.Item1)
            {
                d[one.Item2] = d[cur.Item2] + one.Item1;
                pq.Enqueue(new Tuple<int, int>(d[one.Item2], one.Item2), d[one.Item2]);
            }
        }
    }
    return d[end];
}