// BOJ_21736


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

Queue<(int,int)> q = new Queue<(int,int)> ();
char[,] board = new char[605, 605];
bool[,] vis = new bool[605, 605];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
for (int i = 0; i < n; i++)
{
	string inputinfo = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputinfo[j];
		if (board[i, j] == 'I')
		{
			q.Enqueue(new(i, j));
			vis[i, j] = true;
		}
	}
}

int ans = 0;
while (q.Count > 0)
{
	var cur = q.Dequeue();
	for (int i = 0; i < 4; i++)
	{
		int nx = dx[i] + cur.Item1;
		int ny = dy[i] + cur.Item2;
		if (nx < 0 || ny < 0 || nx >= n || ny >= m)
			continue;
		if (vis[nx, ny] || board[nx,ny] == 'X')
			continue;
        if (board[nx, ny] == 'P')
			ans++;

		vis[nx, ny] = true;
		q.Enqueue(new(nx, ny));
	}
}

if (ans == 0)
	Console.WriteLine("TT");
else
	Console.WriteLine(ans);
