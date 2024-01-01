// BOJ_1245


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[105,75];
bool[,] vis = new bool[105, 75];
int[] dx = { 1, 0, -1, 0, 1, 1, -1, -1 };
int[] dy = { 0, 1, 0, -1, 1, -1, 1, -1 };
int maxHeight = 0;
Queue<(int,int)> q = new Queue<(int,int)> ();
for (int i = 0; i < n; i++)
{
	int[] inputinfo = Array.ConvertAll( Console.ReadLine().Split(),int.Parse);
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputinfo[j];
		if (maxHeight < board[i, j])
			maxHeight = board[i, j];
	}
}

int ans = 0;
while (maxHeight > 0)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (vis[i, j])
				continue;

			if (board[i, j] == maxHeight)
			{
				vis[i, j] = true;
				q.Enqueue((i, j));
				Bfs(i, j);
			}
		}
	}
	maxHeight--;
}

Console.WriteLine(ans);


void Bfs(int x, int y)
{
	while (q.Count > 0)
	{
		var cur = q.Dequeue();
		for (int i = 0; i < 8; i++)
		{
			int nx = dx[i] + cur.Item1;
			int ny = dy[i] + cur.Item2;
			if (nx < 0 || ny < 0 || nx >= n || ny >= m)
				continue;
			if (vis[nx,ny])
				continue;

			if (board[nx,ny] <= board[cur.Item1, cur.Item2])
			{
				vis[nx, ny] = true;
				q.Enqueue((nx, ny));
			}
		}
	}
	ans++;
}

	