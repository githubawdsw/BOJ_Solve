// BOJ_1326



int n = int.Parse(Console.ReadLine());
string[] bridge = Console.ReadLine().Split(' ');
string[] inputab = Console.ReadLine().Split(' ');
int a = int.Parse(inputab[0]);
int b = int.Parse(inputab[1]);

Queue<(int, int)> q = new Queue<(int, int)>();
int[] board = new int[10005];
bool[] vis = new bool[10005];

for (int i = 1; i <= n; i++)
{
    board[i] = int.Parse(bridge[i - 1]);
}

q.Enqueue((a, 0));
vis[a] = true;

while (q.Count != 0)
{
    var cur = q.Dequeue();
    if (cur.Item1 == b)
    {
        Console.WriteLine(cur.Item2);
        return;
    }

    int jump = board[cur.Item1];
    for (int i = jump; i + cur.Item1 <= n; i += jump)
    {
        int next = cur.Item1 + i;
        if (!vis[next])
        {
            vis[next] = true;
            q.Enqueue((next, cur.Item2 + 1));
        }
    }
    for (int i = jump; cur.Item1 - i >= 1; i += jump)
    {
        int next = cur.Item1 - i;
        if (!vis[next])
        {
            vis[next] = true;
            q.Enqueue((next, cur.Item2 + 1));
        }
    }
}

Console.WriteLine(-1);
