// BOJ_3187


int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

char[,] board = new char[255,255];
bool[,] vis = new bool[255, 255];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
int sheepSum = 0; int wolfSum = 0;

for (int i = 0; i < r; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

for (int i = 0; i < r; i++)
{
	for (int j = 0; j < c; j++)
	{
		if (board[i,j] != '#' && !vis[i, j])
		{
			vis[i, j] = true;
			q.Enqueue((i, j));
			Bfs();
		}
	}
}

Console.WriteLine(sheepSum + " " + wolfSum);


void Bfs()
{
	int sheep = 0; int wolf = 0;
	while (q.Count > 0)
	{
		var cur = q.Dequeue();

        if (board[cur.Item1, cur.Item2] == 'v')
            wolf++;
        else if (board[cur.Item1, cur.Item2] == 'k')
            sheep++;

        for (int i = 0; i < 4; i++)
		{
			int nx = cur.Item1 + dx[i];
			int ny = cur.Item2 + dy[i];

			if (nx < 0 || ny < 0 || nx >= r || ny >= c)
				continue;

			if (vis[nx, ny] || board[nx, ny] == '#')
				continue;

			vis[nx, ny] = true;
			q.Enqueue((nx, ny));
			
		}
	}

	if (sheep > wolf)
		sheepSum += sheep;
	else
		wolfSum += wolf;
}