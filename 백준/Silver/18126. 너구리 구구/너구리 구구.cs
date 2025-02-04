// BOJ_18126


long[] dis = new long[5005];
List<(int, long)>[] list = new List<(int, long)>[5005];
int n = int.Parse(Console.ReadLine());

if(n == 1)
{
    Console.WriteLine(0);
    return;
}    
for (int i = 0; i < n - 1; i++)
{
    int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputabc[0];
    int b = inputabc[1];
    int c = inputabc[2];

    if (list[a] == null)
        list[a] = new List<(int, long)>();
    list[a].Add((b, c));
    if (list[b] == null)
        list[b] = new List<(int, long)>();
    list[b].Add((a, c));
}

Queue<(int, long)> q = new Queue<(int, long)>();
q.Enqueue((1, 0));
Array.Fill(dis, long.MaxValue);
dis[1] = 0;
long ans = 0;

while (q.Count > 0)
{
    var cur = q.Dequeue();

    foreach (var one in list[cur.Item1])
    {
        if (dis[one.Item1] > one.Item2 + cur.Item2)
        {
            dis[one.Item1] = one.Item2 + cur.Item2;
            q.Enqueue((one.Item1, one.Item2 + cur.Item2));
            ans = Math.Max(one.Item2 + cur.Item2, ans);
        }

    }
}

Console.WriteLine(ans);