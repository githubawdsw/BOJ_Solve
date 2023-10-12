// BOJ_1743



string[] inputnmk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnmk[0]);
int m = int.Parse(inputnmk[1]);
int k = int.Parse(inputnmk[2]);

int[,] board = new int[105, 105];
bool[,] vis = new bool[105, 105];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<Tuple<int,int>> q = new Queue<Tuple<int,int>>();
int ans = 0;

for (int i = 0; i < k; i++)
{
    string[] inputrc = Console.ReadLine().Split(' ');
    int r = int.Parse(inputrc[0]);
    int c = int.Parse(inputrc[1]);
    board[r, c] = 1;
}

for (int i = 0; i <= n; i++)
{
    for (int j = 0; j <= m; j++)
    {
        if (!vis[i,j])
        {
            q.Enqueue(new Tuple<int, int>(i, j));
            bfs();
        }
    }
}
Console.WriteLine(  ans );

void bfs()
{
    int count = 0;
    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int nx = dx[i] + cur.Item1;
            int ny = dy[i] + cur.Item2;
            if (nx < 0 || ny < 0 || nx > n || ny > m)
                continue;
            if (board[nx, ny] == 0 || vis[nx,ny])
                continue;
            vis[nx, ny] = true;
            q.Enqueue(new Tuple<int, int>(nx, ny));
            count++;
        }
    }
    ans = Math.Max(count, ans);
}