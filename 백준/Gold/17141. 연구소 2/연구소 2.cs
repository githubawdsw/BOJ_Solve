// BOJ_17141


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[55, 55];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

List<(int, int)> virus = new List<(int, int)>();
bool[] used = new bool[15];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputInfo[j];
		if (inputInfo[j] == 2)
			virus.Add((i, j));
	}
}

int ans = 2500;
Select(0);

if(ans == 2500)
    Console.WriteLine(-1);
else
	Console.WriteLine(ans - 1);



void Select(int depth)
{
	if(depth == m)
	{
		ans = Math.Min(ans, Bfs());
		return;
	}

	for (int i = depth; i < virus.Count; i++)
	{
		if (used[i])
			continue;

		used[i] = true;
		Select(depth + 1);
		used[i] = false;
	}
}

int Bfs()
{
	Queue<(int, int)> q = new Queue<(int, int)>();
	int[,] dis = new int[55, 55];
	for (int i = 0; i < virus.Count; i++)
	{
		if (used[i])
		{
			q.Enqueue(virus[i]);
			dis[virus[i].Item1, virus[i].Item2] = 1;
		}
	}

	int max = 1;
	while (q.Count > 0)
	{
		var cur = q.Dequeue();
		for (int i = 0; i < 4; i++)
		{
			int nx = cur.Item1 + dx[i];
			int ny = cur.Item2 + dy[i];

			if (nx < 0 || ny < 0 || nx >= n || ny >= n)
				continue;

			if (dis[nx, ny] != 0 || board[nx,ny] == 1)
				continue;

			dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
			max = Math.Max(max, dis[nx, ny]);
			q.Enqueue((nx, ny));
		}
	}

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
			if (dis[i, j] == 0 && board[i,j] != 1)
				return 2500;
        }
    }

    return max;
}