// BOJ_14716


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[255, 255];
bool[,] vis = new bool[255, 255];
int[] dx = { 1, 0, -1, 0, 1, 1, -1, -1 };
int[] dy = { 0, 1, 0, -1, 1, -1, 1, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();

for (int i = 0; i < n; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

int ans = 0;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		if (board[i, j] == 0 || vis[i, j])
			continue;

		q.Enqueue((i, j));
		while (q.Count > 0)
		{
			var cur = q.Dequeue();
			for (int k = 0; k < 8; k++)
			{
				int nx = cur.Item1 + dx[k];
				int ny = cur.Item2 + dy[k];

				if (nx < 0 || ny < 0 || nx >= n || ny >= m)
					continue;
				if (board[nx, ny] == 0 || vis[nx, ny])
					continue;

				vis[nx, ny] = true;
				q.Enqueue((nx, ny));
			}
		}
		ans++;
	}
}

Console.WriteLine(ans);