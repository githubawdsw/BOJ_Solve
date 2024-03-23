// BOJ_13565


int[] inputmn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = inputmn[0];
int n = inputmn[1];

int[,] board = new int[1005,1005];
bool[,] vis = new bool[1005, 1005];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();

for (int i = 0; i < m; i++)
{
	string inputData = Console.ReadLine();
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputData[j] - '0';
	}
}

for (int i = 0; i < n; i++)
{
	if (board[0, i] == 0)
	{
		q.Enqueue((0, i));
		vis[0, i] = true;
	}
}

while (q.Count > 0)
{
	var cur = q.Dequeue();
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];

		if (nx < 0 || ny < 0 || nx >= m || ny >= n)
			continue;
		if (vis[nx, ny] || board[nx, ny] == 1)
			continue;

		vis[nx, ny] = true;
		q.Enqueue((nx, ny));
	}
}

for (int i = 0; i < n; i++)
{
	if (vis[m - 1, i])
	{
        Console.WriteLine("YES");
        return;
	}
}

Console.WriteLine("NO");