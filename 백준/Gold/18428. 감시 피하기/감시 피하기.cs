// BOJ_18428


int n = int.Parse(Console.ReadLine());
char[,] board = new char[7, 7];
bool[,] vis = new bool[7, 7];
Queue<(int, int)> q = new Queue<(int, int)>();
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
for (int i = 0; i < n; i++)
{
	string[] inputData = Console.ReadLine().Split(' ');
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputData[j][0];
        if (board[i, j] == 'T')
            q.Enqueue((i, j));
	}
}


int ans = 0;
Dfs(0, 0, 0);

if (ans == 1)
{
    Console.WriteLine("YES");
    return;
}

Console.WriteLine("NO");


void Dfs(int x, int y, int depth)
{
	if(depth == 3)
	{
        Queue<(int, int)> copy = new Queue<(int, int)>(q);
        while (copy.Count > 0)
        {
            var cur = copy.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int nx = cur.Item1 + dx[i];
                int ny = cur.Item2 + dy[i];
                while (nx >= 0 && ny >= 0 && nx < n && ny < n)
                {
                    if (board[nx, ny] == 'S')
                        return;
                    if (vis[nx, ny])
                        break;
                    nx += dx[i];
                    ny += dy[i];
                }
            }
        }
		ans = 1;
		return;
	}

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (vis[i, j])
                continue;
            if (board[i, j] == 'X')
            {
                vis[i, j] = true;
                Dfs(i, j, depth + 1);
                vis[i, j] = false;
            }
        }
    }
}