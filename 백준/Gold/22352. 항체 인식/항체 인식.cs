// BOJ_22352


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] before = new int[35, 35];
int[,] after = new int[35, 35];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
int be = 35;
int af = 35;

for (int i = 0; i < n; i++)
{
    int[] inputBeforeInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        before[i,j] = inputBeforeInfo[j];
	}
}

for (int i = 0; i < n; i++)
{
    int[] inputAfterInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
    {
        after[i, j] = inputAfterInfo[j];
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (before[i,j] != after[i, j])
        {
            q.Enqueue((i, j));
            be = before[i, j];
            af = after[i, j];
            before[i, j] = af;
            break;
        }
    }
    if (be != 35 || af != 35)
        break;
}

while (q.Count > 0)
{
    var cur = q.Dequeue();
    for (int i = 0; i < 4; i++)
    {
        int nx = cur.Item1 + dx[i];
        int ny = cur.Item2 + dy[i];

        if (nx < 0 || ny < 0 || nx >= n || ny >= m)
            continue;
        if (before[nx, ny] != be)
            continue;

        q.Enqueue((nx, ny));
        before[nx, ny] = af;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (before[i, j] != after[i, j])
        {
            Console.WriteLine("NO");
            return;
        }
    }
}

Console.WriteLine("YES");