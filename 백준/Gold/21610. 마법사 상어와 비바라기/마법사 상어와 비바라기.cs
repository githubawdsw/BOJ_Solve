// BOJ_21610


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[55, 55];
Dictionary<(int, int), bool> used = new Dictionary<(int, int), bool>();
int[] dx = { 0, -1, -1, -1, 0, 1, 1, 1 };
int[] dy = { -1, -1, 0, 1, 1, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] waterInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < n; j++)
	{
        board[i, j] = waterInfo[j];
        used.Add((i, j), false);
	}
}
q.Enqueue((n - 1, 0));
q.Enqueue((n - 2, 0));
q.Enqueue((n - 1, 1));
q.Enqueue((n - 2, 1));

for (int i = 0; i < m; i++)
{
    int[] inputds = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int d = inputds[0];
    int s = inputds[1];

    Move(d - 1, s);


}

int ans = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        ans += board[i, j];
    }
}

Console.WriteLine(ans);


void Move(int dir, int dis)
{
    while (q.Count > 0)
    {
        var cur = q.Dequeue();

        int nx = cur.Item1 + dx[dir] * (dis % n);
        int ny = cur.Item2 + dy[dir] * (dis % n);

        if (nx < 0) nx += n;
        if (nx >= n) nx -= n; 
        if (ny < 0) ny += n;
        if (ny >= n) ny -= n;

        used[(nx, ny)] = true;
        board[nx, ny]++;
    }

    foreach (var one in used)
    {
        if (!used[(one.Key.Item1, one.Key.Item2)])
            continue;
        int count = 0;
        for (int i = 1; i < 8; i += 2)
        {
            int nx = one.Key.Item1 + dx[i];
            int ny = one.Key.Item2 + dy[i];
            if (nx < 0 || ny < 0 || nx >= n || ny >= n)
                continue;
            if (board[nx, ny] == 0)
                continue;
            count++;
        }
        board[one.Key.Item1, one.Key.Item2] += count;
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (board[i, j] > 1 && used[(i, j)] == false)
            {
                q.Enqueue((i, j));
                board[i, j] -= 2;
            }
            else if (used[(i, j)] == true)
                used[(i, j)] = false;
        }
    }
}