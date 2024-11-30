// BOJ_17391


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[305, 305];
bool[,] vis = new bool[305, 305];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

Queue<(int, int, int)> q = new Queue<(int, int, int)>();
int[] dx = { 1, 0 };
int[] dy = { 0, 1 };
q.Enqueue((0, 0, 0));
vis[0, 0] = true;
int ans = 0;

while (q.Count > 0)
{
	var cur = q.Dequeue();
    if (cur.Item1 == n - 1 && cur.Item2 == m - 1)
    {
        ans = cur.Item3;
        break;
    }

	for (int i = 0; i < 2; i++)
	{
		for (int j = 1; j <= board[cur.Item1, cur.Item2]; j++)
        {
            int nx = cur.Item1 + dx[i] * j;
            int ny = cur.Item2 + dy[i] * j;

            if (nx < 0 || ny < 0 || nx >= n || ny >= m)
                continue;
            if (vis[nx, ny])
                continue;

            vis[nx, ny] = true;
            q.Enqueue((nx, ny, cur.Item3 + 1));
        }
	}
}

Console.WriteLine(ans);
