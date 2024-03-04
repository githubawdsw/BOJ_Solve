// BOJ_16174


int n = int.Parse(Console.ReadLine());

int[,] board = new int[70, 70];
int[] dx = { 1, 0 };
int[] dy = { 0, 1 };
for (int i = 0; i < n; i++)
{
	int[] groundInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		board[i, j] = groundInfo[j];
	}
}

bool[,] vis = new bool[70, 70];
Queue<(int, int)> q = new Queue<(int, int)>();
q.Enqueue((0, 0));

while (q.Count > 0)
{
	var cur = q.Dequeue();
	if(cur.Item1 == n -1 && cur.Item2 == n - 1)
	{
        Console.WriteLine("HaruHaru");
        return;
	}
	for (int i = 0; i < 2; i++)
	{
		int nx = cur.Item1 + dx[i] * board[cur.Item1, cur.Item2];
        int ny = cur.Item2 + dy[i] * board[cur.Item1, cur.Item2];

		if (nx < 0 || ny < 0 || nx >= n || ny >= n)
			continue;
		if (vis[nx, ny])
			continue;

		vis[nx, ny] = true;
		q.Enqueue((nx, ny));
    }
}

Console.WriteLine("Hing");