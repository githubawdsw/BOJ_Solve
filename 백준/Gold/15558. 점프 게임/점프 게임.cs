// BOJ_15558


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

List<string> line = new List<string>
{
    Console.ReadLine(),
    Console.ReadLine()
};

bool[,] vis = new bool[2, 100005];
Queue<(int, int, int)> q = new Queue<(int, int, int)>();
q.Enqueue((0, 0, -1));

while (q.Count > 0)
{
    var cur = q.Dequeue();
    int time = cur.Item3;

    if (cur.Item1 - 1 > 0 && cur.Item1 - 1 > time + 1 
        && line[cur.Item2][cur.Item1 - 1] != '0' && !vis[cur.Item2, cur.Item1 - 1])
    {
        q.Enqueue((cur.Item1 - 1, cur.Item2, time + 1));
        vis[cur.Item2, cur.Item1 - 1] = true;
    }
    if (cur.Item1 + 1 >= n || cur.Item1 + k >= n)
    {
        Console.WriteLine(1);
        return;
    }

    if (cur.Item1 + 1 < n && line[cur.Item2][cur.Item1 + 1] != '0' && !vis[cur.Item2, cur.Item1 + 1])
    {
        q.Enqueue((cur.Item1 + 1, cur.Item2, time + 1));
        vis[cur.Item2, cur.Item1 + 1] = true;
    }

    int change = cur.Item2 == 0 ? 1 : 0;
    if (cur.Item1 + k < n && line[change][cur.Item1 + k] != '0' && !vis[change, cur.Item1 + k])
    {
        q.Enqueue((cur.Item1 + k, change, time + 1));
        vis[change, cur.Item1 + k] = true;
    }
}

Console.WriteLine(0);
