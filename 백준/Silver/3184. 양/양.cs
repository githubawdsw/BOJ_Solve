// BOJ_3184


int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

char[,] board = new char[255, 255];
bool[,] vis = new bool[255, 255];
Queue<(int, int)> q = new Queue<(int, int)>();

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

for (int i = 0; i < r; i++)
{
    string inputinfo = Console.ReadLine();
	for (int j = 0; j < c; j++)
		board[i, j] = inputinfo[j];
}

int sheep = 0;
int wolf = 0;
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        if (board[i, j] != 'o' || board[i,j] == 'v')
        {
            if (vis[i, j])
                continue;

            vis[i, j] = true;
            q.Enqueue((i, j));
            var info = bfs();
            sheep += info.Item1;
            wolf += info.Item2;
        }
    }
}

Console.WriteLine($"{sheep} {wolf}");



(int,int) bfs()
{
    int sheep = 0;
    int wolf = 0;
    while (q.Count != 0)
    {
        var cur = q.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int nx = dx[i] + cur.Item1;
            int ny = dy[i] + cur.Item2;
            if (nx < 0 || ny < 0 || nx >= r || ny >= c)
                continue;
            if (board[nx, ny] == '#' || vis[nx, ny])
                continue;

            if (board[nx, ny] == 'o')
                sheep++;
            if (board[nx, ny] == 'v')
                wolf++;

            vis[nx, ny] = true;
            q.Enqueue((nx, ny));
        }
    }

    if (sheep > wolf)
        wolf = 0;
    else
        sheep = 0;

    return (sheep, wolf);
}