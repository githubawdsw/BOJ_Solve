// BOJ_16236


int n = int.Parse(Console.ReadLine());

int[,] board = new int[25, 25];
int[] dx = { -1, 0, 0, 1 };
int[] dy = { 0, -1, 1, 0 };
Queue<(int, int)> q = new Queue<(int, int)>();

for (int i = 0; i < n; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputInfo[j];
		if (board[i, j] == 9)
		{
			q.Enqueue((i, j));
			board[i, j] = 0;
		}
	}
}

int size = 2;
int count = 0;
int time = 0;
int[,] dis;
SortedSet<(int, int, int)> ss = new SortedSet<(int, int, int)>();

move();


Console.WriteLine(time);



void move()
{
	(int, int, int) pos = (0, q.Peek().Item1, q.Peek().Item2);
	ss.Add(pos);

	while (ss.Count > 0)
	{
		dis = new int[25, 25];
		ss.Clear();
		int min = int.MaxValue;

		while (q.Count > 0)
		{
			var cur = q.Dequeue();
			for (int i = 0; i < 4; i++)
			{
				int nx = cur.Item1 + dx[i];
				int ny = cur.Item2 + dy[i];

				if (nx < 0 || ny < 0 || nx >= n || ny >= n)
					continue;
				if (board[nx, ny] > size || dis[nx, ny] > 0)
					continue;

				dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;

				if (board[nx, ny] != 0 && board[nx, ny] < size)
				{
					min = Math.Min(dis[nx, ny], min);
					ss.Add((dis[nx, ny], nx, ny));
				}

				if (dis[nx,ny] <= min)
					q.Enqueue((nx, ny));
			}
		}

		if(ss.Count > 0)
		{
			pos = ss.First();
			q.Enqueue((pos.Item2, pos.Item3));
			board[pos.Item2, pos.Item3] = 0;
            time += pos.Item1;

			count++;
			if (count == size)
			{
				size++;
				count = 0;
			}
		}
	}
}
