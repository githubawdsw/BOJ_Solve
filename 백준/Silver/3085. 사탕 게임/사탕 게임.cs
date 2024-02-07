// BOJ_3085


int n = int.Parse(Console.ReadLine());
char[,] board = new char[55, 55];

int[] d = { 1, -1 };

for (int i = 0; i < n; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

int ans = 0;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		ans = Math.Max(CountingFuc(board, i, j, 0), ans);
		ans = Math.Max(CountingFuc(board, i, j, 1), ans);
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		if (board[i,j] != board[i + 1 , j] && i + 1 < n)
		{
			char[,] copy = board.Clone() as char[,];

            (copy[i, j], copy[i + 1, j]) = (copy[i + 1, j], copy[i, j]);
            ans = Math.Max(CountingFuc(copy, i, j, 0), ans);
            ans = Math.Max(CountingFuc(copy, i + 1, j, 0), ans);
            ans = Math.Max(CountingFuc(copy, i, j, 1), ans);
            ans = Math.Max(CountingFuc(copy, i + 1, j, 1), ans);
        }
        if (board[i, j] != board[i, j + 1] && j + 1 < n)
        {
            char[,] copy = board.Clone() as char[,];

            (copy[i, j], copy[i, j + 1]) = (copy[i, j + 1], copy[i, j]);
            ans = Math.Max(CountingFuc(copy, i, j , 1), ans);
			ans = Math.Max(CountingFuc(copy, i, j + 1, 1), ans);
            ans = Math.Max(CountingFuc(copy, i, j, 0), ans);
            ans = Math.Max(CountingFuc(copy, i, j + 1, 0), ans);
        }
    }

}

Console.WriteLine(ans);


int CountingFuc(char[,] copy,int x, int y, int dir)
{
	Queue<(int, int)> q = new Queue<(int, int)>();
	bool[,] vis = new bool[55, 55];
	int max = 0;
	if (dir == 0)
	{
		q.Enqueue((x, y));
		char target = copy[x, y];
		vis[x, y] = true;
		int count = 1;
		while (q.Count > 0)
		{
			var cur = q.Dequeue();
			for (int i = 0; i < 2; i++)
			{
				int nx = cur.Item1;
				int ny = d[i] + cur.Item2;
				if (ny < 0 || ny >= n)
					continue;
				if (target != copy[nx, ny] || vis[nx,ny])
					continue;
				vis[nx, ny] = true;
				count++;
				q.Enqueue((nx, ny));
			}
		}
		max = count;
	}
	else
	{
        q.Enqueue((x, y));
        char target = copy[x, y];
        vis[x, y] = true;
		int count = 1;
        while (q.Count > 0)
        {
            var cur = q.Dequeue();
            for (int i = 0; i < 2; i++)
            {
                int nx = d[i] + cur.Item1;
                int ny = cur.Item2;
                if (nx < 0 || nx >= n)
                    continue;
                if (target != copy[nx, ny] || vis[nx, ny])
                    continue;
                vis[nx, ny] = true;
				count++;
                q.Enqueue((nx, ny));
            }
        }
		max = count;
    }
	return max;
}