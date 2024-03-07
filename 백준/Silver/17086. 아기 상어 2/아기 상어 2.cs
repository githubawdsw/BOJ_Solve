// BOJ_17086


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[n, m];
int[,] dis = new int[n, m];
int[] dx = { 1, 0, -1, 0, 1, 1, -1, -1 };
int[] dy = { 0, 1, 0, -1, 1, -1, 1, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i,j] = inputInfo[j];
        if (inputInfo[j] == 1)
            q.Enqueue((i, j));
	}
}

int ans = 0;
while (q.Count > 0)
{
    var cur = q.Dequeue();
    for (int i = 0; i < 8; i++)
    {
        int nx = cur.Item1 + dx[i];
        int ny = cur.Item2 + dy[i];

        if (nx < 0 || ny < 0 || nx >= n || ny >= m)
            continue;
        if (dis[nx, ny] > 0 || board[nx,ny] == 1)
            continue;

        dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
        ans = Math.Max(ans, dis[nx, ny]);
        q.Enqueue((nx, ny));
    }
}

Console.WriteLine(ans);