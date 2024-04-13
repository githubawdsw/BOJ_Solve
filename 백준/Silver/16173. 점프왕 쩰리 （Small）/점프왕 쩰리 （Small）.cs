// BOJ_16173


int n = int.Parse(Console.ReadLine());

int[,] board = new int[3, 3];
bool[,] vis = new bool[3, 3];
int[] dx = { 1, 0 };
int[] dy = { 0, 1 };
for (int i = 0; i < n; i++)
{
	int[] scaffoldingInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		board[i,j] = scaffoldingInfo[j];
	}
}

Queue<(int, int)> q = new Queue<(int, int)>();
q.Enqueue((0, 0));
while (q.Count > 0)
{
	var cur = q.Dequeue();
	if (cur.Item1 == n - 1 && cur.Item2 == n - 1)
		break;
	int scaffolding = board[cur.Item1, cur.Item2];

    for (int i = 0; i < 2; i++)
	{
		int nx = cur.Item1 + dx[i] * scaffolding;
		int ny = cur.Item2 + dy[i] * scaffolding;

		if (nx < 0 || ny < 0 || nx >= n || ny >= n)
			continue;
		if (vis[nx, ny])
			continue;

		vis[nx, ny] = true;
		q.Enqueue((nx, ny));
	}
}

if (vis[n - 1, n - 1])
	Console.WriteLine("HaruHaru");
else
	Console.WriteLine("Hing");