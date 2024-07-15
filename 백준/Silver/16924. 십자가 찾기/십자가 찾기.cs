// BOJ_16924


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

char[,] board = new char[105, 105];
bool[,] check = new bool[105, 105];
List<(int, int, int)> list = new List<(int, int, int)>();
for (int i = 0; i < n; i++)
{
	string inputInfo = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j];
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		if(board[i,j] == '*')
		{
			int up = i;
			int down = i;
			int left = j;
			int right = j;
			int length = 0;
			for (int k = 1; k < 50; k++)
			{
				if (up - k < 0 || left - k < 0 || down + k >= n || right + k >= m)
					break;
				if (board[up - k, j] == '.' || board[down + k, j] == '.'
					|| board[i, left - k] == '.' || board[i, right + k] == '.')
					break;

				check[i, j] = true;
				check[up - k, j] = true; check[down + k, j] = true;
				check[i, left - k] = true; check[i, right + k] = true;
				length++;
			}
			if (length != 0)
				list.Add((i + 1, j + 1, length));
		}
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		if (!check[i,j] && board[i,j] == '*')
		{
            Console.WriteLine(-1);
			return;
        }
	}
}

sb.AppendLine(list.Count.ToString());
for (int i = 0; i < list.Count; i++)
{
	sb.AppendLine($"{list[i].Item1} {list[i].Item2} {list[i].Item3}");
}

Console.WriteLine(sb);