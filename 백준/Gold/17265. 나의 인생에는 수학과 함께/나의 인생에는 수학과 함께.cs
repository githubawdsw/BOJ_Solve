// BOJ_17265


int n = int.Parse(Console.ReadLine());

char[,] board = new char[7, 7];
int[] dx = { 1, 0 };
int[] dy = { 0, 1 };

for (int i = 0; i < n; i++)
{
    string[] inputInfo = Console.ReadLine().Split(' ');
	for (int j = 0; j < n; j++)
	{
		board[i, j] = char.Parse(inputInfo[j]);
	}
}

int[,] max = new int[7, 7];
int[,] min = new int[7, 7];
Queue<(int, int, int, char)> q = new Queue<(int, int, int, char)>();
q.Enqueue((0, 0, board[0, 0] - '0', ' '));
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		max[i, j] = int.MinValue;
		min[i, j] = int.MaxValue;
	}
}

while (q.Count > 0)
{
	var cur = q.Dequeue();

	for (int i = 0; i < 2; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];

		if (nx >= n || ny >= n)
			continue;

		if (board[nx, ny] == '+' || board[nx, ny] == '*' || board[nx, ny] == '-')
		{
			q.Enqueue((nx, ny, cur.Item3, board[nx,ny]));
			continue;
		}
		else
		{
			if (cur.Item4 == '+')
			{
                max[nx, ny] = Math.Max(max[nx, ny], cur.Item3 + (board[nx, ny] - '0'));
                min[nx, ny] = Math.Min(min[nx, ny], cur.Item3 + (board[nx, ny] - '0'));

            }
            else if (cur.Item4 == '*')
            {
                max[nx, ny] = Math.Max(max[nx, ny], cur.Item3 * (board[nx, ny] - '0'));
                min[nx, ny] = Math.Min(min[nx, ny], cur.Item3 * (board[nx, ny] - '0'));

            }
            else
            {
                max[nx, ny] = Math.Max(max[nx, ny], cur.Item3 - (board[nx, ny] - '0'));
                min[nx, ny] = Math.Min(min[nx, ny], cur.Item3 - (board[nx, ny] - '0'));

            }
            q.Enqueue((nx, ny, max[nx, ny], ' '));
            q.Enqueue((nx, ny, min[nx, ny], ' '));
        }

	}
}

Console.WriteLine($"{max[n - 1, n - 1]} {min[n - 1, n - 1]}");