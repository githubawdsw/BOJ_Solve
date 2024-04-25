// BOJ_11967


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

Dictionary<(int, int), List<(int, int)>> dict = new Dictionary<(int, int), List<(int, int)>>();
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
bool[,] light = new bool[105, 105];
bool[,] turnOn = new bool[105, 105];
bool[,] vis = new bool[105, 105];
for (int i = 0; i < m; i++)
{
	int[] inputxyab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	int x = inputxyab[0];
	int y = inputxyab[1];
	int a = inputxyab[2];
	int b = inputxyab[3];
	if (!dict.ContainsKey((x, y)))
		dict[(x, y)] = new List<(int, int)>();
	dict[(x, y)].Add((a, b));
}

Queue<(int, int)> q = new Queue<(int, int)>();
int ans = 0;
light[1, 1] = true;
vis[1, 1] = true;
turnOn[1, 1] = true;
q.Enqueue((1, 1));
while (q.Count > 0)
{
	var cur = q.Dequeue();
	if (dict.ContainsKey((cur.Item1, cur.Item2)))
	{
		foreach (var one in dict[(cur.Item1,cur.Item2)])
		{
			light[one.Item1, one.Item2] = true;
		}
		if (!turnOn[cur.Item1, cur.Item2])
		{
			vis = new bool[105, 105];
			vis[cur.Item1, cur.Item2] = true;
			turnOn[cur.Item1, cur.Item2] = true;
		}
	}
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];

		if (nx <= 0 || ny <= 0 || nx > n || ny > n)
			continue;
		if (!light[nx, ny] || vis[nx,ny])
			continue;

		vis[nx, ny] = true;
		q.Enqueue((nx, ny));
	}
}

for (int i = 1; i <= n; i++)
{
	for (int j = 1; j <= n; j++)
	{
		if (light[i, j])
			ans++;
	}
}

Console.WriteLine(ans);