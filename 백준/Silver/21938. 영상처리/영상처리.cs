// BOJ_21938


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[1005, 1005];
for (int i = 0; i < n; i++)
{
    int[] inputPixelInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        int sum = inputPixelInfo[j * 3] + inputPixelInfo[j * 3 + 1] + inputPixelInfo[j * 3 + 2];
        board[i, j] = sum / 3;
    }
}

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (board[i, j] >= t)
            board[i, j] = 255;
        else
            board[i, j] = 0;
    }
}

int ans = 0;
Queue<(int, int)> q = new Queue<(int, int)>();
bool[,] vis = new bool[1005, 1005];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (board[i, j] == 255 && !vis[i, j])
        {
            Bfs(i,j);
            ans++;
        }
    }
}

Console.WriteLine(ans);


void Bfs(int x , int y)
{
    q.Enqueue((x, y));

    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int nx = cur.Item1 + dx[i];
            int ny = cur.Item2 + dy[i];

            if (nx < 0 || ny < 0 || nx >= n || ny >= m)
                continue;
            if (board[nx, ny] == 0 || vis[nx, ny])
                continue;

            vis[nx, ny] = true;
            q.Enqueue((nx, ny));
        }
    }
}