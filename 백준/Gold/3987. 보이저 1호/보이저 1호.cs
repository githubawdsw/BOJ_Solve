// BOJ_3987


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

char[,] board = new char[505, 505];
for (int i = 0; i < n; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int pr = inputrc[0] - 1;
int pc = inputrc[1] - 1;

Dictionary<char, (int, int)> dict = new Dictionary<char, (int, int)>
{
	{ 'U', (-1, 0) } , {'R', (0,1) },{ 'D',(1,0) },{ 'L',(0,-1)}
};
char ans1 = default;
int ans2 = 0;

Solve('L');
Solve('D');
Solve('R');
Solve('U');

if(ans2 == int.MaxValue)
{
    Console.WriteLine(ans1);
    Console.WriteLine("Voyager");
}
else
{
    Console.WriteLine(ans1);
    Console.WriteLine(ans2 + 1);
}

void Solve(char start)
{
	char dir = start;
	Queue<(int, int)> q = new Queue<(int, int)>();
	int time = 0;

	q.Enqueue((pr, pc ));
	while (q.Count > 0)
	{
		var cur = q.Dequeue();
		int nx = cur.Item1 + dict[dir].Item1;
		int ny = cur.Item2 + dict[dir].Item2;

		if (nx < 0 || ny < 0 || nx >= n || ny >= m || board[nx,ny] == 'C')
		{
			if(time >= ans2)
			{
				ans1 = start;
				ans2 = time;
			}
			return;
		}
		if (nx == pr && ny == pc && dir == start)
		{
			ans1 = start;
			ans2 = int.MaxValue;
			return;
		}
		time++;
		q.Enqueue((nx, ny));

		if (board[nx,ny] == '/' || board[nx,ny] == '\\')
		{
			switch (dir)
			{
				case 'U':
					if (board[nx, ny] == '/')
						dir = 'R';
					else if (board[nx, ny] == '\\')
						dir = 'L';
					break;

				case 'R':
					if (board[nx, ny] == '/')
						dir = 'U';
					else if (board[nx, ny] == '\\')
						dir = 'D';
					break;

				case 'D':
					if (board[nx, ny] == '/')
						dir = 'L';
					else if (board[nx, ny] == '\\')
						dir = 'R';
					break;

				case 'L':
					if (board[nx, ny] == '/')
						dir = 'D';
					else if (board[nx, ny] == '\\')
						dir = 'U';
					break;
			}
		}
    }
}

