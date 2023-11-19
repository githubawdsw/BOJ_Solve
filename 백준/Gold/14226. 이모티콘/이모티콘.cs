//BOJ_14226


int s = int.Parse(Console.ReadLine());

Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
q.Enqueue(new Tuple<int, int>(1 , 0));
int[,] vis = new int[1005, 1005];

while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (cur.Item1 == 0)
        continue;
    if (cur.Item1 == s)
    {
        Console.WriteLine(vis[cur.Item1,cur.Item2] );
        return;
    }

    if (vis[cur.Item1, cur.Item1] == 0)
    {
        q.Enqueue(new Tuple<int, int>( cur.Item1, cur.Item1));
        vis[cur.Item1, cur.Item1] = vis[cur.Item1, cur.Item2] + 1;
    }
    if (cur.Item1 + cur.Item2 <= s && vis[cur.Item1 + cur.Item2, cur.Item2] == 0)
    {
        q.Enqueue(new Tuple<int, int>( cur.Item1 + cur.Item2 , cur.Item2));
        vis[cur.Item1 + cur.Item2, cur.Item2] = vis[cur.Item1, cur.Item2] + 1;
    }
    if (cur.Item1 > 0 && vis[cur.Item1 - 1, cur.Item2] == 0)
    {
        q.Enqueue(new Tuple<int, int>( cur.Item1 - 1 , cur.Item2));
        vis[cur.Item1 - 1, cur.Item2] = vis[cur.Item1, cur.Item2] + 1;
    }
    
}
