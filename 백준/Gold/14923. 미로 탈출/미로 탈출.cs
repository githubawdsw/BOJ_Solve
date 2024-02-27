// BOJ_14923


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] inputH = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int hx = inputH[0];
int hy = inputH[1];

int[] inputE = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int ex = inputE[0];
int ey = inputE[1];

int[,] board = new int[1005, 1005];
Queue<(int, int, int)> q = new Queue<(int, int, int)>();
int[,,] dis = new int[1005, 1005, 2];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

dis[hx, hy, 0] = 1;
q.Enqueue((hx, hy, 0));
for (int i = 1; i <= n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 1; j <= m; j++)
	{
		board[i, j] = inputInfo[j - 1];
	}
}

while (q.Count > 0)
{
	var cur = q.Dequeue();
	if (cur.Item1 == ex && cur.Item2 == ey)
		break;
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];
		if (nx <= 0 || ny <= 0 || nx > n || ny > m)
			continue;
		if (dis[nx, ny, cur.Item3] != 0)
			continue;

		if (cur.Item3 == 1 && board[nx, ny] == 1)
			continue;
		else if (board[nx,ny] == 0)
		{
			q.Enqueue((nx, ny, cur.Item3));
			dis[nx, ny, cur.Item3] = dis[cur.Item1, cur.Item2, cur.Item3] + 1;

		}
		else
		{
            q.Enqueue((nx, ny, cur.Item3 + 1));
            dis[nx, ny, cur.Item3 + 1] = dis[cur.Item1, cur.Item2, cur.Item3] + 1;
        }

    }
}

if (dis[ex, ey, 0] == 0 && dis[ex, ey, 1] == 0)
	Console.WriteLine(-1);
else if (dis[ex, ey, 0] == 0)
	Console.WriteLine(dis[ex, ey, 1] - 1);
else if (dis[ex, ey, 1] == 0)
	Console.WriteLine(dis[ex, ey, 0] - 1);
else
    Console.WriteLine(Math.Min(dis[ex, ey, 0], dis[ex, ey, 1]) - 1);
