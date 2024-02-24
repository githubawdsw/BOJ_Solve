// BOJ_17836


int[] inputnmt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmt[0];
int m = inputnmt[1];
int t = inputnmt[2];

int[,] board = new int[105, 105];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int[,,] dis = new int[105, 105, 2];

for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

Queue<(int, int , int)> q = new Queue<(int, int, int)>();
q.Enqueue((0, 0, 0));

while (q.Count > 0)
{
    var cur = q.Dequeue();
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];

		if (nx < 0 || ny < 0 || nx >= n || ny >= m)
			continue;
		if (dis[nx, ny, cur.Item3] > 0 || (cur.Item3 == 0 && board[nx,ny] == 1))
			continue;

        

		if (board[nx, ny] == 2)
		{
			q.Enqueue((nx, ny, 1));
            dis[nx, ny, cur.Item3 + 1] = dis[cur.Item1, cur.Item2, cur.Item3] + 1;
        }
		else
		{
			q.Enqueue((nx, ny, cur.Item3));
            dis[nx, ny, cur.Item3] = dis[cur.Item1, cur.Item2, cur.Item3] + 1;
        }
	}
}

if ((dis[n - 1, m - 1, 0] == 0 && dis[n - 1, m - 1, 1] == 0) 
	|| (dis[n - 1, m - 1, 0]  == 0 && dis[n - 1, m - 1, 1] > t)
    || (dis[n - 1, m - 1, 0] > t && dis[n - 1, m - 1, 1] == 0)
    || (dis[n - 1, m - 1, 0] > t && dis[n - 1, m - 1, 1] > t))
	Console.WriteLine("Fail");
else
{
	if (dis[n - 1, m - 1, 0] == 0)
		Console.WriteLine(dis[n - 1, m - 1, 1]);
	else if (dis[n - 1, m - 1, 1] == 0)
        Console.WriteLine(dis[n - 1, m - 1, 0]);
    else
		Console.WriteLine(Math.Min(dis[n - 1, m - 1, 1], dis[n - 1, m - 1, 0]));
}
