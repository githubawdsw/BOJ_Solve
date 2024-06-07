// BOJ_17129


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

char[,] board = new char[3005,3005];
int[,] dis = new int[3005, 3005];
Queue<(int, int)> q = new Queue<(int, int)>();
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

for (int i = 0; i < n; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
		if (board[i, j] == '2')
			q.Enqueue((i, j));
	}
}

int ans = int.MaxValue;
while (q.Count > 0)
{
	var cur = q.Dequeue();
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];

		if (nx < 0 || ny < 0 || nx >= n || ny >= m)
			continue;
		if (dis[nx, ny] > 0|| board[nx, ny] == '1')
			continue;

		dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
		q.Enqueue((nx, ny));
		if (board[nx,ny] == '3' || board[nx,ny] == '4' || board[nx,ny] == '5')
			ans = dis[nx, ny];
	}
	if (ans != int.MaxValue)
		break;
}

if(ans == int.MaxValue)
{
    Console.WriteLine("NIE");
}
else
{
    Console.WriteLine("TAK");
    Console.WriteLine(ans);
}
