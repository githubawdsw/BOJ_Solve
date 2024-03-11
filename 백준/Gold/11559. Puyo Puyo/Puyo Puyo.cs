// BOJ_11559


char[,] board = new char[12, 6];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<(int, int)> q = new Queue<(int, int)>();
for (int i = 0; i < 12; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < 6; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

int ans = 0;
int boom;
while (true)
{
	boom = 0;
	for (int i = 11; i >= 0; i--)
	{
		for (int j = 0; j < 6; j++)
		{
			if (board[i,j] != '.')
			{
				q.Enqueue((i, j));
				Counting(board[i, j]);
			}
		}
	}

	if (boom > 0)
		ans++;

	char[,] temp = board.Clone() as char[,];

    Drop();

    bool check = true;
	for (int i = 11; i >= 0; i--)
	{
		for (int j = 0; j < 6; j++)
		{
			if (board[i, j] != temp[i, j])
			{
				check = false;
				break;
			}
		}
		if (!check)
			break;
	}

	if (check)
		break;
}

Console.WriteLine(ans);


void Counting(char target)
{
	int count = 1;
	List<(int, int)> pos = new List<(int, int)>();
	bool[,] vis = new bool[12, 6];
    while (q.Count > 0)
	{
		var cur = q.Dequeue();
		vis[cur.Item1, cur.Item2] = true;
		pos.Add((cur.Item1, cur.Item2));

		for (int i = 0; i < 4; i++)
		{
			int nx = cur.Item1 + dx[i];
			int ny = cur.Item2 + dy[i];

			if (nx < 0 || ny < 0 || nx >= 12 || ny >= 6 || vis[nx,ny])
				continue;
			if (board[nx, ny] == target)
			{
				q.Enqueue((nx, ny));
				count++;
			}
		}
	}
	
	if(count >= 4)
	{
		boom++;
		foreach (var one in pos)
		{
			board[one.Item1, one.Item2] = '.';
		}
	}
}

void Drop()
{
	for (int j = 0; j < 6; j++)
	{
		int start = 11;
		int end = 10;
		while (end >= 0)
		{
			if (board[start, j] == '.' && board[end, j] != '.')
				(board[start, j], board[end, j]) = (board[end, j], board[start, j]);

            if (board[start, j] != '.')
			{
				start--;
				end = start - 1;
			}
			else if (board[end, j] == '.')
				end--;
		}
	}
}