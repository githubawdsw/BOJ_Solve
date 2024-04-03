// BOJ_1388


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

char[,] board = new char[55, 55];
bool[,] check = new bool[55, 55];
for (int i = 0; i < n; i++)
{
	string inputData = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputData[j];
	}
}

int ans = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
		if (!check[i, j])
		{
			Dfs(i, j, board[i, j]);
			ans++;
		}
    }
}

Console.WriteLine(ans);


void Dfs(int x, int y , char target)
{
	Stack<(int, int)> s = new Stack<(int, int)>();
	s.Push((x, y));
	check[x, y] = true;
	if(target == '-')
	{
		while (s.Count > 0)
		{
			var cur = s.Pop();
			int nx = x;
			int ny = cur.Item2 + 1;
			if (ny >= m || board[nx, ny] != target)
				break;

			if (!check[nx, ny])
			{
				check[nx, ny] = true;
				s.Push((nx, ny));
			}
		}
	}
	else
	{
        while (s.Count > 0)
        {
            var cur = s.Pop();
            int nx = cur.Item1 + 1;
            int ny = y;
            if (nx >= n || board[nx, ny] != target)
                break;

            if (!check[nx, ny])
            {
                check[nx, ny] = true;
                s.Push((nx, ny));
            }
        }
    }
}